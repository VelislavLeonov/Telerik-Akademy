using System;
/*Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).*/

namespace _03.Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an expression");
            string expression = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    ++counter;
                }
                else if (expression[i] == ')')
                {
                    --counter;
                }
                if (counter < 0)
                {
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Correct expression");
            }
            else
            {
                Console.WriteLine("Incorrect expression");
            }
        }
    }
}
