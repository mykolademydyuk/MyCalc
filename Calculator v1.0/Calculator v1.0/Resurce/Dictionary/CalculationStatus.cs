using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0.Resurce.Dictionary
{
    static class CalculationStatus
    {
        public static Dictionary<float, string> Dictionary = new Dictionary<float, string>()
        {
            { 0, "begin" },
            { 1, "half" },
            { 2, "end" }
        };
    }
}
