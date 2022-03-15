using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Gold
    {
        public double[] searchmin(int function, double min, double max)
        {
            double x1 =0 , x2= 0, fx1, fx2;
            double[] solution = new double[3];
            solution[1] = 0;
            int flag = 0;

            while (Math.Abs(min - max) > 0.001)
            {
                if (flag == 0 || flag == 1)
                {
                    x1 = (min +
                            (
                                (
                                    3 - Math.Sqrt(5)
                                )
                                / 2
                             )
                           * (max - min)
                           );
                }
                if (flag == 0 || flag == 2)
                {
                    x2 = (max +
                            (
                                (
                                    Math.Sqrt(5) - 3
                                )
                                / 2
                            )
                           * (max - min)
                           );
                }
                fx1 = Function.doFunction(x1, function);
                fx2 = Function.doFunction(x2, function);
                if (fx1 <= fx2)
                {
                    max = x2;
                    x2 = x1;
                    flag = 1;
                }
                else
                {
                    min = x1;
                    x1 = x2;
                }
                solution[0] = x1;
                solution[1]++;
                solution[2] = fx1;

            }
            return solution;

        }
    }
}
