using System;
using System.Globalization;
using System.Threading;
/*Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
Example:

input	output
256	652
123.45	54.321*/
namespace _07.Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            decimal number = decimal.Parse(Console.ReadLine());
            string numberInString = Convert.ToString(number);
            Console.WriteLine(Reverse(numberInString));
        }
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
