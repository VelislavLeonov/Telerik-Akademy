using System;
using System.Globalization;
using System.Threading;
/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

namespace MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    max = number;
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
                sum = sum + number;

            }
            Console.WriteLine("Min = {0}\nMax = {1}\nSum = {2}\nAvg = {3:0.00}",min,max,sum,sum/n);
        }
    }
}
