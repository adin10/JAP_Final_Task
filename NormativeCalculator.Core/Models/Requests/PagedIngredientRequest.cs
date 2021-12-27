using NormativeCalculator.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Requests
{
   public class PagedIngredientRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public IngredientSearchRequest Search { get;set; }
        public string SortBy { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}
