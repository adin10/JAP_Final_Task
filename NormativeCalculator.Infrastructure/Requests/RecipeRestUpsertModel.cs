using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Requests
{
   public class RecipeRestUpsertModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public float TotalCost { get; set; }
        public int RecipeCategoryId { get; set; }
        public List<IngredientRecipeInsertRequest> Ingredients { get; set; }
    }
}
