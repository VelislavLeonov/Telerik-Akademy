using System;
using System.Threading;
using System.Globalization;
/*Problem 4. Number Comparer
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine(("Please enter first number:"));
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is:" + Math.Max(firstNumber,secondNumber));
        }
    }
}
