using System;
/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write integer number:");
            int number = int.Parse(Console.ReadLine());
            bool result = (number % 5 == 0) && (number % 7 == 0);
            Console.WriteLine(result ? "Divided by 7 and 5 at the same time" : "Not divided by 7 and 5 at the same time");
        }
    }
}
