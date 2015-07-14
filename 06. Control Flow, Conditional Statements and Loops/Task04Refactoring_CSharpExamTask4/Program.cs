// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The problem 4.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task04Refactoring_CSharpExamTask4
{
    using System;

    /// <summary>
    ///     The problem 4.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            int i = 0, j = 0, lines = 0;

            try
            {
                lines = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                 throw new ArgumentException("Not valid input!");
            }                                

            for (i = 0; i < lines; i++)
            {
                Console.Write(":");
            }

            Console.WriteLine();
            Console.Write(":");
            
            for (i = 0; i < lines - 2; i++)
            {
                Console.Write(" ");
            }

            Console.Write("::");
            Console.WriteLine();
            Console.Write(":");
            
            for (i = 0; i < lines - 2; i++)
            {
                Console.Write(" ");
            }

            Console.Write(":|:");
            Console.WriteLine();

            for (i = 0; i < lines - 4; i++)
            {
                Console.Write(":");

                for (j = 0; j < lines - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(":");

                for (j = 0; j < 2 + i; j++)
                {
                    Console.Write("|");
                }

                Console.Write(":");
                Console.WriteLine();
            }

            for (i = 0; i < lines; i++)
            {
                Console.Write(":");
            }

            for (i = 0; i < lines - 2; i++)
            {
                Console.Write("|");
            }

            Console.Write(":");
            Console.WriteLine();

            for (i = 1; i < lines - 1; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(":");

                for (j = 0; j < lines - 2; j++)
                {
                    Console.Write("-");
                }

                Console.Write(":");

                for (j = 0; j < lines - i - 2; j++)
                {
                    Console.Write("|");
                }

                Console.Write(":");
                Console.WriteLine();
            }

            for (j = 0; j < lines - 1; j++)
            {
                Console.Write(" ");
            }

            for (i = 0; i < lines; i++)
            {
                Console.Write(":");
            }
        }
    }
}