using System;
/*Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            for (int i = 0; i < n; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sequence);
            if (k < sequence[0])
            {
                Console.WriteLine("There isn't max vaule");
            }
            else
            {
                while (Array.BinarySearch(sequence, k) < 0)
                {
                    --k;
                }
                Console.WriteLine(k);
            }
        }
    }
}
