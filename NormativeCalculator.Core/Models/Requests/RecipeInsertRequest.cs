using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Requests
{
   public class RecipeInsertRequest
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MyUserId { get; set; }
        public int RecipeCategoryId { get; set; }
        public float RecommendedPrice { get; set; }
        public List<IngredientRecipeInsertRequest> Ingredients { get; set; }
    }
}
