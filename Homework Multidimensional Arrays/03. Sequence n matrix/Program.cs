using System;
/*Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[m, n];
            int counter = 1;
            int bestSequence = 0;
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }
            string bestElement = matrix[1, 1];
            for (int row = 0; row < m; row++)
            {
                counter = 1;
                for (int col = 0; col < n - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        ++counter;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > bestSequence)
                    {
                        bestSequence = counter;
                        bestElement = matrix[row, col];
                    }
                }
            }
            for (int col = 0; col < n; col++)
            {
                counter = 1;
                for (int row = 0; row < m - 1; row++)
                {
                    if (matrix[row + 1, col] == matrix[row, col])
                    {
                        ++counter;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > bestSequence)
                    {
                        bestSequence = counter;
                        bestElement = matrix[row, col];
                    }
                }
            }
            for (int row = 0; row < m - 1; row++)
            {
                for (int col = 0; col < n - 1; col++)
                {
                    counter = 1;
                    for (int i = row, j = col; i < m - 1 && j < n - 1; i++, j++)
                    {
                        if (matrix[row + 1, col + 1] == matrix[row, col])
                        {
                            ++counter;
                        }
                        if (counter > bestSequence)
                        {
                            bestSequence = counter;
                            bestElement = matrix[row, col];
                        }
                    }
                }
            }
            for (int row = 0; row < m - 1; row++)
            {
                for (int col = 1; col < n; col++)
                {
                    counter = 1;
                    for (int i = row, j = col; i < m - 1 && j >= 0; i++, j--)
                    {
                        if (matrix[row + 1, col - 1] == matrix[row, col])
                        {
                            ++counter;
                        }
                        else
                        {
                            counter = 1;
                        }
                        if (counter > bestSequence)
                        {
                            bestSequence = counter;
                            bestElement = matrix[row, col];
                        }
                    }
                }
            }
            for (int i = 0; i < bestSequence; i++)
            {
                if (i == bestSequence - 1)
                {
                    Console.WriteLine(bestElement);
                }
                else
                {
                    Console.Write(bestElement + ", ");
                }
            }
        }
    }
}

