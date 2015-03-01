using System;
using System.Collections.Generic;
using System.Linq;
/*Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.*/

namespace _08.Extract_sentences
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string[] text = Console.ReadLine().Trim().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Enter target ");
            string target = Console.ReadLine();
            List<string> result = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string[] words = text[i].Trim().Split(new[] { ' ', ',', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Contains(target))
                {
                    result.Add(text[i]);
                    result.Add(".");
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
