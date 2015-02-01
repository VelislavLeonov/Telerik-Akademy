using System;
using System.Threading;
using System.Globalization;
/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and 
calculates and prints their sum. Note: You may need to use a for-loop.*/

namespace SumOFNNumbers
{
    class SumOFNNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter how many nubers you want to sum:");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double number = 0;
            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine("Please enter number:");
                number = double.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
