using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
/*Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday 
 * except a fixed list of public holidays specified preliminary as array.*/

namespace _05.Workdays
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter a date: yyyy,MM,dd");
            DateTime givenDate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            Workday(today, givenDate);
        }

        static void Workday(DateTime today, DateTime givenDate)
        {
            int counter = 0;
            DateTime[] holidays = {
                                      new DateTime(2015,01,01),
                                      new DateTime(2015,03,03),
                                      new DateTime(2015,05,06),
                                      new DateTime(2015,05,24),
                                      new DateTime(2015,09,06),
                                      new DateTime(2015,09,22),
                                      new DateTime(2015,12,25),
                                      new DateTime(2015,12,26)
                                  };
            while (today <= givenDate)
            {
                if (holidays.Contains(today))
                {
                    
                }
                else if ((int)today.DayOfWeek == 0 || (int)today.DayOfWeek == 6)
                {
                    
                }
                else
                {
                    ++counter;
                }
                today = today.AddDays(1);
            }
            Console.WriteLine("{0} working days", counter);
        }
    }
}
