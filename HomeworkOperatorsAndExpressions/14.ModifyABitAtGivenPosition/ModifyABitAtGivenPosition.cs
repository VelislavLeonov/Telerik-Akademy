using System;
/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position
p from the binary representation of n while preserving all other bits in n.*/

namespace ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation is:" + Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("Please enter number of the bit which index you'd like to modify:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Please choose how to modify 1 or 0:");
            int v = int.Parse(Console.ReadLine());
            int result = 0;
            if (v == 1)
            {
                int mask = 1 << p;
                result = number | mask;
                Console.WriteLine("The binary result is:" + Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine("The result is: " + result);
            }
            else
            {
                int mask = ~(1 << p);
                result = number & mask;
                Console.WriteLine("The binary result is:" + Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine("The result is: " + result);
            }

        }
    }
}
