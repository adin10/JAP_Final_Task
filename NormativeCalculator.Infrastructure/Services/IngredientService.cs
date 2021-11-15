using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Context;
using NormativeCalculator.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _context;
        public IngredientService(MyContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<IngredientDto>> get()
        {
            var list =await _context.Ingredients.ToListAsync();
            return _mapper.Map<List<IngredientDto>>(list);
        }

        public async Task<IngredientDto> getById(int id)
        {
            var entity =await _context.Ingredients.FirstOrDefaultAsync(x=>x.IngredientsId==id);
            return _mapper.Map<IngredientDto>(entity);
        }

    }
}
