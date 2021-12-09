using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Responses
{
   public class GetAllRecipesResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float TotalCost { get; set; }
        public int ukupno { get; set; }
    }
}
