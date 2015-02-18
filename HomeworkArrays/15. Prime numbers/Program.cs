using System;
/*Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm*/

namespace _15.Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] primeNumbers = new bool[200];
            for (int i = 2; i < Math.Sqrt(primeNumbers.Length); i++)
            {
                if (primeNumbers[i] == false)
                {
                    for (int j = i * i; j < primeNumbers.Length; j += i)
                    {
                        primeNumbers[j] = true;
                    }
                }
            }
            for (int i = 2; i < primeNumbers.Length; i++)
            {
                if (primeNumbers[i] == false)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
