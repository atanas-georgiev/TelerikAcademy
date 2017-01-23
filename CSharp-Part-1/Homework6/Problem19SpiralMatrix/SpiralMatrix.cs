//Problem 19.** Spiral Matrix
//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

namespace Problem19SpiralMatrix
{
    class SpiralMatrix
    {
        static int[,] matrix;
        static int number = 1;
        static int n;

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];

            // all zeros
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            // at the start point
            Spiral(0, 0);

            // if odd , the method misses the last, in the center
            if (number % 2 != 0)
            {
                matrix[n / 2, n / 2] = n * n;
            }

            // testing and printing
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        // just for arrange the code
        // works in Loop principle, each time do a full circle, from point to the same point
        // if the end point is the start , move diagonally and do another circle
        static void Spiral(int row, int col)
        {
            if (number >= n * n)
            {
                return;
            }
            else
            {
                // down
                while ((row < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row++;
                    number++;
                }
                row--;
                col++;
                // left
                while ((col < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col++;
                    number++;
                }
                col--;
                row--;
                // up
                while ((row >= 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row--;
                    number++;
                }
                row++;
                col--;
                // left
                while ((col > 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col--;
                    number++;
                }

                if (matrix[row, col] != 0)
                {
                    row++;
                    col++;
                    Spiral(row, col);
                }
            }
        }

    }
}
