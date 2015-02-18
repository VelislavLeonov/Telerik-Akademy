using System;
/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/

namespace _06.MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter lenght of array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter max sum of how much elements");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = n-k -1; i < n; i++)
            {
                if (i == n-1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write("{0}, ",array[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
