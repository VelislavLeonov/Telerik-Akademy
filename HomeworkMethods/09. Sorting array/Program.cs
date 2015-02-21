using System;
/*Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.*/
namespace _09.Sorting_array
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 2, 7, 54, 47,16, 33, 17, 5, 6 };
            int startElement = 0;
            int portionLength = 2;
            int maxElement = MaxElement(arr, startElement, portionLength);
            Console.WriteLine(maxElement);
            Sort(arr);
            PrintArray(arr);
        }
        static void Exchange(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int MaxElement(int[] array, int start, int length)
        {
            int maxElement = int.MinValue;
            int maxIndex = 0;
            maxElement = array[start];
            for (int i = start; i <= length; i++)
            {
                if (array[i] >= maxElement)
                {
                    maxElement = array[i];
                    maxIndex = i;
                }
            }
            Exchange(maxIndex, start);
            return maxElement;
        }

        static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
