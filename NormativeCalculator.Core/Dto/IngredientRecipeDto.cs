using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Dto
{
    public class IngredientRecipeDto
    {
        public int IngredientId { get; set; }
        public float Quantity { get; set; }
        public float IngredientCost { get; set; }
        public IngredientDto Ingredient { get; set; }  
    }
}
