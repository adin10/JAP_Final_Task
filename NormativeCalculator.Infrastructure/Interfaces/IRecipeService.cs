using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Interfaces
{
  public interface IRecipeService
    {
        public Task<List<RecipeDto>> Get(RecipeSearchRequest request);
        public Task<RecipeDto> GetById(int id);
        public Task<RecipeDetailsDto> RecipeDetails(int id);
        public Task<Recipe> Insert(RecipeInsertRequest request);


        // procedures
        public Task<IEnumerable<GetAllRecipesResponse>> GetAllRecipes();

        public Task<IEnumerable<GetRecipesByCategoryNameResponse>> GetRecipesByCategoryName();
    }
}
