using System;
using System.Threading;
using System.Globalization;

/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation
 ax2 + bx + c = 0 and solves it (prints its real roots).*/

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("ax2 + bx + c = 0\nPlease enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter c:");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (d == 0)
            {
                Console.WriteLine("X = {0}", (-b)/(2*a));
            }
            else
            {
                Console.WriteLine("X1 = {0}\nX2 = {1}", (-b + Math.Sqrt(d))/(2*a) , (-b - Math.Sqrt(d))/(2*a));
            }
        }
    }
}
