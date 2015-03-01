using System;
/*Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
percentage and in scientific notation.
Format the output aligned right in 15 symbols.*/
namespace _11.Format_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0, 15:F2}", number);   
            Console.WriteLine("{0, 15:X}", number);    
            Console.WriteLine("{0, 15:P}", number);    
            Console.WriteLine("{0, 15:E}", number);    
        }
    }
}
