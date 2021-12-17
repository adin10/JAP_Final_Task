using NormativeCalculator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Entities
{
   public class Recipe:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float TotalCost { get; set; }
        public int MyUserId { get; set; }
        public MyUser MyUser { get; set; }
        public int RecipeCategoryId { get; set; }
        public float RecommendedPrice { get; set; }
        public RecipeCategory RecipeCategory { get; set; }
        public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
    }
}
