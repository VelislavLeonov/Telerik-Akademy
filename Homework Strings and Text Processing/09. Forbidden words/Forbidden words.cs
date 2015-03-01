using System;
/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0
and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. 
It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/

namespace _09.Forbidden_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a list of forbidden words, separated by space");
            string[] forbiddenWords = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
            Console.WriteLine();
            Console.WriteLine(text);
        }
    }
}
