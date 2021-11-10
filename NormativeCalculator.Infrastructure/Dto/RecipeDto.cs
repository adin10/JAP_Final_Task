using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Dto
{
   public class RecipeDto
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public float TotalCost { get; set; }
        public int MyUserId { get; set; }
        public MyUserDto MyUser { get; set; }
        public int RecipeCategoryId { get; set; }
        public RecipeCategoryDto RecipeCategory { get; set; }
        //public ICollection<IngredientRecipe> IngredientRecipe { get; set; }
    }
}
