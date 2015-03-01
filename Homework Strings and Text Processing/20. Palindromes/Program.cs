using System;
using System.Collections.Generic;
using System.Linq;
/*Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/

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
            string[] targets = text.Split(punctuation.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string target in targets)
            {
                bool isPalindrome = true;
                for (int i = 0; i < target.Length / 2; i++)
                {
                    if (target[i] == target[target.Length - 1 - i])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome && target.Length > 1)
                {
                    Console.WriteLine(target);
                }
            }
        }
    }
}