using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Function
    {
        public static double doFunction(double x, int function)
        {
            double solution =0;
            switch(function)
            {
                case 1:
                    solution = Math.Pow(x , 3);
                    break;
                case 2:
                    solution = Math.Abs(x - 0.2);
                    break;
                case 3:
                    solution = (x) *( Math.Sin(1 / x));
                    break;
            }
            return solution;
        
        }
    }
}
