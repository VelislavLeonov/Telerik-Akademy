using System;
/*Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers
 p exist between them such that the reminder of the division by 5 is 0.*/

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter last number:");
            int lastNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            string numbers = null;
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                if (i % 5 == 0)
                {
                    sum = sum + 1;
                    numbers = numbers + Convert.ToString(i) + ", ";
                }
            }
            Console.WriteLine("There is {0} numbers divided by 5 without reminder.\nThe numbers:{1}", sum, numbers);
        }
    }
}
