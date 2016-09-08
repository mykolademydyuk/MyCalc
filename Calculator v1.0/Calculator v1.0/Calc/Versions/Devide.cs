using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0.Calc.Versions
{
    class Devide : IOperation
    {
        private readonly int my_opp_id;
        private float current_status;

        public Devide()
        {
            my_opp_id = 2;
            current_status = 0;
        }

        public double result
        {
            get
            {
                data_validation();
                return devide(variable_1, variable_2);

            }
            set
            {
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

        public float status { get { return current_status; } set { } }

        private void result_validation_set()
        {
            throw new Exception("FIG VAM!!!");
        }

        private void data_validation()
        {
            if (Double.IsNaN(variable_1))
            {
                Console.WriteLine("Warning!.Variable 1 was emty.By default it was taken zero");
                variable_1 = 0;
            }

            if (Double.IsNaN(variable_2) || variable_2 == 0)
            {
                Console.WriteLine("Warning!.Variable 2 was emty or zero.By default it was taken one");
                variable_2 = 1;
            }
        }

        private double devide(double a, double b)
        {
            current_status = 1;

            return a / b;
        }

    }
}

    
