using System;

/*Problem 9. Print a Sequence

Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/
   
class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i+1);
                Console.WriteLine(-(i+2));
            }
        }
    }

