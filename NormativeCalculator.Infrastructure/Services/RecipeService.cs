using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace NormativeCalculator.Infrastructure.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IMapper _mapper;
        private readonly NCDbContext _context;
        private readonly ICalculatedService _calculatedService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public RecipeService(IMapper mapper, NCDbContext context, ICalculatedService calculatedService, IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _context = context;
            _calculatedService = calculatedService;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<List<RecipeDto>> Get(RecipeSearchRequest request)
        {
            if (request.number < 0)
            {
                throw new ArgumentException("Value can' be below 0");
            }
            var query = _context.Recipes
                .Include(x => x.RecipeCategory)
                .Include(x => x.MyUser)
                .Include(x => x.IngredientRecipes)
                .AsQueryable();

            if (request?.categoryId.HasValue ?? false)
            {
                query = query.Where(x => x.RecipeCategoryId == request.categoryId);
            }
            if (!string.IsNullOrWhiteSpace(request?.SearchTerm))
            {
                var normalizedName = request.SearchTerm.ToLower();
                query = query.Where(x => x.Name.ToLower().Contains(normalizedName)
                || x.Description.ToLower().Contains(normalizedName) || x.IngredientRecipes.Any(x=>x.Ingredient.Name.ToLower().Contains(normalizedName)));
            }
            var list = await query.Take(request.number).ToListAsync();
            return _mapper.Map<List<RecipeDto>>(list);
        }

        public async Task<RecipeDto> GetById(int id)
        {
            var entity = await _context.Recipes
                .Include(q => q.MyUser)
                .Include(q => q.RecipeCategory)
                .Include(q => q.IngredientRecipes).
                FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<RecipeDto>(entity);
        }

        public async Task<Recipe> Insert(RecipeRestUpsertModel request)
        {

            if (_context.Recipes.Any(x => x.Name == request.Name))
            {
                throw new ArgumentException("Recipe name already exsist in database");
            }
            if (request.Ingredients.GroupBy(x => x.IngredientId).Any(x => x.Count() > 1))
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
                    entity.CreatedDate = DateTime.Now;
                    var user = _httpContextAccessor.HttpContext.User;
                    var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
                    entity.MyUserId = int.Parse(userId);
                    await _context.Recipes.AddAsync(entity);
                    await _context.SaveChangesAsync();
                    var ingredientRecipe = _mapper.Map<List<IngredientRecipe>>(request.Ingredients);

                    var ingredientIds = request.Ingredients.Select(x => x.IngredientId).ToArray();
                    var ingredients = await _context.Ingredients.Where(x => ingredientIds.Contains(x.Id)).ToListAsync();

                    //ingredientRecipe.ForEach(x => x.RecipeId = entity.Id);
                    ingredientRecipe.ForEach(x =>
                    {
                        x.Recipe = entity;
                        x.Price = _calculatedService.CalculateIngredientRecipe(x, ingredients.FirstOrDefault(y => y.Id == x.IngredientId));
                    });
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
        

        public async Task<Recipe> Update(int id, RecipeUpdateModel request)
        {
            var entity = await _context.Recipes.FindAsync(id);
            entity.CreatedDate = DateTime.Now;
            var user = _httpContextAccessor.HttpContext.User;
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            entity.MyUserId = int.Parse(userId);
            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Recipe> Delete(int id)
        {
            var entity = await _context.Recipes.FindAsync(id);
            _context.Recipes.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<RecipeDetailsDto> RecipeDetails(int id)
        {
            var recipeDetails = await _context.Recipes.Include(x => x.IngredientRecipes).
                ThenInclude(x => x.Ingredient).Select(q => new RecipeDetailsDto
                {
                    RecipeId = q.Id,
                    Name = q.Name,
                    Description = q.Description,
                    IngredientRecipes = _mapper.Map<List<IngredientRecipeDto>>(q.IngredientRecipes)
                }).FirstOrDefaultAsync(q => q.RecipeId == id);

            recipeDetails.TotalCost = _calculatedService.CalculateRecipe(recipeDetails);
            return recipeDetails;

        }


        // procedures
        public Task<IEnumerable<GetAllRecipesResponse>> GetAllRecipes()
        {
            var list = _context.Database.GetDbConnection().QueryAsync<GetAllRecipesResponse>("GetAllRecipes", commandType: System.Data.CommandType.StoredProcedure);
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
