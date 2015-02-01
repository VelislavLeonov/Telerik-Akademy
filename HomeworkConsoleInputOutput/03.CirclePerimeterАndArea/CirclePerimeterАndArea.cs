using System;
using System.Threading;
using System.Globalization;
/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with
 2 digits after the decimal point.*/

namespace CirclePerimeterАndArea
{
    class CirclePerimeterАndArea
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter radius:");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter:{0:0.00} \nArea:{1:0.00}", 2 * 3.14159206 * r, 3.14159206 * r * r);
        }
    }
}
