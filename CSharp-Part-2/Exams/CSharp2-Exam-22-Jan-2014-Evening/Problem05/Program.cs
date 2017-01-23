using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem05
{
    class Program
    {
        static BigInteger FindPaths(BigInteger[,] input, int[] food)
        {
            input[0, 0] = 1;

            for (int i = 0; i < food[0] + 1; i++)
            {
                for (int j = 0; j < food[1] + 1; j++)
                {
                    if (input[i, j] >= 0)
                    {
                        if (i > 0)
                        {
                            input[i, j] += input[i - 1, j];
                        }

                        if (j > 0)
                        {
                            input[i, j] += input[i, j - 1];
                        }
                    }
                    else
                    {
                        input[i, j] = 0;
                    }
                }
            }

            return input[food[0], food[1]];
        }
        static void Main()
        {
            int[] size = Console.ReadLine().Split().Select(n => Convert.ToInt32(n)).ToArray();
            int[] food = Console.ReadLine().Split().Select(n => Convert.ToInt32(n)).ToArray();
            int enemiesN = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = new BigInteger[size[0], size[1]];

            for (int i = 0; i < enemiesN; i++)
            {
                int[] enemy = Console.ReadLine().Split().Select(n => Convert.ToInt32(n)).ToArray();
                matrix[enemy[0], enemy[1]] = -1;
            }            

            Console.WriteLine(FindPaths(matrix, food));
        }
    }
}
