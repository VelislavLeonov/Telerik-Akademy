using System;
/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).*/

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of the array 1");
            int n = int.Parse(Console.ReadLine());
            string[] firstIntegerArr = new string[n];
            Console.WriteLine("Please enter symbols in array 1");
            for (int i = 0; i < n; i++)
            {
                firstIntegerArr[i] = Console.ReadLine();
            }
            Console.WriteLine("Please enter the lenght of the array 2");
            int m = int.Parse(Console.ReadLine());
            string[] secondIntegerArr = new string[m];
            Console.WriteLine("Please enter symbols in array 2");
            for (int i = 0; i < m; i++)
            {
                secondIntegerArr[i] = Console.ReadLine();
            }
            bool isEqual = true;
            if (n == m)
            {
                for (int i = 0; i < n; i++)
                {
                    int c = string.Compare(firstIntegerArr[i], secondIntegerArr[i]);
                    if (c == 0)
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
