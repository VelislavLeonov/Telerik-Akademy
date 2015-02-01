using System;
using System.Globalization;
using System.Threading;
/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("a =");
            double a = double.Parse(Console.ReadLine()); 
            Console.WriteLine("b =");
            double b = double.Parse(Console.ReadLine()); 
            Console.WriteLine("c =");
            double c = double.Parse(Console.ReadLine());
            int check = 1;
            if (a == 0 | b == 0 | c == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (a < 0)
                {
                    check = check * (-1);
                }
                if (b < 0)
                {
                    check = check * (-1);
                }
                if (c < 0)
                {
                    check = check * (-1);
                }
                if (check > 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}
