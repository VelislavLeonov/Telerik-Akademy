using System;
/*Problem 16. Decimal to Hexadecimal Number

Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

namespace DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer:");
            long number = long.Parse(Console.ReadLine());
            string result = null;
            while (number > 0)
            {
                string n = Convert.ToString(number % 16);
                switch (n)
                {
                    case "10": n = "A";
                        break;
                    case "11": n = "B";
                        break;
                    case "12": n = "C";
                        break;
                    case "13": n = "D";
                        break;
                    case "14": n = "E";
                        break;
                    case "15": n = "F";
                        break;
                    default: 
                        break;
                }
                result = Convert.ToString(n) + result;
                number = number / 16;
            }
            Console.WriteLine(result);
        }
    }
}
