// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Figure.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The figure.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Abstraction
{
    /// <summary>
    ///     The figure.
    /// </summary>
    internal abstract class Figure
    {
        /// <summary>
        ///     Calculate perimeter.
        /// </summary>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public abstract double CalcPerimeter();

        /// <summary>
        ///     Calculate surface.
        /// </summary>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public abstract double CalcSurface();
    }
}