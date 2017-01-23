using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem02
{
    class Program
    {
        static void Main()
        {
            checked
            {
                var inputPath = Console.ReadLine().Trim(' ').Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                int paths = int.Parse(Console.ReadLine());
                int[][] pathArrays = new int[paths][];

                for (int i = 0; i < paths; i++)
                {
                    var path = Console.ReadLine().Trim(' ').Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                    pathArrays[i] = path;
                }

                long[] sums = new long[paths];

                for (int i = 0; i < paths; i++)
                {
                    int index = 0;
                    int j = 0;

                    int[] tempArr = new int[inputPath.Length];
                    for (int m = 0; m < inputPath.Length; m++)
                    {
                        tempArr[m] = 0;
                    }

                    sums[i] = (long)inputPath[0];
                    tempArr[0] = 1;

                    while (true)
                    {
                        index = index + pathArrays[i][j % pathArrays[i].Length];
                        if ((index < 0) || index >= inputPath.Length || (tempArr[index] == 1))
                        {
                            break;
                        }

                        sums[i] += (long)inputPath[index];
                        tempArr[index] = 1;
                        j++;
                    }
                }
                Console.WriteLine(sums.Max());
            }
        }
    }
}
