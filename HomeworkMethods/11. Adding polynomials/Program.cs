using System;
/*Problem 11. Adding polynomials

Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}*/

namespace _11.Adding_polynomials
{
    class Program
    {
        static void Main()
        {
            decimal[] firstPol = { 5, -1 };
            Console.Write("First Polynomial: ");
            Print(firstPol);

            decimal[] secondPol = { 10, -5, 6 };
            Console.Write("Second Polynomial: ");
            Print(secondPol);

            int maxLength = 0;
            if (firstPol.Length > secondPol.Length)
            {
                maxLength = firstPol.Length;
            }
            else
            {
                maxLength = secondPol.Length;
            }

            decimal[] result = new decimal[maxLength];

            Sum(firstPol, secondPol, result);

            Console.Write("Sum: ");
            Print(result);
        }

        static void Sum(decimal[] first, decimal[] second, decimal[] result)
        {
            int minLenght = 0;
            int smallerPoly = 0;

            if (first.Length > second.Length)
            {
                minLenght = second.Length;
                smallerPoly = 2;
            }
            else
            {
                minLenght = first.Length;
                smallerPoly = 1;
            }

            for (int i = 0; i < minLenght; i++)
            {
                result[i] = first[i] + second[i];
            }

            for (int i = minLenght; i < result.Length; i++)
            {
                if (smallerPoly == 1)
                {
                    result[i] = second[i];
                }
                else
                {
                    result[i] = first[i];
                }
            }
        }

        static void Print(decimal[] pol)
        {
            for (int i = pol.Length - 1; i >= 0; i--)
            {
                if (pol[i] != 0 && i != 0)
                {
                    if (pol[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} + ", i, pol[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, pol[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.WriteLine(pol[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
