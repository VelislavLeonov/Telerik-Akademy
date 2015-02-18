using System;
/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:*/

namespace _01.Fill_the_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[col,row] = counter;
                    ++counter;
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ",matrix[col,row]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            counter = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[col, row] = counter;
                        ++counter;
                    }  
                }
                else
                {
                    for (int row = n-1; row >= 0; row--)
                    {
                        matrix[col, row] = counter;
                        ++counter;
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ", matrix[col, row]);
                }
                Console.WriteLine();
            }
            counter = 1;
            Console.WriteLine();
            int maxValue = n * n;
            int startRow = 1;
            int startCol = 0;
            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(1); )
                {
                    matrix[row, col] = counter;

                    if (counter == maxValue)
                    {
                        break;
                    }
                    else if (row == n - 1 && col != n - 1)
                    {
                        row -= startRow;
                        col -= startCol;
                        startRow++;
                        startCol++;
                    }
                    else if (row == n - 1 || col == n - 1)
                    {
                        startCol--;
                        startRow--;
                        col -= startCol;
                        row -= startRow;
                    }
                    else
                    {
                        row++;
                        col++;
                    }
                    counter++;
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            counter = 1;
            int offset = 0;
            while (counter <= n * n)
            {
                int col = 0;
                int row = 0;
                for ( row = offset; row < n - offset; row++)
                {
                    col = offset;
                    matrix[row, col] = counter;
                    counter++;
                }
                for (col = 1 + offset; col < n - offset; col++)
                {
                    row = n - 1 - offset;
                    matrix[row, col] = counter;
                    counter++;
                }
                for (row = n - 2 - offset; row >= offset; row--)
                {
                    col = n - 1 - offset;
                    matrix[row, col] = counter;
                    counter++;
                }
                for (col = n - 2 - offset; col >= offset + 1; col--)
                {
                    row = offset;
                    matrix[row, col] = counter;
                    counter++;
                }
                offset++;
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
