using System;
/*Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            double number1 = 34.567839023;
            Console.WriteLine(number1);
            float number2 = 12.345f;
            Console.WriteLine(number2);
            double number3 = 8923.1234857;
            Console.WriteLine(number3);
            float number4 = 3456.091f;
            Console.WriteLine(number4);
        }
    }
}
