using System;
/*Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:

input	output
Peter	Hello, Peter!*/

namespace _01.Say_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintHelloName();
        }
        static void PrintHelloName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
