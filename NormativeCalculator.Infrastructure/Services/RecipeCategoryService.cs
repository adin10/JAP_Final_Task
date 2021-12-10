using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Requests;

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

        public async Task<RecipeCategory> Insert(RecipeCategoryUpsertRequest request)
        {
            var entity = _mapper.Map<RecipeCategory>(request);
            entity.CreatedDate = DateTime.Now;
            await _context.RecipeCategories.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<RecipeCategory> Delete(int id)
        {
            var entity = await _context.RecipeCategories.FindAsync(id);
            _context.RecipeCategories.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<RecipeCategory> Update(int id, RecipeCategoryUpsertRequest request)
        {
            var entity = await _context.RecipeCategories.FindAsync(id);
            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
