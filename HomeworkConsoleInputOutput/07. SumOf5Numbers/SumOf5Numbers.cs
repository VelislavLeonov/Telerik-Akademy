using System;
using System.Threading;
using System.Globalization;
/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter five numbersseparated by space: ");
            string numbers = Console.ReadLine();
            string[] arrayNumbers = numbers.Split(' ');
            double sum = 0;
            double eachNumber = 0;
            foreach (string number in arrayNumbers)
            {
                eachNumber = Double.Parse(number);
                sum += eachNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
