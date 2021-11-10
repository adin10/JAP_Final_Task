using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
  public interface IRecipeService
    {
        public Task<List<RecipeDto>> get(RecipeSearchRequest request);
        public Task<RecipeDto> getById(int id);
        public Task<Recipe> Insert(RecipeInsertRequest request);
    }
}
