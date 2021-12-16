using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Dto
{
   public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float TotalCost { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MyUserId { get; set; }
        public float RecommendedPrice { get; set; }
        public MyUserDto MyUser { get; set; }
        public int RecipeCategoryId { get; set; }
        public RecipeCategoryDto RecipeCategory { get; set; }
        //public ICollection<IngredientRecipe> IngredientRecipe { get; set; }
    }
}
