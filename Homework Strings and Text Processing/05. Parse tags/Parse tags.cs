using System;
using System.Linq;
using System.Text;
/*Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/

namespace _05.Parse_tags
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - 8 && text.Substring(i, 8) == "<upcase>")
                {
                    i += 8;
                    while (i < text.Length - 9 && text.Substring(i, 9) != "</upcase>")
                    {
                        result.Append(text[i].ToString().ToUpper());
                        i++;
                    }
                    i += 8;
                }
                else
                {
                    result.Append(text[i]);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
