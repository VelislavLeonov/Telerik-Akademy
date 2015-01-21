using System;
/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            byte age;
            char gender;
            int idNum;
            int empNum;
            Console.Write("First name:");
            firstName = Console.ReadLine();
            Console.Write("Last name:");
            lastName = Console.ReadLine();
            Console.Write("Age: ");
            age = byte.Parse(Console.ReadLine());
            Console.Write("Gender(m or f):");
            gender = char.Parse(Console.ReadLine());
            Console.Write("Personal ID number:");
            idNum = int.Parse(Console.ReadLine());
            Console.Write("Unique employee number:");
            empNum = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender(m or f):" + gender);
            Console.WriteLine("Personal ID number:" + idNum);
            Console.WriteLine("Unique employee number:" + empNum);
        }
    }
}
