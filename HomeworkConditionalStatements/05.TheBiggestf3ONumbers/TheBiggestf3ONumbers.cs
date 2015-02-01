using System;
using System.Globalization;
using System.Threading;
/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.*/

namespace TheBiggestf3ONumbers
{
    class TheBiggestf3ONumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            double c = double.Parse(Console.ReadLine());
            double biggest = a;
            if (a < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c;
            }
            Console.WriteLine(biggest);
        }
    }
}
