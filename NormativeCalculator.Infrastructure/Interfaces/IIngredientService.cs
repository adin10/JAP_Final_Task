using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Models.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormativeCalculator.Common.Helper;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Requests;

namespace NormativeCalculator.Infrastructure.Interfaces
{
   public interface IIngredientService
    {
        public Task<PagedList<IngredientDto>> Get(PaginationParams paginationParams, IngredientSearchRequest request,int? number);

        public Task<IngredientDto> GetById(int id);
        public Task<Ingredient> Insert(IngredientRestUpsertRequest request);
        public Task<Ingredient> Update(int id, IngredientRestUpsertRequest request);
        public Task<Ingredient> Delete(int id);

        public Task<IEnumerable<GetTop10UsedIngredientsResponse>> GetTop10UsedIngredients(UnitMeasure MeasureUnit, int MinQuantity, int MaxQuantity);

      
    }
}
