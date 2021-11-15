using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Infrastructure.Context;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public class IngredientRecipeService : IIngredientRecipeService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _context;

        public IngredientRecipeService(IMapper mapper, MyContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<RecipeDetailsDto>> getIngredientRecipes(int recipeId)
        {
            var recipeDetails = await _context.IngredientRecipe.Where(q => q.RecipeId == recipeId).Select(q => new RecipeDetailsDto
            {
                RecipeId = q.RecipeId,
                RecipeName = q.Recipe.RecipeName,
                Description = q.Recipe.Description,
                IngredientId = q.IngredientId,
                IngredientName = q.Ingredient.Name,
                UnitQuantity = q.Ingredient.UnitQuantity,
                MeasureUnit = q.Ingredient.MeasureUnit,
                UnitPrice = q.Ingredient.UnitPrice
            }).ToListAsync();

            float suma = 0;

            foreach (var x in recipeDetails)
            {
                var ingredientRecipeQuantity = _context.IngredientRecipe
                    .Where(q => q.RecipeId == recipeId && q.Ingredient.IngredientsId == x.IngredientId).
                    FirstOrDefault().Quantity;

                var ingredientUnitPrice = _context.IngredientRecipe
                    .Include(q => q.Ingredient).Where(q => q.RecipeId == recipeId && q.Ingredient.IngredientsId == x.IngredientId).
                    FirstOrDefault().Ingredient.UnitPrice;

                var ingredientUnitQuantity = _context.IngredientRecipe.Include(q => q.Ingredient).
                    Where(q => q.RecipeId == recipeId && q.Ingredient.IngredientsId == x.IngredientId).
                    FirstOrDefault().Ingredient.UnitQuantity;

                x.IngredientCost = (ingredientRecipeQuantity * ingredientUnitPrice) / ingredientUnitQuantity;
                suma = suma + x.IngredientCost;
                x.TotalCost = x.TotalCost + suma;
            }
            return recipeDetails;
        }

      
    }
}
