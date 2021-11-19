﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Core.Entities;
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
    public class RecipeService : IRecipeService
    {
        private readonly NCDbContext _context;
        private readonly IMapper _mapper;

        public RecipeService(NCDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<RecipeDto>> Get(RecipeSearchRequest request)
        {
            //var list = await _context.Recipes.Include(x => x.MyUser).Include(x => x.RecipeCategory)
            //     .Include(x => x.IngredientRecipes)
            //     .Where(x => x.RecipeCategoryId == request.categoryId)
            //     .OrderBy(x => x.TotalCost).Where(x => (string.IsNullOrWhiteSpace(request.SearchTerm)) ||
            //     x.Name.ToLower().StartsWith(request.SearchTerm.ToLower()) ||
            //     x.Description.ToLower().StartsWith(request.SearchTerm.ToLower()) ||
            //     x.IngredientRecipes.Any(a => a.Ingredient.Name.ToLower().Contains(request.SearchTerm)))
            //     .ToListAsync();

            //return _mapper.Map<List<RecipeDto>>(list);

            var query = _context.Recipes.Include(x=>x.RecipeCategory).Include(x=>x.MyUser).Include(x=>x.IngredientRecipes).AsQueryable();
            if (request?.categoryId.HasValue ?? false) 
            {
                query = query.Where(x => x.RecipeCategoryId == request.categoryId);
            }
            if (!string.IsNullOrWhiteSpace(request?.SearchTerm))
            {
                var normalizedName = request.SearchTerm.ToLower();
                query = query.Where(x => x.Name.ToLower().Contains(normalizedName) || x.Description.ToLower().Contains(normalizedName));
            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<RecipeDto>>(list);
        }

        public async Task<RecipeDto> GetById(int id)
        {
            var entity = await _context.Recipes.Include(q=>q.MyUser).Include(q=>q.RecipeCategory).Include(q=>q.IngredientRecipes).FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<RecipeDto>(entity);
        }
        public async Task<Recipe> Insert(RecipeInsertRequest request)
        {

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var entity = _mapper.Map<Recipe>(request);
                await _context.Recipes.AddAsync(entity);
                await _context.SaveChangesAsync();
                var ingredientRecipe = _mapper.Map<List<IngredientRecipe>>(request.Ingredients);
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
            var recipeDetails = await _context.Recipes.Include(x=>x.IngredientRecipes).ThenInclude(x => x.Ingredient).Select(q => new RecipeDetailsDto
            {
                RecipeId = q.Id,
                Name = q.Name,
                Description = q.Description,
                IngredientRecipes = _mapper.Map<List<IngredientRecipeDto>>(q.IngredientRecipes)
                //MeasureUnit = q.Ingredient.UnitMeasure,
            }).FirstOrDefaultAsync(q => q.RecipeId == id);

            float suma = 0;

            foreach (var x in recipeDetails.IngredientRecipes)
            {
                var ingredientRecipeQuantity = x.Quantity;
                var ingredientUnitPrice = x.Ingredient.UnitPrice;
                var ingredientUnitQuantity = x.Ingredient.UnitQuantity;

                x.IngredientCost= (ingredientRecipeQuantity * ingredientUnitPrice) / ingredientUnitQuantity;
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
