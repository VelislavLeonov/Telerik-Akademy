using System;
/*Problem 17.* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).*/

namespace CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(GCD(a, b));
        }
        static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }
    }
}
