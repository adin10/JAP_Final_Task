using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
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
        public string Name { get; set; }
        public string Description { get; set; }
        public float TotalCost { get; set; }
    
        public List<IngredientRecipeDto> IngredientRecipes { get; set; }

    }
}
