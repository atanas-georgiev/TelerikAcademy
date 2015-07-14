// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The problem 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task04Refactoring_CSharpExamTask1
{
    using System;

    /// <summary>
    ///     The problem 1.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            double n = 0, s = 0, p = 0;

            try
            {
                n = float.Parse(Console.ReadLine());
                s = float.Parse(Console.ReadLine());
                p = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new ArgumentException("Not valid input!");
            }

            // add 3 zeros for p variable
            p = double.Parse(string.Format("{0:F3}", p));

            var result = (n * s) / 400 * p;
            Console.WriteLine("{0:F3}", result);
        }
    }
}