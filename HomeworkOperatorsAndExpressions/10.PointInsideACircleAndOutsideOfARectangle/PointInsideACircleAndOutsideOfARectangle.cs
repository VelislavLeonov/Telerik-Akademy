using System;
using System.Globalization;
using System.Threading;
/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

namespace PointInsideACircleAndOutsideOfARectangle
{
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please write x coordinate");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write y coordinate");
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            bool inCircle = (Math.Sqrt(((x - 1)*(x - 1)) + ((y - 1)*(y - 1))) <= r);
            bool outOfRectangle = (-1 < x)^(x > 5)^(-1 < y)^(y > 1);
            if (inCircle && outOfRectangle)
            {
                Console.WriteLine("The point is in the circle and out of the rectangle!");
            }
            else
            {
                Console.WriteLine("The point is't in the circle and out of the rectangle!");
            }
        }
    }
}
