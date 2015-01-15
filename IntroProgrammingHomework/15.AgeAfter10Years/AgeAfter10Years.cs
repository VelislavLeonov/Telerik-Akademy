using System;
/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/
class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday:");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int AgeNow = 0;
                if (today.Month < birthday.Month)
                {
                AgeNow = today.Year - birthday.Year - 1;
                }
                else if (today.Day < birthday.Day)
                    {
                    AgeNow = today.Year - birthday.Year - 1;
                    }
                    else
                    {
                        if (today.Day > birthday.Day)
                        {
                        AgeNow = today.Year - birthday.Year;
                        }
                        else
                        {
                        AgeNow = today.Year - birthday.Year;
                        }
                }
            Console.WriteLine("Your age now is {0} and after 10 years it will be {1}", AgeNow, AgeNow + 10);

        }
    }

