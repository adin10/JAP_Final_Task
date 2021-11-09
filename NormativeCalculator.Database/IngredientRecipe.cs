using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database
{
   public class IngredientRecipe
    {
        public int IngredientRecipeId { get; set; }
        public int IngredientId { get; set; }
        public Ingredients Ingredient { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

    }
}
