using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Entities
{
   public class Ingredient:BaseEntity
    {
        public string Name { get; set; } 
        public float UnitPrice { get; set; }
        public UnitMeasure UnitMeasure { get; set; }  
        public float Price { get; set; }    
        public float UnitQuantity { get; set; }  
        public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
    }
}
