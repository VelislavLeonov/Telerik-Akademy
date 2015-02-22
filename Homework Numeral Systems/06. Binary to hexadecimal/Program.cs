using System;
/*Problem 6. Binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).*/

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary integer number :");
            string binNumber = Console.ReadLine();
            BinaryToHexadecimal(binNumber);
        }
        static void BinaryToHexadecimal(string binNumber)
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
            string resultHex = null;
            while (result > 0)
            {
                string n = Convert.ToString(result % 16);
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
                resultHex = Convert.ToString(n) + resultHex;
                result = result / 16;
            }
            Console.WriteLine(result);
        }
    }
}
