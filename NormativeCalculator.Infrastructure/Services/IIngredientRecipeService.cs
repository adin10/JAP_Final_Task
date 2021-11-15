using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
   public interface IIngredientRecipeService
    {
        public Task<List<RecipeDetailsDto>> getIngredientRecipes(int recipeId);
    }
}
