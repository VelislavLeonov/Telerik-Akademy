using System;
using System.Globalization;
using System.Threading;
/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter side a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter height h:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid's area is:" + (((a+b)/2)*h));
        }
    }
}
