using System;
/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter company name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Please enter company adress");
            string companyAdress = Console.ReadLine();
            Console.WriteLine("Please enter phone number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Please enter fax number");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("Please enter web site");
            string webSite = Console.ReadLine();
            Console.WriteLine("Please enter manager first name");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Please enter manager last name");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Please enter manager age");
            int managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter manager phone");
            string managerPhone = Console.ReadLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Adress:" + companyAdress);
            Console.WriteLine("Tel:" + phoneNumber);
            if (faxNumber.Length == 0)
            {
                Console.WriteLine("Fax:(no fax)");
            }
            else
            {
                Console.WriteLine("Fax:");
            }
            Console.WriteLine("Web site:" + webSite);
            Console.WriteLine("Manage: {0} {1} (age: {2}, tel: {3})",managerFirstName,managerLastName,managerAge,managerPhone);
        }
    }
}
