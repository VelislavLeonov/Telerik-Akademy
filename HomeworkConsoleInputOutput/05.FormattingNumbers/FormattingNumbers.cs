using System;
using System.Threading;
using System.Globalization;

/*Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter integer number between 0 and 500:");
            int a = int.Parse(Console.ReadLine());
            if (a < 0 | a > 500)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine("please enter second number");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("please enter third number");
                float c = float.Parse(Console.ReadLine());
                Console.WriteLine("{0,-10} | {1} | {2:0.00} | {3:0.000} |", a.ToString("X"), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
            }
        }
    }
}
