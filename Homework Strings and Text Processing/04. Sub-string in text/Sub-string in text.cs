using System;
/*Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9*/

namespace _04.Sub_string_in_text
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("Enter target");
            string target = Console.ReadLine().ToLower();
            int counter = 0;

            for (int i = 0; i < text.Length - target.Length; i++)
            {
                if (text.Substring(i, target.Length) == target)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
