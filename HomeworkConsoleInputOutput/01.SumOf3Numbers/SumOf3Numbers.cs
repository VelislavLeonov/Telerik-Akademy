using System;
using System.Threading;
using System.Globalization;
/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.*/

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter first number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            double b = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Please enter third number");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum is:" + (a+b+c));
        }
    }
}
