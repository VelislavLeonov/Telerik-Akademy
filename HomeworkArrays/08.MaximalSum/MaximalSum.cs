using System;
/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
Example:

input	result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
Can you do it with only one loop (with single scan through the elements of the array)?*/

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of the array");
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfBestSum = new int[n];
            for (int i = 0; i < n; i++)
			{
                arrayOfBestSum[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = arrayOfBestSum[0];
            int maxSum = arrayOfBestSum[0];
            int firstElement = 0;
            int lastElement = 0;
            for (int i = 0; i < n; i++)
            {
                if (currentSum <= 0)
                {
                    firstElement = i;
                    currentSum = 0;
                }
                currentSum = currentSum + arrayOfBestSum[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    lastElement = i;
                }
            }
            for (int i = firstElement; i <= lastElement; i++)
            {
                if (i == lastElement)
                {
                    Console.Write(arrayOfBestSum[i]);
                }
                else
                {
                    Console.Write("{0}, ", arrayOfBestSum[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
