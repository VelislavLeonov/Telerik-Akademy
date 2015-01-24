using System;
/*Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive*/

namespace _08.PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number lesser or equal to 100");
            int number = int.Parse(Console.ReadLine());
            bool check = true;
            if (number <= 100)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {
                    Console.WriteLine("The number isn't prime");
                }
            }
            else
            {
                Console.WriteLine("You are entering invalid number");
            }
            
        }
    }
}
