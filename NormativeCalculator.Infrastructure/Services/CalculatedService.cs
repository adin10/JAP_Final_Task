using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Core.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public class CalculatedService : ICalculatedService
    {
        private readonly List<(UnitMeasure, UnitMeasure, float)> conversion = new()
        {
            (UnitMeasure.kg, UnitMeasure.g, 1000),
            (UnitMeasure.g, UnitMeasure.kg, 0.001F),
            (UnitMeasure.l, UnitMeasure.ml, 1000),
            (UnitMeasure.ml, UnitMeasure.l, 0.001F)
        };

        public float CalculateIngredientRecipe(IngredientRecipe ingredientRecipe, Ingredient ingredient)
        {
            var ratio = conversion.FirstOrDefault(x => x.Item1 == ingredientRecipe.UnitMeasure && x.Item2 == ingredient.UnitMeasure);

            return ingredientRecipe.Quantity * ratio.Item3 * ingredient.UnitPrice;
        }

        public float CalculateRecipe(RecipeDetailsDto recipe)
        {
            return recipe.IngredientRecipes.Sum(x => x.IngredientCost);
        }
    }
}
