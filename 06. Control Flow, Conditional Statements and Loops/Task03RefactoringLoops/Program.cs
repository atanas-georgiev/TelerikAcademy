// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task03RefactoringLoops
{
    using System;
    using System.Linq;

    /// <summary>
    ///     The program.
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
            var array = Enumerable.Range(2, 200).ToArray();
            var expectedValue = 2;

            for (var i = 0; i < 100; i++)
            {
                if ((i % 10 == 0) && (array[i] == expectedValue))
                {
                    Console.WriteLine("Value Found");
                    break;
                }

                Console.WriteLine(array[i]);
            }
        }
    }
}