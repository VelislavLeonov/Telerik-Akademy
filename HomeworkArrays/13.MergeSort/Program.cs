using System;
/*Problem 13.* Merge sort

Write a program that sorts an array of integers using the Merge sort algorithm.*/
namespace _13.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter N");
            int n = int.Parse(Console.ReadLine());
            int[] arrayBeforeSort = new int[n];
            int[] temporary = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayBeforeSort[i] = int.Parse(Console.ReadLine());
            }
            Merge(arrayBeforeSort, temporary, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                if (i == n-1)
                {
                    Console.Write(arrayBeforeSort[i]);
                }
                else
                {
                    Console.Write("{0}, ",arrayBeforeSort[i]);
                }
            }
            Console.WriteLine();
        }
        static void Merge(int[] arrayBeforeSort, int[] temporary, int first, int last)
        {
            if (first >= last)
            {
                return;
            }
            int middle = first + (last - first) / 2;
            Merge(arrayBeforeSort, temporary, first, middle);
            Merge(arrayBeforeSort, temporary, middle + 1, last);
            Sort(arrayBeforeSort, temporary, first, middle, last);
        }

        static void Sort(int[] elements, int[] temporary, int first, int middle, int last)
        {
            int i = first;
            int j = first, m = middle + 1;

            while (j <= middle && m <= last)
            {
                temporary[i++] = (elements[j] > elements[m]) ? elements[m++] : elements[j++];
            }
            while (j <= middle)
            {
                temporary[i++] = elements[j++];
            }
            while (m <= last)
            {
                temporary[i++] = elements[m++];
            }
            for (int k = first; k <= last; k++)
            {
                elements[k] = temporary[k];
            }
        }
    }
}
