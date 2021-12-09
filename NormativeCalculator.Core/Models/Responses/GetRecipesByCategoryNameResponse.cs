using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Responses
{
   public class GetRecipesByCategoryNameResponse
    {
        public string CategoryName { get; set; }
        public string RecipeName { get; set; }
        public double TotalCost { get; set; }

    }
}
