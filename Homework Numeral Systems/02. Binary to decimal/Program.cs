using System;
/*Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.*/

namespace _02.Binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary integer number :");
            string binNumber = Console.ReadLine();
            BinaryToDecimal(binNumber);
        }
        static void BinaryToDecimal(string binNumber)
        {
            long result = 0;
            int power = 1;
            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                int sign = binNumber[i] - 48;
                if (sign == 1)
                {
                    result = result + sign * power;
                }
                power = power * 2;
            }
            Console.WriteLine(result);
        }
    }
}
