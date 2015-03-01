using System;
using System.Text;
/*Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input   output
aaaaabbbbbcdddeeeedssaa   abcdedsa*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string");
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    continue;
                }
                else if (text[i] != text[i + 1])
                {
                    result.Append(text[i]);
                }
            }
            Console.WriteLine("{0}{1}", result.ToString(), text[text.Length - 1]);
        }
    }
}
