using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
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
    public class RecipeService : IRecipeService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public RecipeService(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<RecipeDto>> get(RecipeSearchRequest request,int categoryId)
        {
            var list = await _context.Recipe.Include(x => x.MyUser).Include(x => x.RecipeCategory)
                 .Include(x => x.IngredientRecipe)
                 .Where(x => x.RecipeCategoryId == categoryId)
                 .OrderBy(x => x.TotalCost).Where(x => (string.IsNullOrWhiteSpace(request.SearchTerm)) ||
                 x.RecipeName.ToLower().StartsWith(request.SearchTerm.ToLower()) ||
                 x.Description.ToLower().StartsWith(request.SearchTerm.ToLower()) ||
                 x.IngredientRecipe.Any(a => a.Ingredient.Name.ToLower().Contains(request.SearchTerm)))
                 .ToListAsync();

            return _mapper.Map<List<RecipeDto>>(list);

        }

        public async Task<RecipeDto> getById(int id)
        {
            var entity = await _context.Recipe.Include(q=>q.MyUser).Include(q=>q.RecipeCategory).Include(q=>q.IngredientRecipe).FirstOrDefaultAsync(x => x.RecipeId == id);
            return _mapper.Map<RecipeDto>(entity);
        }
        public async Task<Recipe> Insert(RecipeInsertRequest request)
        {

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var entity = _mapper.Map<Recipe>(request);
                await _context.Recipe.AddAsync(entity);
                await _context.SaveChangesAsync();
                var ingredientRecipe = _mapper.Map<List<IngredientRecipe>>(request.Ingredients);
                ingredientRecipe.ForEach(x => x.Recipe = entity);
                await _context.IngredientRecipe.AddRangeAsync(ingredientRecipe);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return entity;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        
            
        }

        public async Task<List<RecipeDetailsDto>> RecipeDetails(int id)
        {

            var recipeDetails = await _context.IngredientRecipe.Where(q => q.RecipeId == id).Select(q => new RecipeDetailsDto
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
                    .Where(q => q.RecipeId == id && q.Ingredient.IngredientsId == x.IngredientId).
                    FirstOrDefault().Quantity;

                var ingredientUnitPrice = _context.IngredientRecipe
                    .Include(q => q.Ingredient).Where(q => q.RecipeId == id && q.Ingredient.IngredientsId == x.IngredientId).
                    FirstOrDefault().Ingredient.UnitPrice;

                var ingredientUnitQuantity = _context.IngredientRecipe.Include(q => q.Ingredient).
                    Where(q => q.RecipeId == id && q.Ingredient.IngredientsId == x.IngredientId).
                    FirstOrDefault().Ingredient.UnitQuantity;

                x.IngredientCost = (ingredientRecipeQuantity * ingredientUnitPrice) / ingredientUnitQuantity;
                suma = suma + x.IngredientCost;
                x.TotalCost = x.TotalCost + suma;
            }
            return recipeDetails;

            //var recipe = await _context.Recipe.Include(x => x.IngredientRecipe).
            //    ThenInclude(q => q.Ingredient).FirstOrDefaultAsync(q => q.RecipeId == id);

            //var ingredientRecipe = _context.IngredientRecipe.Select(q => new RecipeDetailsDto
            //{
            //    RecipeName = q.Recipe.RecipeName,
            //    Description = q.Recipe.Description,
            //    IngredientId = q.IngredientId,
            //    IngredientName = q.Ingredient.Name,
            //    UnitQuantity = q.Ingredient.UnitQuantity,
            //    MeasureUnit = q.Ingredient.MeasureUnit,
            //    UnitPrice = q.Ingredient.UnitPrice
            //});

            //float suma = 0;

            //foreach (var x in ingredientRecipe)
            //{
            //    var ingredientRecipeQuantity = _context.IngredientRecipe
            //        .Where(q => q.RecipeId == id && q.Ingredient.IngredientsId == x.IngredientId).
            //        FirstOrDefault().Quantity;

            //    var ingredientUnitPrice = _context.IngredientRecipe
            //        .Include(q => q.Ingredient).Where(q => q.RecipeId == id && q.Ingredient.IngredientsId == x.IngredientId).
            //        FirstOrDefault().Ingredient.UnitPrice;

            //    var ingredientUnitQuantity = _context.IngredientRecipe.Include(q => q.Ingredient).
            //        Where(q => q.RecipeId == id && q.Ingredient.IngredientsId == x.IngredientId).
            //        FirstOrDefault().Ingredient.UnitQuantity;

            //    recipe.IngredientRecipe=
            //    x.IngredientCost = (ingredientRecipeQuantity * ingredientUnitPrice) / ingredientUnitQuantity;
            //    suma = suma + x.IngredientCost;
            //    x.TotalCost = x.TotalCost + suma;
            //}
        }
    }
}
