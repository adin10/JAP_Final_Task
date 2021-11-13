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
            var list = await _context.Recipe.Include(x=>x.MyUser).Include(x=>x.RecipeCategory).Include(x=>x.IngredientRecipe).Where(x => x.RecipeCategoryId == request.categoryId)
                .OrderBy(x => x.TotalCost).Where(x=>(string.IsNullOrWhiteSpace(request.SearchTerm)) || 
                x.RecipeName.ToLower().StartsWith(request.SearchTerm.ToLower()) || 
                x.Description.ToLower().StartsWith(request.SearchTerm.ToLower()) || 
                x.IngredientRecipe.Any(a=>a.Ingredient.Name.ToLower().Contains(request.SearchTerm)))
                .ToListAsync();

            return _mapper.Map<List<RecipeDto>>(list);
        }

        public async Task<RecipeDto> getById(int id)
        {
            var entity = await _context.Recipe.Include(q=>q.MyUser).Include(q=>q.RecipeCategory).FirstOrDefaultAsync(x => x.RecipeId == id);
            return _mapper.Map<RecipeDto>(entity);
        }

        public async Task<List<RecipeDto>> getRecipesByCategoryId(int id)
        {
            var list =await _context.Recipe.Include(x => x.MyUser).Include(x => x.RecipeCategory).Where(q=>q.RecipeCategoryId==id).ToListAsync();
            return _mapper.Map<List<RecipeDto>>(list);
        }

        public async Task<Recipe> Insert(RecipeInsertRequest request)
        {
            var recipe = _mapper.Map<Recipe>(request);
            await _context.Recipe.AddAsync(recipe);
            await _context.SaveChangesAsync();
            return recipe;
        }
    }
}
