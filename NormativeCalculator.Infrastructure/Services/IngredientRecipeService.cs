using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
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
        private readonly NCDbContext _context;

        public IngredientRecipeService(IMapper mapper, NCDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //public async Task<List<RecipeDetailsDto>> GetIngredientRecipes(int recipeId)
        //{
        //    var recipeDetails = await _context.IngredientRecipes.Where(q => q.RecipeId == recipeId).Select(q => new RecipeDetailsDto
        //    {
        //        RecipeId = q.RecipeId,
        //        RecipeName = q.Recipe.Name,
        //        Description = q.Recipe.Description,
        //        IngredientId = q.IngredientId,
        //        IngredientName = q.Ingredient.Name,
        //        UnitQuantity = q.Ingredient.UnitQuantity,
        //        //MeasureUnit = q.Ingredient.MeasureUnit,
        //        UnitPrice = q.Ingredient.UnitPrice
        //    }).ToListAsync();

        //    float suma = 0;

        //    foreach (var x in recipeDetails)
        //    {
        //        var ingredientRecipeQuantity = _context.IngredientRecipes
        //            .Where(q => q.RecipeId == recipeId && q.Ingredient.Id == x.IngredientId).
        //            FirstOrDefault().Quantity;

        //        var ingredientUnitPrice = _context.IngredientRecipes
        //            .Include(q => q.Ingredient).Where(q => q.RecipeId == recipeId && q.Ingredient.Id == x.IngredientId).
        //            FirstOrDefault().Ingredient.UnitPrice;

        //        var ingredientUnitQuantity = _context.IngredientRecipes.Include(q => q.Ingredient).
        //            Where(q => q.RecipeId == recipeId && q.Ingredient.Id == x.IngredientId).
        //            FirstOrDefault().Ingredient.UnitQuantity;

        //        x.IngredientCost = (ingredientRecipeQuantity * ingredientUnitPrice) / ingredientUnitQuantity;
        //        suma = suma + x.IngredientCost;
        //        x.TotalCost = x.TotalCost + suma;
        //    }
        //    return recipeDetails;
        //}

      
    }
}
