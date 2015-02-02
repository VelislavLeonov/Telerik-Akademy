using System;
/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            decimal sum = 1;
            decimal xn = 1;
            decimal fac = 1;
            Console.WriteLine("Please enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter x:");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                xn = xn * x;
                fac = fac * i;
                sum = sum + (fac / xn);
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
