using System;
/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
 find the smallest from the rest, move it at the second position, etc.*/

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of the array");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            for (int i = 0; i < n -1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j]<array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (i == n -1)
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
