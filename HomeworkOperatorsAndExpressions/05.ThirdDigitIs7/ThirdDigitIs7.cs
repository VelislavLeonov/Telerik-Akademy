using System;
/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.*/

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write an integer number:");
            int number = int.Parse(Console.ReadLine());
            bool thirdDigit = (number / 100) % 10 == 7;
            Console.WriteLine(thirdDigit ? "The third digit is 7" : "The third digit is't 7");
        }
    }
}
