using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Requests
{
   public class RecipeCategoryUpsertRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
