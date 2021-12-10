using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Core.Models.Requests;
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
        public Task<RecipeCategory> Insert(RecipeCategoryUpsertRequest request);
        public Task<RecipeCategory> Delete(int id);
        public Task<RecipeCategory> Update(int id, RecipeCategoryUpsertRequest request);
    }
}
