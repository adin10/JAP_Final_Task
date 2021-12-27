using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NormativeCalculator.Common.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
   public enum SortOrder
    {
        DESC,
        ASC,
        NONE
    }
}
