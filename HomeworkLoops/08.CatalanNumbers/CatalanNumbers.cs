using System;
using System.Numerics;
/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).*/

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n:");
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= 2*n; i++)
            {
                result = result * i;
            }
            for (int j = 1; j <= n; j++)
            {
                result = result / (j * (j + 1));
            }
            Console.WriteLine(result);
        }
    }
}
