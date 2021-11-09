using NormativeCalculator.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
   public interface IIngredientService
    {
        public Task<List<IngredientDto>> get();

        public Task<IngredientDto> getById(int id);
    }
}
