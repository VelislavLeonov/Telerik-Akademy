using System;
using System.Globalization;
using System.Threading;
/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than
the second one. 
As a result print the values a and b, separated by a space.*/

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b:");
            double b = double.Parse(Console.ReadLine());
            double c = 0;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
