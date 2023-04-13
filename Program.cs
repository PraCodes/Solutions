using System;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation le = new LinearEquation(2.0,2.0,2.0,2.0,2.0,2.0);

            if(le.isSolvable())

            Console.WriteLine("x is {0} and y is {1}", le.getX(), le.getY());
            else
            {
                Console.WriteLine("The equation has no solution");
            }
        }
        
    }
}
