using System;
using System.Globalization;
using System.Threading;
/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/

namespace _7.Sort_3_Numbers_with_NestedIfs
{
    class Sort3NumbersWithNestedIfs
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
            if (biggest == a)
            {
                if (b < c)
                {
                    Console.WriteLine("{0} {1} {2}", a, c,b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
            }
            if (biggest == b)
            {
                if (a < c)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
            }
            if (biggest == c)
            {
                if (a < b)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
            }
        }
    }
}
