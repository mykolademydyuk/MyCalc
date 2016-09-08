using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0.Calc.Versions
{
    class Maximum : IOperation
    {
        public double variable_1 { get; set; }
        public double variable_2 { get; set; }

        private int my_opp_id;
        public int opp_id
        {
            get { return my_opp_id; }
            set { throw new Exception(); }
        }
        
        private float current_status;
        public float status { get { return current_status; } set { } }

        public Maximum()
        {
            my_opp_id = 3;
            current_status = 0;
        }

        public double result
        {
            get
            {
                data_validation();
                return max(variable_1, variable_2);

            }
            set
            {
                result_validation_set();
            }
        }

        private void result_validation_set()
        {
            throw new Exception("FIG VAM!!!");
        }

        private void data_validation()
        {

        }

        private double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

    }
}
