using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public class RecipeCategoryService : IRecipeCategoryService
    {
        private readonly IMapper _mapper;
        private readonly NCDbContext _context;

        public RecipeCategoryService(IMapper mapper, NCDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<RecipeCategoryDto>> Get(int number)
        {
            var list = await _context.RecipeCategories.Take(number).OrderByDescending(q=>q.CreatedDate).ToListAsync(); // take koristimo da uzmemo koliko podataka zelimo
            return _mapper.Map<List<RecipeCategoryDto>>(list);
        }
        public async Task<RecipeCategoryDto> GetById(int id)
        {
            var entity =await _context.RecipeCategories.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<RecipeCategoryDto>(entity);
        }
    }
}
