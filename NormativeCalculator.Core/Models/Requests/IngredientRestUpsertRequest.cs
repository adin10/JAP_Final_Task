using NormativeCalculator.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Requests
{
   public class IngredientRestUpsertRequest
    {
        public string Name { get; set; }
        //public float UnitPrice { get; set; }
        public UnitMeasure UnitMeasure { get; set; }
        public float Price { get; set; }
        public float UnitQuantity { get; set; }
    }
}
