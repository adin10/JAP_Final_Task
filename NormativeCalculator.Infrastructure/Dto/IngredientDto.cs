﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Dto
{
   public class IngredientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitMeasure { get; set; }
        public float UnitPrice { get; set; }
        public float UnitQuantity { get; set; }
        //public ICollection<IngredientRecipe> IngredientRecipe { get; set; }
    }
}
