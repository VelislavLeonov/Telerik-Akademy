using System;
using System.Globalization;
using System.Threading;
/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

namespace PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1: Console.WriteLine("Please enter int");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);
                    break;
                case 2: Console.WriteLine("Please enter double");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);
                    break;
                case 3: Console.WriteLine("Please enter string");
                    string c = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("{0}*",c);
                    break;
                default:Console.WriteLine("Invalid type");
                    break;
            }
        }
    }
}
