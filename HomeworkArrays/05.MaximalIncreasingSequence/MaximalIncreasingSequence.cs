using System;
/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:

input	result
3, 2, 3, 4, 2, 2, 4	2, 3, 4*/


namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the leghte of the array");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            int counter = 1;
            int longestSequence = 1;
            int numberOfLongestSequence = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                }
                else
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        ++counter;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > longestSequence)
                    {
                        longestSequence = counter;
                        numberOfLongestSequence = i;
                    }
                }
            }
            for (int i = 0; i < longestSequence; i++)
            {
                if (i == longestSequence - 1)
                {
                    Console.WriteLine("{0}", numbers[numberOfLongestSequence]);
                }
                else
                {
                    Console.Write("{0}, ", numbers[numberOfLongestSequence - longestSequence + i + 1]);
                }
            }
            Console.WriteLine();
        }
    }
}
