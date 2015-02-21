using System;
/*Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers 
 * is larger than its two neighbours (when such exist).*/

namespace _05.Larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfIntegers = new int[n];
            Console.WriteLine("Please enter integers");
            for (int i = 0; i < n; i++)
            {
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter k");
            int k = int.Parse(Console.ReadLine());
            bool larger = CheckIfLarger(arrayOfIntegers, k, n);
            if (larger)
            {
                Console.WriteLine("The element is larger");
            }
            else
            {
                Console.WriteLine("The element isn't larger");
            }
        }
        static bool CheckIfLarger(int[] arrayOfIntegers, int k, int n)
        {
            bool larger = false;
            if (k == 0)
            {
                if (arrayOfIntegers[k] > arrayOfIntegers[k+1] )
                {
                    larger = true;
                }
                else
                {
                    larger = false;
                }
            }
            else if (k == n - 1)
            {
                if (arrayOfIntegers[k]>arrayOfIntegers[k-1])
                {
                    larger = true;
                }
                else
                {
                    larger = false;
                }
            }
            else
            {
                if (arrayOfIntegers[k]>arrayOfIntegers[k-1] && arrayOfIntegers[k]>arrayOfIntegers[k+1])
                {
                    larger = true;
                }
                else
                {
                    larger = false;
                }
            }
            return larger;
        }
    }
}
