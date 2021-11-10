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

        public async Task<List<RecipeDto>> get(RecipeSearchRequest request)
        {
            var query = _context.Recipe.Include(q=>q.MyUser).Include(q=>q.RecipeCategory).AsQueryable();
            if (request != null)
            {
                if (!string.IsNullOrWhiteSpace(request.RecipeName))
                {
                    var normalizedEmployeeName = request.RecipeName.ToLower();
                    query = query.Where(q => q.RecipeName.ToLower().Contains(normalizedEmployeeName));
                }
            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<RecipeDto>>(list);
        }

        public async Task<RecipeDto> getById(int id)
        {
            var entity = await _context.Recipe.Include(q=>q.MyUser).Include(q=>q.RecipeCategory).FirstOrDefaultAsync(x => x.RecipeId == id);
            return _mapper.Map<RecipeDto>(entity);
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
