using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt=10;
            int function = 1;
           
            double[] sol = new double[3];
            while (opt != 0)
            {
                Console.WriteLine("Select the option");
                
                Console.WriteLine("1. Exhaustive Search");
                Console.WriteLine("2. Dichotomy Search");
                Console.WriteLine("3. Golden Section");
                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("1. For f(x)=x^3");
                Console.WriteLine("2. For f(x)=|x-0.2|");
                Console.WriteLine("3. For f(x)=xsin(1/x)");
                function= int.Parse(Console.ReadLine());
                Console.WriteLine("Insert Bottom Limit");
                double min = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert Upper Limit");
                double max = double.Parse(Console.ReadLine());

                switch (opt) 
                {
                    case 1:
                        Exhaustive exhaustive = new Exhaustive();
                        sol = exhaustive.searchmin(function);
                        break;
                    case 2:
                        Dichotomy dichotomy = new Dichotomy();
                        sol = dichotomy.searchmin(function,min,max);
                        break;
                    case 3:
                        Gold gold = new Gold();
                        sol = gold.searchmin(function, min, max);
                        break;
                }               
                Console.WriteLine(string.Format("The minimun is {0} ", sol[0]));
                Console.WriteLine(string.Format("The number of iterations is {0} ", sol[1]));
                Console.WriteLine(string.Format("The value of x is {0} ", sol[2]));
            }
           

        }
    }
}
