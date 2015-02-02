using System;
using System.Numerics;
/*Problem 18.* Trailing Zeroes in N!

Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.*/

namespace TrailingZeroesInN
{
    class TrailingZeroesInN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            int counter = 0;
            while (result%10 == 0)
            {
                counter = counter + 1;
                result = result / 10;
            }
            Console.WriteLine(counter);
        }
    }
}
