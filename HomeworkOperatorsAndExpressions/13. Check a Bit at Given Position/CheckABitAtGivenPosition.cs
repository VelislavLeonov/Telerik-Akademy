using System;
/*Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
 * in given integer number n, has value of 1.*/

namespace Check_a_Bit_at_Given_Position
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation is:" + Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("Please enter number of the bit which index you'd like to see:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = number & mask;
            int bit = nAndMask >> p;
            bool check = bit == 1;
            Console.WriteLine(check ? "The chosen bit in your integer number is 1" : "The chosen bit in your integer number is 0");
        }
    }
}
