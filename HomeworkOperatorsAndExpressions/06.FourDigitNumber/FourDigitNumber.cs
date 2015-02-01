using System;
/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write four-digit number:");
            int number = int.Parse(Console.ReadLine());
            int a = number % 10;
            int b = (number / 10) % 10;
            int c = (number / 100) % 10;
            int d = (number / 1000) % 10;
            if (d == 0)
            {
                Console.WriteLine("You are entering number starting with 0 or less the four digits number");
            }
            else if (number > 9999)
            {
                Console.WriteLine("You are entering number with more digits");
            }
            else
            { 
            Console.WriteLine("The sum of the digits is:" + (a + b + c + d));
            Console.WriteLine("The reversed number is:" + Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(d));
            Console.WriteLine("The last digit on firts place number is:" + Convert.ToString(a) + Convert.ToString(d) + Convert.ToString(c) + Convert.ToString(b));
            Console.WriteLine("The exchanged second and third place digit number is:" + Convert.ToString(d) + Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(a));
                }
        }
    }
}
