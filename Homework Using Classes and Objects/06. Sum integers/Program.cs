using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
/*Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input	output
"43 68 9 23 318"	461*/

namespace _06.Sum_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers separated by spaces");
            string integers = Console.ReadLine();
            ArraySum(integers);
        }

        static void ArraySum(string integers)
        {
            int[] arrayOfIntegers = integers.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(arrayOfIntegers.Sum());
        }
    }
}
