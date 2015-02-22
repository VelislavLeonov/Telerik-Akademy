using System;
/*Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.*/

namespace _01.Decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer:");
            int number = int.Parse(Console.ReadLine());
            DecimalToBinary(number);
        }
        static void DecimalToBinary(int number)
        {
            string result = null;
            while (number > 0)
            {
                int n = number % 2;
                result = Convert.ToString(n) + result;
                number = number / 2;
            }
            Console.WriteLine(result);
        }
    }
}
