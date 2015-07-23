// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FiguresExample.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The figures example.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Abstraction
{
    using System;

    /// <summary>
    ///     The figures example.
    /// </summary>
    internal class FiguresExample
    {
        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            var circle = new Circle(5);
            Console.WriteLine(circle);
            var rect = new Rectangle(2, 3);
            Console.WriteLine(rect);
        }
    }
}