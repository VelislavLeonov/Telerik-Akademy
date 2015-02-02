using System;
using System.Collections.Generic;
/*Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

namespace RandomizeTheNumbers1_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n:");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            List<int> r = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number;
                do
                { 
                    number = random.Next(1,n+1);
                }
                while (r.Contains(number));
                r.Add(number);
                Console.Write("{0} ",number);
            }

        }
    }
}
