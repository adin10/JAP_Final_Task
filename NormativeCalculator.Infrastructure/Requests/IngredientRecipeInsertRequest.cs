using NormativeCalculator.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Requests
{
   public class IngredientRecipeInsertRequest
    {
        public int IngredientId { get; set; }
         public float Quantity { get; set; }
        public UnitMeasure UnitMeasure { get; set; }
    }
}
