using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public class CalculatedService : ICalculatedService
    {
        public float CalculateRecipe(RecipeDetailsDto recipe)
        {
            float sum = 0;
            foreach (var x in recipe.IngredientRecipes)
            {
                var ingredientRecipeQuantity = x.Quantity;
                var ingredientUnitPrice = x.Ingredient.Price;
                var ingredientUnitQuantity = x.Ingredient.UnitQuantity;
                x.IngredientCost = (ingredientRecipeQuantity * ingredientUnitPrice) / ingredientUnitQuantity;
                sum = sum + x.IngredientCost;
            }
            return sum;
        }
    }
}
