using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public class RecipeService : IRecipeService
    {   
        private readonly IMapper _mapper;
        private readonly NCDbContext _context;
        private readonly ICalculatedService _calculatedService;
        public RecipeService(IMapper mapper, NCDbContext context, ICalculatedService calculatedService)
        {
            _mapper = mapper;
            _context = context;
            _calculatedService = calculatedService;
        }
        public async Task<List<RecipeDto>> Get(RecipeSearchRequest request,CancellationToken token=default)
        {
            if (request.number < 0)
            {
                throw new ArgumentException("Value can' be below 0");
            }
            var query = _context.Recipes
                .Include(x => x.RecipeCategory)
                .Include(x => x.MyUser)
                .Include(x => x.IngredientRecipes)
                .Take(request.number)
                .AsQueryable();

            if (request?.categoryId.HasValue ?? false) 
            {
                query = query.Where(x => x.RecipeCategoryId == request.categoryId);
            }
            if (!string.IsNullOrWhiteSpace(request?.SearchTerm))
            {
                var normalizedName = request.SearchTerm.ToLower();
                query = query.Where(x => x.Name.ToLower().Contains(normalizedName)
                || x.Description.ToLower().Contains(normalizedName));
            }
            var list = await query.ToListAsync(token);
            return _mapper.Map<List<RecipeDto>>(list);
        }

        public async Task<RecipeDto> GetById(int id)
        {
            var entity = await _context.Recipes
                .Include(q=>q.MyUser)
                .Include(q=>q.RecipeCategory)
                .Include(q=>q.IngredientRecipes).
                FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<RecipeDto>(entity);
        }
        public async Task<Recipe> Insert(RecipeInsertRequest request)
        {
            if(request.Ingredients.GroupBy(x => x.IngredientId).Any(x => x.Count() > 1))
            {
                throw new ArgumentException("Ingredients should be unique");
            }
            if (request.Ingredients.Count() == 0)
            {
                throw new ArgumentException("You must add at least one ingredient");
            }
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var entity = _mapper.Map<Recipe>(request);
                await _context.Recipes.AddAsync(entity);
                await _context.SaveChangesAsync();
                var ingredientRecipe = _mapper.Map<List<IngredientRecipe>>(request.Ingredients);
                //ingredientRecipe.ForEach(x => x.RecipeId = entity.Id);
                ingredientRecipe.ForEach(x => x.Recipe = entity);
                await _context.IngredientRecipes.AddRangeAsync(ingredientRecipe);
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
        public async Task<RecipeDetailsDto> RecipeDetails(int id)
        {
            var recipeDetails = await _context.Recipes.Include(x=>x.IngredientRecipes).
                ThenInclude(x => x.Ingredient).Select(q => new RecipeDetailsDto
            {
                RecipeId = q.Id,
                Name = q.Name,
                Description = q.Description,
                IngredientRecipes = _mapper.Map<List<IngredientRecipeDto>>(q.IngredientRecipes)
                }).FirstOrDefaultAsync(q => q.RecipeId == id);

            //float sum = 0;
            //foreach (var x in recipeDetails.IngredientRecipes)
            //{
            //    var ingredientRecipeQuantity = x.Quantity;
            //    var ingredientUnitPrice = x.Ingredient.UnitPrice;
            //    var ingredientUnitQuantity = x.Ingredient.UnitQuantity;

            //    x.IngredientCost= (ingredientRecipeQuantity * ingredientUnitPrice) / ingredientUnitQuantity;
            //    sum = sum + x.IngredientCost;
            //}
          
            recipeDetails.TotalCost = _calculatedService.CalculateRecipe(recipeDetails);
            return recipeDetails;

        }
        //public float RecipeCost(RecipeDetailsDto recipeDetails)
        //{
        //    float sum = 0;
        //    foreach (var x in recipeDetails.IngredientRecipes)
        //    {
        //        var ingredientRecipeQuantity = x.Quantity;
        //        var ingredientUnitPrice = x.Ingredient.UnitPrice;
        //        var ingredientUnitQuantity = x.Ingredient.UnitQuantity;
        //        x.IngredientCost = (ingredientRecipeQuantity * ingredientUnitPrice) / ingredientUnitQuantity;
        //        sum = sum + x.IngredientCost;
        //    }
        //    return sum;
        //}

        // procedures
        public Task<IEnumerable<GetAllRecipesResponse>> GetAllRecipes()
        {
            var list= _context.Database.GetDbConnection().QueryAsync<GetAllRecipesResponse>("GetAllRecipes", commandType:System.Data.CommandType.StoredProcedure);
            return list;
        }
        public Task<IEnumerable<GetRecipesByCategoryNameResponse>> GetRecipesByCategoryName()
        {
            var list = _context.Database.GetDbConnection().QueryAsync<GetRecipesByCategoryNameResponse>
                 ("GetRecipesByCategoryName", commandType: System.Data.CommandType.StoredProcedure);
            return list;
        }
    }
}
