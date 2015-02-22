using System;
/*Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).*/

namespace _05.Hexadecimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal:");
            string hexNumber = Console.ReadLine();
            HecxadecimalToBynary(hexNumber);
        }
        static void HecxadecimalToBynary(string hexNumber)
        {
            long number = 0;
            long power = 1;
            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                int symbol;
                switch (hexNumber[i])
                {
                    case 'A': symbol = 10;
                        break;
                    case 'B': symbol = 11;
                        break;
                    case 'C': symbol = 12;
                        break;
                    case 'D': symbol = 13;
                        break;
                    case 'E': symbol = 14;
                        break;
                    case 'F': symbol = 15;
                        break;
                    default: symbol = hexNumber[i] - 48;
                        break;
                }
                number = number + symbol * power;
                power = power * 16;
            }
            string result = null;
            while (number > 0)
            {
                long n = number % 2;
                result = Convert.ToString(n) + result;
                number = number / 2;
            }
            Console.WriteLine(result);
        }
    }
}
