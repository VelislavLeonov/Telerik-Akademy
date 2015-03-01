using System;
using System.Globalization;
using System.Text;
/*Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and
 prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter date and time in format dd.MM.yyyy HH:mm:ss ");
            string date = Console.ReadLine();
            DateTime dateAfter = DateTime.ParseExact(date, "d.M.yyyy H:m:s", CultureInfo.GetCultureInfo("bg-BG"));
            dateAfter = dateAfter.AddHours(6.5);
            Console.WriteLine(dateAfter.ToString("dddd d.M.yyyy HH:mm:ss"));
        }
    }
}
