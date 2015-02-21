using System;
/*Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.*/

namespace _04.Appearance_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght");
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfIntegers = new int[n];
            Console.WriteLine("Please enter the integers");
            for (int i = 0; i < n; i++)
            {
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the number");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(HowManyTimesIntegerAppears(arrayOfIntegers,n,k));
        }
        static int HowManyTimesIntegerAppears(int[] arrayOfIntegers, int n, int k)
        {
            int counter = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (k == arrayOfIntegers[i])
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
