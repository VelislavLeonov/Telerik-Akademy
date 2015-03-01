using System;
using System.Collections.Generic;
/*Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input   output
.NET   platform for applications from Microsoft
CLR   managed execution environment for .NET
namespace   hierarchical organization of classes*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter text");
            bool check = false;
            string text = Console.ReadLine();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");
            foreach (var item in dictionary)
            {
                if (item.Key == text)
                {
                    Console.WriteLine("{0} - {1}", text, item.Value);
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("This word doesn`t exist in the dictionary.");
            }
        }
    }
}