using System;
/*Problem 15.* Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation is:" + Convert.ToString(number, 2).PadLeft(32, '0'));
            uint mask = 7u;
            uint bits345 = number & (mask << 3);
            uint bits242526 = number & (mask << 24);
            bits345 = bits345 << 21;
            bits242526 = bits242526 >> 21;
            number = number & ~(mask << 3);
            number = number & ~(mask << 24);
            number = number | bits345;
            number = number | bits242526;
            Console.WriteLine("The binary result is: " + Convert.ToString(number, 2).PadLeft(32, '0') + "\n" + number);
        }
    }
}
