using System;
/*Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.*/
namespace _03.Decimal_to_hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer:");
            long number = long.Parse(Console.ReadLine());
            DecimalToHexcadecimal(number);
        }
        static void DecimalToHexcadecimal(long number)
        {
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
