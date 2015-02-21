using System;
/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().*/

namespace _02.Get_largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = GetMax(a, b);
            Console.WriteLine(GetMax(max,c));
        }
        static int GetMax(int a, int b)
        {
            int max = 0;
            if (a>=b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
    }
}
