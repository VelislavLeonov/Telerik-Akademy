using System;
/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfElement = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayOfElement[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arrayOfElement);
            Console.WriteLine("Please enter S");
            int s = int.Parse(Console.ReadLine());
            int check = BinarySearchAlg(arrayOfElement, s, 0, n - 1);
            if (check == -1)
            {
                Console.WriteLine("No found element");
            }
            else
            {
                Console.WriteLine("The number index is {0}", check);
            }
        }
        private static int BinarySearchAlg(int[] array, int value, int lowBound, int highBound)
        {
            int mid;
            while (lowBound <= highBound)
            {
                mid = (lowBound + highBound) / 2;
                if (array[mid] < value)
                {
                    lowBound = mid + 1;
                    continue;
                }
                else if (array[mid] > value)
                {
                    highBound = mid - 1;
                    continue;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
