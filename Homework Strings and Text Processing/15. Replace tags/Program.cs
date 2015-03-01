using System;
/*Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

input   output
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length - 9; i++)
            {
                if (text.Substring(i, 9) == "<a href=\"")
                {
                    text = text.Replace("<a href=\"", "[URL=");
                }
                if (text.Substring(i, 2) == "\">")
                {
                    text = text.Replace("\">", "]");
                }
                if (text.Substring(i, 4) == "</a>")
                {
                    text = text.Replace("</a>", "[/URL]");
                }
            }
            Console.WriteLine(text);
        }
    }
}