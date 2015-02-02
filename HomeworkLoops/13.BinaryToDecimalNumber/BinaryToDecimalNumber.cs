using System;

/*Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

namespace BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary integer number :");
            string binNumber = Console.ReadLine();
            long result = 0;
            int power = 1;
            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                int sign = binNumber[i] - 48;
                if (sign == 1)
                {
                    result = result + sign * power;
                }
                power = power*2;
            }
            Console.WriteLine(result);
        }
    }
}
