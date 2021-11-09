using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database
{
   public class Recipe
    {
        public int RecipeId { get; set; }

        public string RecipeName { get; set; }
        public string Description { get; set; }
        public float TotalCost { get; set; }
        public int MyUserId { get; set; }
        public MyUser MyUser { get; set; }
        public int RecipeCategoryId { get; set; }
        public RecipeCategory RecipeCategory { get; set; }
        public ICollection<IngredientRecipe> IngredientRecipe { get; set; }

    }
}
