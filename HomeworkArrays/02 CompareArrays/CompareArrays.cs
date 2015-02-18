using System;
/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.*/

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of the array 1");
            int n = int.Parse(Console.ReadLine());
            int[] firstIntegerArr = new int[n];
            Console.WriteLine("Please enter integers in array 1");
            for (int i = 0; i < n; i++)
            {
                firstIntegerArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the lenght of the array 2");
            int m = int.Parse(Console.ReadLine());
            int[] secondIntegerArr = new int[m];
            Console.WriteLine("Please enter integers in array 2");
            for (int i = 0; i < m; i++)
            {
                secondIntegerArr[i] = int.Parse(Console.ReadLine());
            }
            bool isEqual = true;
            if (n == m)
            {
                for (int i = 0; i < n; i++)
                {
                    if (firstIntegerArr[i] == secondIntegerArr[i])
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            else
            {
                isEqual = false;
            }
            if (isEqual == true)
            {
                Console.WriteLine("The two arrays are equal");
            }
            else
            {
                Console.WriteLine("The two arrays aren't equal");
            }
        }
    }
}
