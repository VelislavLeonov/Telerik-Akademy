using System;
/*Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.*/

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int[] integerArr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                integerArr[i] = i * 5;
                Console.WriteLine(integerArr[i]);
            }
        }
    }
}
