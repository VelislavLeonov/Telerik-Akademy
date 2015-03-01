using System;
using System.Collections.Generic;
using System.Linq;
/*Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            List<char> punctuation = new List<char>();
            for (int i = 0; i < 128; i++)
            {
                if (char.IsPunctuation((char)i))
                {
                    punctuation.Add((char)i);
                }
            }
            punctuation.Add((char)32);
            string[] words = text.Split(punctuation.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }
            foreach (var word in dictionary.OrderBy(key => key.Value))
            {
                Console.WriteLine("{0} - {1} times", word.Key, word.Value);
            }
        }
    }
}
