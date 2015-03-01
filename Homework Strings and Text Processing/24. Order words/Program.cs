using System;
/*Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            Array.Sort(words);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}