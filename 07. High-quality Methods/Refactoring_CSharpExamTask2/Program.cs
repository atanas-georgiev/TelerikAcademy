// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Refactoring_CSharpExamTask2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The absolute difference.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        /// <param name="b">
        /// The b.
        /// </param>
        /// <returns>
        /// The <see cref="BigInteger"/>.
        /// </returns>
        private static BigInteger AbsoluteDifference(BigInteger a, BigInteger b)
        {
            if (a >= b)
            {
                return a - b;
            }

            return b - a;
        }

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var inputValue = Console.ReadLine().Split(' ').ToArray();
            var list = inputValue.Select(BigInteger.Parse).ToList();

            BigInteger sum = 0;

            for (var i = 1; i < inputValue.Length; i++)
            {
                var temp = AbsoluteDifference(list[i - 1], list[i]);

                if (temp % 2 == 0)
                {
                    // Even jump
                    i++;
                    sum += temp;
                }
            }

            Console.WriteLine(sum);
        }
    }
}