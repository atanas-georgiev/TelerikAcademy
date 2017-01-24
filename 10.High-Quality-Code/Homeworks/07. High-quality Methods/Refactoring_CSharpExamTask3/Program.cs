// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Refactoring_CSharpExamTask3
{
    using System;
    using System.Linq;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var coords = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            var array = new int[coords[0], coords[1]];

            for (var i = coords[0] - 1; i >= 0; i--)
            {
                var value = (coords[0] - 1 - i) * 3;

                for (var j = 0; j < coords[1]; j++)
                {
                    array[i, j] = value;
                    value += 3;
                }
            }

            var lines = int.Parse(Console.ReadLine());
            ulong sum = 0;
            int[] position = { coords[0] - 1, 0 };

            for (var i = 0; i < lines; i++)
            {
                var str = Console.ReadLine().Split(' ').ToArray();
                var step = int.Parse(str[1]) - 1;

                switch (str[0])
                {
                    case "RU":
                    case "UR":
                        while (position[0] - 1 != -1 && position[1] + 1 < coords[1] && step != 0)
                        {
                            position[0]--;
                            position[1]++;
                            sum += (ulong)array[position[0], position[1]];
                            array[position[0], position[1]] = 0;
                            step--;
                        }

                        break;
                    case "LU":
                    case "UL":
                        while (position[0] - 1 != -1 && position[1] - 1 != -1 && step != 0)
                        {
                            position[0]--;
                            position[1]--;
                            sum += (ulong)array[position[0], position[1]];
                            array[position[0], position[1]] = 0;
                            step--;
                        }

                        break;
                    case "DL":
                    case "LD":
                        while (position[1] - 1 != -1 && position[0] + 1 < coords[0] && step != 0)
                        {
                            position[0]++;
                            position[1]--;
                            sum += (ulong)array[position[0], position[1]];
                            array[position[0], position[1]] = 0;
                            step--;
                        }

                        break;
                    case "RD":
                    case "DR":
                        while (position[0] + 1 < coords[0] && position[1] + 1 < coords[1] && step != 0)
                        {
                            position[0]++;
                            position[1]++;
                            sum += (ulong)array[position[0], position[1]];
                            array[position[0], position[1]] = 0;
                            step--;
                        }

                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}