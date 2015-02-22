using System;
/*Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.*/

namespace _04.Hexadecimal_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal:");
            string hexNumber = Console.ReadLine();
            HecxadecimalToDecimal(hexNumber);
        }
        static void HecxadecimalToDecimal(string hexNumber)
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
            Console.WriteLine(number);
        }
    }
}
