using System;
using System.Globalization;
using System.Threading;
/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.*/

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please input rectangle's width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input rectangle's height:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("The rectangle's perimeter is:" + (width * height));
        }
    }
}
