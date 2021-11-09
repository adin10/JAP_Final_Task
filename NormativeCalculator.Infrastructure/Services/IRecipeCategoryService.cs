using NormativeCalculator.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
   public interface IRecipeCategoryService
    {
        public Task<List<RecipeCategoryDto>> get();
        public Task<RecipeCategoryDto> getById(int id);
    }
}
