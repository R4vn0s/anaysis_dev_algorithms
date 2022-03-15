using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Dichotomy
    {
        public double[] searchmin(int function, double min, double max)
        {
            double x1, x2, fx1, fx2;
            double[] solution = new double[3];
            solution[1] = 0;

            while ( max-min > 0.001)
            {
                x1 = (min + max - 0.0001) / 2;
                x2 = (min + max + 0.0001) / 2;
                fx1= Function.doFunction(x1, function);
                fx2 = Function.doFunction(x2, function);
                if (fx1 <= fx2)
                {
                    max = x2;
                }
                else
                {
                    min = x1;
                }
                solution[0] = x1;
                solution[1]++;
                solution[2] = fx1;

            }
            return solution;           

        }
    }
}
