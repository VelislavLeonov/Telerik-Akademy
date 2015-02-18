using System;
/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	S	result
4, 3, 1, 4, 2, 5, 8	11	4, 2, 5*/

namespace _10.FindDSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n ");
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfSequneceSum = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayOfSequneceSum[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter S ");
            int s = int.Parse(Console.ReadLine());
            int sum = 0;
            int startIndex = 0;
            int finalIndex = 0;
            for (int i = 0; i < n; i++)
            {
                sum = arrayOfSequneceSum[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (sum + arrayOfSequneceSum[j] == s)
                    {
                        startIndex = i;
                        finalIndex = j;
                    }
                    else
                    {
                        sum += arrayOfSequneceSum[j];
                    }
                }
            }
            for (int i = startIndex; i <= finalIndex; i++)
            {
                if (i == finalIndex)
                {
                    Console.Write(arrayOfSequneceSum[i]);
                }
                else
                {
                    Console.Write("{0}, ", arrayOfSequneceSum[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
