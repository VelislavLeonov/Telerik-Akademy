using System;
/*Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements
 (the number of characters composing them).*/

namespace _05.Sort_by_string_length
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }
            Array.Sort(strings, (x, y) => x.Length.CompareTo(y.Length));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }
}
