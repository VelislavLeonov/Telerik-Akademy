using System;
/*Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours
 * , or -1, if there’s no such element.
Use the method from the previous exercise.*/

namespace _06.First_larger_than_neighbours
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
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (CheckIfLarger(arrayOfIntegers, i, n))
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);
        }
        static bool CheckIfLarger(int[] arrayOfIntegers, int k, int n)
        {
            bool larger = false;
            if (k == 0)
            {
                if (arrayOfIntegers[k] > arrayOfIntegers[k + 1])
                {
                    larger = true;
                }
                else
                {
                    larger = false;
                }
            }
            else if (k == n -1 )
            {
                if (arrayOfIntegers[k] > arrayOfIntegers[k - 1])
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
                if (arrayOfIntegers[k] > arrayOfIntegers[k - 1] && arrayOfIntegers[k] > arrayOfIntegers[k + 1])
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
