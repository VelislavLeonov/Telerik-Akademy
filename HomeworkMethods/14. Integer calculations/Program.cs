using System;
/*Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.*/

namespace _14.Integer_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter integers");
            int[] integers = new int[n];
            for (int i = 0; i < n; i++)
            {
                integers[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Max: {0}", Max(integers,n));
            Console.WriteLine("Min: {0}", Min(integers, n));
            Console.WriteLine("Sum: {0}", Sum(integers, n));
            Console.WriteLine("Product: {0}", Product(integers, n));

        }
        static int Max(int[] integers, int n)
        {
            int max = integers[0];
            for (int i = 0; i < n; i++)
            {
                if (integers[i]>max)
                {
                    max = integers[i];
                }
            }
            return max;
        }
        static int Min(int[] integers, int n)
        {
            int min = integers[0];
            for (int i = 0; i < n; i++)
            {
                if (integers[i] < min)
                {
                    min = integers[i];
                }
            }
            return min;
        }
        static int Sum(int[] integers, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += integers[i];
            }
            return sum;
        }
        static int Product(int[] integers, int n)
        {
            int product = 1;
            for (int i = 0; i < n; i++)
            {
                product *= integers[i];
            }
            return product;
        }
    }
}
