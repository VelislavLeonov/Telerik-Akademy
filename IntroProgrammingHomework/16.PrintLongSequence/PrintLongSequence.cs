using System;
/*Problem 16.* Print Long Sequence

Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
You might need to learn how to use loops in C# (search in Internet).*/
   
class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i += 2)
            {
                Console.WriteLine(i + 1);
                Console.WriteLine(-(i + 2));
            }
        }
    }

