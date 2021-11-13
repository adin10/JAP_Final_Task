using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Infrastructure.Context;
using NormativeCalculator.Infrastructure.Dto;
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
        private readonly MyContext _context;

        public RecipeCategoryService(IMapper mapper, MyContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<RecipeCategoryDto>> get(int number)
        {
            var list = await _context.RecipeCategory.Take(number).OrderByDescending(q=>q.CreatedDate).ToListAsync(); // take koristimo da uzmemo koliko podataka zelimo
            return _mapper.Map<List<RecipeCategoryDto>>(list);
        }

        public async Task<RecipeCategoryDto> getById(int id)
        {
            var entity =await _context.RecipeCategory.FirstOrDefaultAsync(x => x.RecipeCategoryId == id);
            return _mapper.Map<RecipeCategoryDto>(entity);
        }
    }
}
