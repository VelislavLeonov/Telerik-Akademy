using System;
/*Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	output
Hi!	\u0048\u0069\u0021*/

namespace _10.Unicode_characters
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:X4}", Convert.ToUInt16(text[i]));
            }
            Console.WriteLine();
        }
    }
}
