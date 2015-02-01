using System;
/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.*/

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
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
            Console.WriteLine(bit);   
        }
    }
}
