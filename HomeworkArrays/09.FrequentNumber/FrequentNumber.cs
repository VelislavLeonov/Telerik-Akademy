using System;
/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
Example:

input	result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)*/

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of the array");
            int n = int.Parse(Console.ReadLine());
            int[] mostFrequentArray = new int[n];
            int counter = 1;
            int maxCounter = 0;
            int mostFrequentElement = mostFrequentArray[0];
            for (int i = 0; i < n; i++)
            {
                mostFrequentArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                counter = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (mostFrequentArray[i] == mostFrequentArray[j])
                    {
                        ++counter;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        mostFrequentElement = mostFrequentArray[i];
                    }
                }
            }
            Console.WriteLine("{0}({1} times)", mostFrequentElement , maxCounter);
        }
    }
}
