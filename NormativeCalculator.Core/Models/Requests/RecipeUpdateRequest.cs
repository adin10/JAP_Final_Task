﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Requests
{
   public class RecipeUpdateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MyUserId { get; set; }
        public int RecipeCategoryId { get; set; }
        public float RecommendedPrice { get; set; }
    }
}
