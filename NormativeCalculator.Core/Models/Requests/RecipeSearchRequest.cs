using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Requests
{
   public class RecipeSearchRequest
    {
        public string SearchTerm { get; set; }
        public int? categoryId { get; set; }
        public int number { get; set; }
     
    }
}
