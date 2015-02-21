using System;
/*Problem 12. Subtracting polynomials

Extend the previous program to support also subtraction and multiplication of polynomials.*/

namespace _12.Subtracting_polynomials
{
    class Program
    {
        static void Main()
        {
            decimal[] firstPol = { 5, -1 };
            Console.Write("First Polynomial: ");
            PrintPolynomial(firstPol);
            decimal[] secondPol = { 10, -5, 6 };
            Console.Write("Second Polynomial: ");
            PrintPolynomial(secondPol);
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
            PrintPolynomial(result);
            Substract(firstPol, secondPol, result);
            Console.Write("Substract: ");
            PrintPolynomial(result);
            decimal[] multiply = new decimal[firstPol.Length + secondPol.Length];
            Multiply(firstPol, secondPol, multiply);
            Console.Write("Multiply: ");
            PrintPolynomial(multiply);
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
        static void Multiply(decimal[] first, decimal[] second, decimal[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    int position = i + j;

                    result[position] += (first[i] * second[j]);
                }
            }
        }

        static void Substract(decimal[] first, decimal[] second, decimal[] result)
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
                result[i] = first[i] - second[i];
            }

            for (int i = minLenght; i < result.Length; i++)
            {
                if (smallerPoly == 1)
                {
                    result[i] = -second[i];
                }
                else
                {
                    result[i] = first[i];
                }
            }
        }

       

        static void PrintPolynomial(decimal[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0 && i != 0)
                {
                    if (polynomial[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} + ", i, polynomial[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polynomial[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.WriteLine(polynomial[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
