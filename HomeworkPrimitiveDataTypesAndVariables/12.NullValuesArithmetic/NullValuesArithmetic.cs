using System;
/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullInt = null;
            double? nullDouble = null;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);
            nullInt = 14;
            nullDouble = 12.34;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);
        }
    }
}
