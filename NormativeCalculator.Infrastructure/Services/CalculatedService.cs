using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Core.Models.Requests;
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
            // iz kg            u g         rez
            (UnitMeasure.kg, UnitMeasure.g, 1000),

            (UnitMeasure.kg,UnitMeasure.kg,1),
            (UnitMeasure.g, UnitMeasure.kg, 0.001F),
            (UnitMeasure.g,UnitMeasure.g,1),
            (UnitMeasure.l, UnitMeasure.ml, 1000),
            (UnitMeasure.ml, UnitMeasure.l, 0.001F),
            (UnitMeasure.kom,UnitMeasure.kom,1)
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
