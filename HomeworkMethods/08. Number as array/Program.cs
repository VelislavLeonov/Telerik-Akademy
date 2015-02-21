using System;
/*Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.*/

namespace _08.Number_as_array
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            string number1 = Console.ReadLine();
            Console.Write("Enter second number: ");
            string number2 = Console.ReadLine();
            int numberLenght = (number1.Length > number2.Length) ? number1.Length : number2.Length;
            number1 = number1.PadLeft(numberLenght, '0');
            number2 = number2.PadLeft(numberLenght, '0');
            int[] numberOne = new int[number1.Length];
            int[] numberTwo = new int[number2.Length];
            for (int i = 0; i < number1.Length; i++)
            {
                numberOne[i] = int.Parse(number1[number1.Length - 1 - i].ToString());
            }
            for (int i = 0; i < number2.Length; i++)
            {
                numberTwo[i] = int.Parse(number2[number2.Length - 1 - i].ToString());
            }
            SumTwoArrays(numberOne, numberTwo);

            PrintTheNumber(SumTwoArrays(numberOne, numberTwo));
            Console.WriteLine();
        }
        private static void PrintTheNumber(string number)
        {
            Console.Write("The redsult is: ");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
        }
        private static string SumTwoArrays(int[] numberOne, int[] numberTwo)
        {
            if (numberOne.Length > numberTwo.Length)
            {
                return SumTwoArrays(numberTwo, numberOne);
            }

            string summedNumber = string.Empty;
            int rest = 0;

            for (int i = 0; i < numberTwo.Length; i++)
            {
                summedNumber += ((numberOne[i] + numberTwo[i]) % 10 + rest).ToString();
                rest = (numberOne[i] + numberTwo[i]) / 10;
                if (rest > 0 && i == numberTwo.Length - 1)
                {
                    summedNumber += rest;
                }
            }
            return summedNumber;
        }
    }
}
