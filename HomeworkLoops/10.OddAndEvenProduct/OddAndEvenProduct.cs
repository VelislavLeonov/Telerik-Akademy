﻿using System;
/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter numbers: ");
            string numbers = Console.ReadLine();
            string[] arrayNumbers = numbers.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int number = int.Parse(arrayNumbers[i]);
                if (i % 2 == 0)
                {
                    evenProduct = evenProduct * number;
                }
                else
                {
                    oddProduct = oddProduct * number;
                }
            }
            if (evenProduct == oddProduct)
            {
                Console.WriteLine("Product = {0}", evenProduct);
            }
            else
            {
                Console.WriteLine("Odd product = {0}\nEven product = {1}",oddProduct,evenProduct);
            }
        }
    }
}
