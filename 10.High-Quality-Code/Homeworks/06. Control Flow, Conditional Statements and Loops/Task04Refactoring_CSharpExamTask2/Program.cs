// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The problem 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task04Refactoring_CSharpExamTask2
{
    using System;
    using System.Linq;

    /// <summary>
    ///     The problem 2.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            int m = 0, result = 0; 
            string inputString = null;            

            try
            {
                m = int.Parse(Console.ReadLine());
                inputString = Console.ReadLine();
            }
            catch (Exception)
            {
                throw new ArgumentException("Not valid input!");
            }
            
            foreach (var simbol in inputString.TakeWhile(simbol => simbol != '@'))
            {
                if (char.IsDigit(simbol))
                {
                    result *= simbol - '0';
                }
                else if ((simbol >= 'a') && (simbol <= 'z'))
                {
                    result += simbol - 'a';
                }
                else if ((simbol >= 'A') && (simbol <= 'Z'))
                {
                    result += simbol - 'A';
                }
                else
                {
                    result %= m;
                }
            }

            Console.WriteLine(result);
        }
    }
}