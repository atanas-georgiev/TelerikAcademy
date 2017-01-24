// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The Program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Refactoring_CSharpExamTask1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    /// <summary>
    ///     The one system to any other.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The numeric system.
        /// </summary>
        private const int NumericSystem = 23;

        /// <summary>
        /// The convert numeric system to dec.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="BigInteger"/>.
        /// </returns>
        private static BigInteger ConvertNumericSystemToDec(string value)
        {
            BigInteger decRepresentation = 0;

            var table1 = new char[NumericSystem];
            var table2 = new Dictionary<char, int>();

            for (var i = 0; i < table1.Length; i++)
            {
                table1[i] = (char)('a' + i);
                table2.Add(table1[i], i);
            }

            // base to decimal system
            for (var i = value.Length - 1; i >= 0; i--)
            {
                decRepresentation += table2[value[i]] * (BigInteger)Math.Pow(NumericSystem, value.Length - i - 1);
            }

            return decRepresentation;
        }

        /// <summary>
        /// The convert numeric system from dec.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private static string ConvertNumericSystemFromDec(BigInteger value)
        {
            var result = string.Empty;
            var table1 = new char[NumericSystem];

            while (value > 0)
            {
                BigInteger remainder = (ulong)(value % NumericSystem);
                value /= NumericSystem;

                result = table1[(int)remainder] + result;
            }

            return result;
        }

        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var result = input.Aggregate<string, BigInteger>(0, (current, t) => current + ConvertNumericSystemToDec(t));

            Console.WriteLine(ConvertNumericSystemFromDec(result) + " = " + result);
        }
    }
}