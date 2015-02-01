using System;
using System.Globalization;
using System.Threading;
/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please write x coordinate;");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write y coordinate;");
            double y = double.Parse(Console.ReadLine());
            double r = 2;
            double pointDistance = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine(r > pointDistance ? "The point is inside the circle" : "The point is't inside the circle");
        }
    }
}
