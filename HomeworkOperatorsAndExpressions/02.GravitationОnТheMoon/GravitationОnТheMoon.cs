﻿using System;
using System.Globalization;
using System.Threading;
/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

namespace GravitationОnТheMoon
{
    class GravitationОnТheMoon
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Write your weight on the Earth:");
            double weightOnEarth = double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the moon is " + weightOnEarth * 0.17 );
           
           
        }
    }
}
