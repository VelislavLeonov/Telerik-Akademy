using System;
/*Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.*/

namespace _04.Triangle_surface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a method:\n1:Side and an altitude to it\n2:Three sides\n3:Two sides and an angle between them");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Please enter a side");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an altitude to the side");
                double h = double.Parse(Console.ReadLine());
                SideAndAltitude(a, h);
            }
            else if (n == 2)
            {
                Console.WriteLine("Please enter side a");
                double a = double.Parse(Console.ReadLine()); 
                Console.WriteLine("Please enter side b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter side c");
                double c = double.Parse(Console.ReadLine());
                ThreeSides(a,b,c);
            }
            else if (n == 3)
            {
                Console.WriteLine("Please enter side a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter side b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an angle");
                double e = double.Parse(Console.ReadLine());
                TwoSidesAndAngle(a,b,e);
            }
            else
            {
                Console.WriteLine("Invalid method");
            }
        }

        static void SideAndAltitude(double a, double h)
        {
            double surface = (a * h) / 2;
            Console.WriteLine(surface);
        }

        static void ThreeSides(double a, double b, double c)
        {
            double p = a + b + c;
            double surface = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine(surface);
        }

        static void TwoSidesAndAngle(double a, double b, double e)
        {
            double surface = (a*b*Math.Sin(e))/2;
            Console.WriteLine(surface);
        }
    }
}
