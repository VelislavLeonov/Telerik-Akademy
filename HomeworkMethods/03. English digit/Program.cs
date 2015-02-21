using System;
/*Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	two
1024	four
12309	nine*/

namespace _03.English_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = LastDigitWord(n);
            Console.WriteLine(word);
        }
        static string LastDigitWord(int a)
        {
            string digit = Convert.ToString(a % 10);
            switch (digit)
            {
                case "0": return "zero";
                case "1": return "one";
                case "2": return "two";
                case "3": return "three";
                case "4": return "four";
                case "5": return "five";
                case "6": return "six";
                case "7": return "seven";
                case "8": return "eight";
                case "9": return "nine";
            }
            return "Not integer";
        }
    }
}
