using System;
/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter min");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter max");
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomInt = random.Next(min, max+1);
                Console.WriteLine("{0} ",randomInt);
            }
        }
    }
}
