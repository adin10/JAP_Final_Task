using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Dto
{
   public class IngredientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float UnitPrice { get; set; }
        public string UnitMeasure { get; set; }
        public float Price { get; set; }
        public float UnitQuantity { get; set; }
        //public ICollection<IngredientRecipe> IngredientRecipe { get; set; }
    }
}
