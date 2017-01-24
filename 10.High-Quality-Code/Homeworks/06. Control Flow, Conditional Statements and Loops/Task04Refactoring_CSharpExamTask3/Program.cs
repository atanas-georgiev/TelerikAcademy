// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The problem 3.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task04Refactoring_CSharpExamTask3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    /// <summary>
    ///     The problem 3.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            checked
            {
                var values = new List<ulong>();
                var loops = 1;
                var inputString = ulong.Parse(Console.ReadLine()).ToString();

                while (true)
                {
                    while (inputString.Length != 0)
                    {
                        inputString = inputString.Remove(inputString.Length - 1);
                        var sum = inputString.Where((t, i) => (i % 2) == 1)
                            .Aggregate<char, ulong>(0, (current, t) => current + (ulong)(t - '0'));

                        if (sum != 0)
                        {
                            values.Add(sum);
                        }
                    }

                    BigInteger product;

                    if (values.Count > 0)
                    {
                        product = values[0];
                        for (var i = 1; i < values.Count; i++)
                        {
                            product *= values[i];
                        }
                    }
                    else
                    {
                        product = 1;
                    }

                    inputString = product.ToString();
                    if (product < 10)
                    {
                        Console.WriteLine(loops);
                        Console.WriteLine(product);
                        return;
                    }

                    if (loops == 10)
                    {
                        Console.WriteLine(product);
                        return;
                    }

                    values.Clear();
                    loops++;
                }
            }
        }
    }
}