using System;
/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.*/

namespace _OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input integer number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number " + number + " is even");   
            }
            else
            {
                Console.WriteLine("The number " + number + " is odd");
            }
        }
    }
}
