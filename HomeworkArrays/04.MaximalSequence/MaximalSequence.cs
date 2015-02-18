using System;
/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
*/

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the leghte of the array");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            int counter = 1;
            int longestSequence = 1;
            double numberOfLongestSequence = 0;
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
                    if (numbers[i] == numbers[i - 1])
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
                        numberOfLongestSequence = numbers[i];
                    }
                }
            }
            for (int i = 0; i < longestSequence; i++)
            {
                if (i == longestSequence - 1)
                {
                    Console.WriteLine("{0}",numberOfLongestSequence);
                }
                else
                {
                    Console.Write("{0}, ", numberOfLongestSequence);
                }
            }
            Console.WriteLine();
        }
    }
}
