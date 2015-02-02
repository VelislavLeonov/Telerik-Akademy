using System;
/*Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

namespace HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal:");
            string hexNumber = Console.ReadLine();
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
