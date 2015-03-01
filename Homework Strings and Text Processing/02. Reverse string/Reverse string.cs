using System;
using System.Linq;
/*Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas*/

namespace _02.Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string reversedString = string.Join("", inputString.Reverse());
            Console.WriteLine(reversedString);
        }
    }
}
