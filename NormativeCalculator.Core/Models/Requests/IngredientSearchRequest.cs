using NormativeCalculator.Common.Enum;
using NormativeCalculator.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Requests
{
    //:PaginationParams
   public class IngredientSearchRequest
    {
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public UnitMeasure? UnitMeasure { get; set; }
    }
}
