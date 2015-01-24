using System;
/*Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

namespace BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation is:" + Convert.ToString(number, 2).PadLeft(32, '0'));
            int p = 3;               
            int mask = 1 << p;        
            int nAndMask = number & mask;  
            int bit = nAndMask >> p;  
            Console.WriteLine(bit);   
        }
    }
}
