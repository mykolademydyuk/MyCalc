using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0.Calc.Versions
{
    public interface IOperation
    {
        double variable_1 { get; set; } //IN-params
        double variable_2 { get; set; } //IN-params
        int opp_id { get; set; }        //IN-params
        double result { get; set; }     // result (OUT parameter)
        float status { get; }     //status(OUT parameter)
    }
}
