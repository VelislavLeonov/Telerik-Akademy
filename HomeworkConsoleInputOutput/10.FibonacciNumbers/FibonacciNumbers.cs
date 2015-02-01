using System;
/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.*/

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how manu numbers you want to display from Fibonacci Numbers:" );
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;
            int sum = 0;
            if (n == 1)
            {
                Console.WriteLine(firstNumber);
            }
            else if (n == 2)
            {
                Console.WriteLine("{0}, {1}, ",firstNumber,secondNumber);
            }
            else
            {
                Console.Write("{0}, {1}, ",firstNumber,secondNumber);
                for (int i = 2; i < n; i++)
                {
                    sum = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = sum;
                    Console.Write("{0}, ",sum );
                }
            }
        }
    }
}
