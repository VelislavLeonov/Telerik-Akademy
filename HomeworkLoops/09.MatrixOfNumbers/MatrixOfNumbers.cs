﻿using System;
/*Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
 * and prints a matrix like in the examples below. Use two nested loops.*/

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n + i ; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
