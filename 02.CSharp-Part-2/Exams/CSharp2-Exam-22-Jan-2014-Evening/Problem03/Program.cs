using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static int WindowX = 3;
        static int WindowY = 5;

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            bool found = false;
            List<double> sum = new List<double>();

            for (int i = 0; i <= N - WindowX; i++)
            {
                for (int j = 0; j <= N - WindowY; j++)
                {
                    if ((matrix[i, j] == matrix[i, j + 1] - 1) &&
                        (matrix[i, j + 1] == matrix[i, j + 2] - 1) &&
                        (matrix[i, j + 2] == matrix[i + 1, j + 2] - 1) &&
                        (matrix[i + 1, j + 2] == matrix[i + 2, j + 2] - 1) &&
                        (matrix[i + 2, j + 2] == matrix[i + 2, j + 3] - 1) &&
                        (matrix[i + 2, j + 3] == matrix[i + 2, j + 4] - 1))
                    {
                        found = true;
                        sum.Add(matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j + 2] + matrix[i + 2, j + 2] + matrix[i + 2, j + 3] + matrix[i + 2, j + 4]);
                    }
                }
            }

            if (found)
            {
                var sorted = sum.OrderByDescending(x => x);
                Console.WriteLine("YES " + sorted.First());
            }
            else
            {
                int sumDiag = 0;
                for (int i = 0; i < N; i++)
                {
                    sumDiag += matrix[i, i];
                }

                Console.WriteLine("NO " + sumDiag);
            }
        }
    }
}
