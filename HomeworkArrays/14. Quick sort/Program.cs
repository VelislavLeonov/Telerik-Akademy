using System;
/*Problem 14. Quick sort

Write a program that sorts an array of integers using the Quick sort algorithm.*/

namespace _14.Quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            int[] arrayBeforeSort = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayBeforeSort[i] = int.Parse(Console.ReadLine()); 
            }
            Quicksort(arrayBeforeSort, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                if (i == n-1)
                {
                    Console.Write(arrayBeforeSort[i]);
                }
                else
                {
                    Console.Write("{0}, ", arrayBeforeSort[i]);
                }
            }
            Console.WriteLine();
        }
        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                Quicksort(elements, left, j);
            }
            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
