using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Interfaces
{
   public interface IIngredientService
    {
        public Task<List<IngredientDto>> Get();

        public Task<IngredientDto> GetById(int id);

        public Task<IEnumerable<GetTop10UsedIngredientsResponse>> GetTop10UsedIngredients(UnitMeasure MeasureUnit, int MinQuantity, int MaxQuantity);

      
    }
}
