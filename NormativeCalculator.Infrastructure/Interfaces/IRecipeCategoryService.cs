using NormativeCalculator.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Interfaces
{
   public interface IRecipeCategoryService
    {
        public Task<List<RecipeCategoryDto>> Get(int number);
        public Task<RecipeCategoryDto> GetById(int id);
    }
}
