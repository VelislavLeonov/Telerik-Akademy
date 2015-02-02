using System;
/*Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

namespace DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer:");
            int number = int.Parse(Console.ReadLine());
            string result = null;
            while (number > 0)
            {
                int n = number % 2;
                result =Convert.ToString(n) + result ;
                number = number / 2;
            }
            Console.WriteLine(result);
        }
    }
}
