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
using NormativeCalculator.Core.Models.Validators;

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

        public async Task<PagedList<IngredientDto>> Get(PaginationParams queryParams, IngredientSearchRequest request, int? number)
        {
            var query = _context.Ingredients.AsQueryable();
            if (request != null)
            {
                if (!string.IsNullOrWhiteSpace(request?.Name))
                {
                    var normalizedName = request.Name.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(normalizedName));
                }
                if (request.Quantity.HasValue)
                {
                    query = query.Where(x => x.UnitQuantity == request.Quantity);
                }
                if (request.UnitMeasure.HasValue)
                {
                    query = query.Where(x => x.UnitMeasure == request.UnitMeasure);
                }
            }
            query = queryParams.OrderBy switch
            {
                "name" => query.OrderByDescending(x => x.Name),
                "quantity" => query.OrderByDescending(x => x.UnitQuantity),
                _ => query.OrderBy(x => x.Price)
            };
            return await PagedList<IngredientDto>.CreateAsync(query.ProjectTo<IngredientDto>
                (_mapper.ConfigurationProvider).AsNoTracking(), queryParams.pageNumber, queryParams.PageSize = (int)number);
        }

        public async Task<PagedResponse<IEnumerable<IngredientDto>>> GetPagedIntredients(PagedIngredientRequest request)
        {
            var response = new PagedResponse<IEnumerable<IngredientDto>>();
            List<Ingredient> ingredients;
            var query = _context.Ingredients.OrderBy(x => x.Id).AsQueryable();
            if (request.Search != null)
            {
                if (!string.IsNullOrWhiteSpace(request.Search?.Name))
                {
                    var normalizedName = request.Search.Name.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(normalizedName));
                }
                if (request.Search.Quantity.HasValue)
                {
                    query = query.Where(x => x.UnitQuantity == request.Search.Quantity);
                }
                if (request.Search.UnitMeasure.HasValue)
                {
                    query = query.Where(x => x.UnitMeasure == request.Search.UnitMeasure);
                }
            }

            query = query.Skip((request.Page - 1) * request.PageSize)
                         .Take(request.PageSize);

            SortOrderIngredient(request, ref query);

            ingredients = await query.ToListAsync();
            response.Data = _mapper.Map<List<IngredientDto>>(ingredients);
            response.Count = response.Data.Count();
            response.NextPage = request.Page + 1;
            return response;
        }

        public static void SortOrderIngredient(PagedIngredientRequest request, ref IQueryable<Ingredient> query)
        {
            if (!string.IsNullOrEmpty(request.SortBy))
            {
                if (request.SortOrder == SortOrder.DESC)
                {
                    if (request.SortBy == "name")
                    {
                        query = query.OrderByDescending(x => x.Name);
                    }
                    else if (request.SortBy == "price")
                    {
                        query = query.OrderByDescending(x => x.Price);
                    }
                    else if (request.SortBy == "quantity")
                    {
                        query = query.OrderByDescending(x => x.UnitQuantity);
                    }
                    else if (request.SortBy == "unitPrice")
                    {
                        query = query.OrderByDescending(x => x.UnitPrice);
                    }
                    else if (request.SortBy == "unitMeasure")
                    {
                        query = query.OrderByDescending(x => x.UnitMeasure);
                    }
                }
                else
                {
                    if (request.SortBy == "name")
                    {
                        query = query.OrderBy(x => x.Name);
                    }
                    else if (request.SortBy == "price")
                    {
                        query = query.OrderBy(x => x.Price);
                    }
                    else if (request.SortBy == "quantity")
                    {
                        query = query.OrderBy(x => x.UnitQuantity);
                    }
                    else if (request.SortBy == "unitPrice")
                    {
                        query = query.OrderBy(x => x.UnitPrice);
                    }
                    else if (request.SortBy == "unitMeasure")
                    {
                        query = query.OrderBy(x => x.UnitMeasure);
                    }
                }
            }
        }

        public async Task<IngredientDto> GetById(int id)
        {
            var entity =await _context.Ingredients.FirstOrDefaultAsync(x=>x.Id==id);
            return _mapper.Map<IngredientDto>(entity);
        }
        public async Task<Ingredient> Insert(IngredientRestUpsertRequest request)
        {
            var validation = new IngredientInsertRequestValidator();
            var result = validation.Validate(request);
            if (!result.IsValid)
            {
                throw new ArgumentException("Something went wrong");
            }
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
            entity.UnitPrice = request.Price / request.UnitQuantity;
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

        public async Task<List<IngredientDto>> GetAngularMaterialPagination(IngredientSearchRequest search)
        {
            var query = _context.Ingredients.AsQueryable();
            if (search != null)
            {
                if (!string.IsNullOrWhiteSpace(search.Name))
                {
                    var normalizedName = search.Name.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(normalizedName));
                }
                if (search.Quantity.HasValue)
                {
                    query = query.Where(x => x.UnitQuantity == search.Quantity);
                }
                if (search.UnitMeasure.HasValue)
                {
                    query = query.Where(x => x.UnitMeasure == search.UnitMeasure);
                }
            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<IngredientDto>>(list);
        }
    }
}
