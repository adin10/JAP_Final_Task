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
        [Required]
        public string Name { get; set; }
        //public float UnitPrice { get; set; }
        [Required]
        public UnitMeasure UnitMeasure { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public float UnitQuantity { get; set; }
    }
}
