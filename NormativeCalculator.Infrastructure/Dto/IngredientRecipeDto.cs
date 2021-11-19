using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Dto
{
    public class IngredientRecipeDto
    {
        //public int IngredientRecipeId{get;set;}
        //public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public float Quantity { get; set; }
        public float IngredientCost { get; set; }
        public float TotalCost { get; set; }
        //public float Price { get; set; }
        public IngredientDto Ingredient { get; set; }  
    }
}
