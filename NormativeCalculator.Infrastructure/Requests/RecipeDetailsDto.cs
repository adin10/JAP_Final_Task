using NormativeCalculator.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Requests
{
   public class RecipeDetailsDto
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public string MeasureUnit { get; set; }
        public float UnitPrice { get; set; }
        public float UnitQuantity { get; set; }
        public float IngredientCost { get; set; }
        public float TotalCost { get; set; }
        public List<IngredientRecipe> Ingredients { get; set; }

    }
}
