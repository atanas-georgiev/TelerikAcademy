//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

namespace Problem2MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("M = ");
            int m = int.Parse(Console.ReadLine());

            int[,] array = new int[n, m];

            // Read data from console
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Array[{0},{1}] = ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int currSum = 0;
            int maxSum = 0;
            int maxX = 0;
            int maxY = 0;

            // range to check
            int p = 3;
            int q = 3;

            // Find biggest sum
            for (int i = 0; i < n - p + 1; i++)
            {
                for (int j = 0; j < m - q + 1; j++)
                {
                    currSum = 0;

                    // point x,y, calculate the sum in range [x,x+p,y,y+q]
                    for (int k = 0; k < p; k++)
                    {
                        for (int l = 0; l < q; l++)
                        {
                            currSum += array[i + k, j + l];
                        }
                    }

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxX = i;
                        maxY = j;
                    }
                }
            }

            // Display array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Maximal sum is in window[{0},{1}-{2},{3}] in the array is: {4}", maxX, maxY, maxX + p - 1, maxY + q - 1, maxSum);
        }
    }
}
