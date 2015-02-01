using System;
using System.Globalization;
using System.Threading;
/*Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
 and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
 Note: You may need to learn how to parse dates and times.*/
namespace BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter time in format “hh:mm tt”");
            DateTime input = DateTime.Parse(Console.ReadLine());
            int hour = int.Parse(input.ToString("hh"));
            string AMPM = input.ToString("tt");
            if ((hour >= 0 & hour < 1 & AMPM == "PM") | (hour < 12 & hour >= 3 & AMPM == "AM"))
            {
                Console.WriteLine("Non beer time");
            }
            else if ((hour < 12 & hour >= 1 & AMPM == "PM") | (hour >= 0 & hour < 3 & AMPM == "AM"))
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Invalid time");
            }
        }
    }
}
