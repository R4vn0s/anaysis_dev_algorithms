using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task_2
{
    class Exhaustive
    {
        double[] sol = new double[3];

        public double[] searchmin(int function)
        {
            

            
            for ( int i =0; i <= 1000; i++)
            {
                if (i == 0 && function == 3)
                    i = 1;
                double temp= Function.doFunction(i,function);
                if (i == 0 || temp < sol[0])
                {
                    sol[0] = temp;
                    sol[2] = i;
                }                    
                
                sol[1] = i+1;
            }
            return sol;
        }

       

    }
}
