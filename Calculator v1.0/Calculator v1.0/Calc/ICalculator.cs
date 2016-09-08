using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0.Calc
{
    public interface ICalculator
    {
        double result { get; set; }     // result (OUT parameter)
        double variable_1 { get; set; } //IN-params
        double variable_2 { get; set; } //IN-params
        int opp_ID { get; set; }        //IN-params
    }
}
