using NormativeCalculator.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Requests
{
   public class RecipeDetailsDto
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float TotalCost { get; set; }
        public List<IngredientRecipeDto> IngredientRecipes { get; set; }

    }
}
