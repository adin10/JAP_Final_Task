using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Models.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormativeCalculator.Common.Helper;
using AutoMapper.QueryableExtensions;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Requests;

namespace NormativeCalculator.Infrastructure.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IMapper _mapper;
        private readonly NCDbContext _context;
        private readonly DbConnection _dbConection;
        public IngredientService(NCDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _dbConection = context.Database.GetDbConnection();
        }
        public async Task<PagedList<IngredientDto>> Get(PaginationParams paginationParams)
        {
            //var list =await _context.Ingredients.ToListAsync();
            //return _mapper.Map<List<IngredientDto>>(list);

            var query = _context.Ingredients.ProjectTo<IngredientDto>(_mapper.ConfigurationProvider).AsNoTracking();
            return await PagedList<IngredientDto>.CreateAsync(query, paginationParams.pageNumber, paginationParams.PageSize);
        }

        public async Task<IngredientDto> GetById(int id)
        {
            var entity =await _context.Ingredients.FirstOrDefaultAsync(x=>x.Id==id);
            return _mapper.Map<IngredientDto>(entity);
        }

        public async Task<Ingredient> Insert(IngredientRestUpsertRequest request)
        {
            var entity = _mapper.Map<Ingredient>(request);
            entity.CreatedDate = DateTime.Now;
            entity.UnitPrice = request.Price / request.UnitQuantity;
            await _context.Ingredients.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Ingredient> Update(int id, IngredientRestUpsertRequest request)
        {
            var entity = await _context.Ingredients.FirstOrDefaultAsync(x => x.Id == id);
            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Ingredient> Delete(int id)
        {
            var entity = await _context.Ingredients.FindAsync(id);
            _context.Ingredients.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public Task<IEnumerable<GetTop10UsedIngredientsResponse>> GetTop10UsedIngredients(UnitMeasure MeasureUnit, int MinQuantity, int MaxQuantity)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@MeasureUnit", MeasureUnit);
            parameters.Add("@MinQuantity", MinQuantity);
            parameters.Add("@MaxQuantity", MaxQuantity);

            return _dbConection.QueryAsync<GetTop10UsedIngredientsResponse>
                ("GetTop10UsedIngredients", parameters, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
