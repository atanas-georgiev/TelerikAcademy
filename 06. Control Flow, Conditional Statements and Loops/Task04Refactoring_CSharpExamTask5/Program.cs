// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The problem 5.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task04Refactoring_CSharpExamTask5
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The problem 5.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The Input.
        /// </summary>
        private static readonly List<string> Input = new List<string>();

        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            int n = 0;

            try
            {
                n = int.Parse(Console.ReadLine());
                for (var i = 0; i < n; i++)
                {
                    Input.Add(Convert.ToString(uint.Parse(Console.ReadLine()), 2));
                    Input[i] = Input[i].PadLeft(Input[i].Length + 30, '0');
                    Input[i] = Input[i].Substring(Input[i].Length - 30, 30);
                }
            }
            catch (Exception)
            {                
                throw new ArgumentException("Invalid input!");
            }            

            var final = string.Empty;

            for (var i = 0; i < n; i++)
            {
                final += Input[i];
            }

            var numCurrSeq0 = 1;
            var longestSeq0 = 0;
            var numCurrSeq1 = 1;
            var longestSeq1 = 0;

            for (var i = 0; i < final.Length - 1; i++)
            {
                if ((final[i] == '0') && (final[i + 1] == '0'))
                {
                    numCurrSeq0++;
                }
                else
                {
                    numCurrSeq0 = 1;
                }

                if ((final[i] == '1') && (final[i + 1] == '1'))
                {
                    numCurrSeq1++;
                }
                else
                {
                    numCurrSeq1 = 1;
                }

                if (longestSeq0 < numCurrSeq0)
                {
                    longestSeq0 = numCurrSeq0;
                }

                if (longestSeq1 < numCurrSeq1)
                {
                    longestSeq1 = numCurrSeq1;
                }
            }

            var found = false;
            for (var i = 0; i < final.Length - 1; i++)
            {
                if (final[i] == '0')
                {
                    found = true;
                }
            }

            if (found == false)
            {
                longestSeq0 = 0;
            }

            found = false;
            for (var i = 0; i < final.Length - 1; i++)
            {
                if (final[i] == '1')
                {
                    found = true;
                }
            }

            if (found == false)
            {
                longestSeq1 = 0;
            }

            Console.WriteLine(longestSeq1);
            Console.WriteLine(longestSeq0);
        }
    }
}