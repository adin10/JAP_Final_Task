using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Requests
{
   public class RecipeSearchRequest
    {
        public string SearchTerm { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string IngredientName { get; set; }
        public int? categoryId { get; set; }
    }
}
