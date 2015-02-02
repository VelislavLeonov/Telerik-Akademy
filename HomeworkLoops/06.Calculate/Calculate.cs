using System;
using System.Numerics;
/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
*/

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter k");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = k + 1 ; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
