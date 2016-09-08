using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0.Calc.Versions
{
    public class Plus : IOperation
    {
        private readonly int my_opp_id;
        private float current_status;

        public Plus()
        {
            my_opp_id = 1; //version number
            current_status = 0; //begin
        }

        public double result
        {
            get
            {
                //if (variable_1 != null && variable_2 != null)
                //    return variable_1 + variable_2;
                //throw new Exception("variable is empty");

                data_validation();
                return add(variable_1, variable_2);
            }
            set
            {
                /*throw new Exception("FIG VAM!!!");*/

                result_validation_set();
            }
        }

        public double variable_1 { get; set; }
        public double variable_2 { get; set; }

        public int opp_id
        {
            get { return my_opp_id; }
            set { throw new Exception(); }
        }

        public float status { get; }

        private void data_validation()
        {
            if (Double.IsNaN(variable_1))
            {
                Console.WriteLine("Warning!. Variable 1 was emty. By default it was taken zero");
                variable_1 = 0;
            }
            if (Double.IsNaN(variable_2))
            {
                Console.WriteLine("Warning!. Variable 2 was emty. By default it was taken zero");
                variable_2 = 0;
            }
        }

        private void result_validation_set()
        {
            throw new Exception("FIG VAM!!!");
        }

        private double add(double a, double b)
        {
            current_status = 1; //end
            return a + b;
        }

    }

}
