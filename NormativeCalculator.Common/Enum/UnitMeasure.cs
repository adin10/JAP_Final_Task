using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NormativeCalculator.Common.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnitMeasure
    {
        kg=1,
        g=2,
        ml=3,
        l=4,
        kom=5
    }
}
