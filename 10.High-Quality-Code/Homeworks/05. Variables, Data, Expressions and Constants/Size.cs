// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Size.cs" company="Telerik">
//   Homework HQC
// </copyright>
// <summary>
//   The size.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace VariablesDataExpressions
{
    using System;

    /// <summary>
    ///     The size.
    /// </summary>
    public class Size
    {
        /// <summary>
        ///     The height.
        /// </summary>
        private readonly double height;

        /// <summary>
        ///     The width.
        /// </summary>
        private readonly double width;

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class.
        /// </summary>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// The get rotated size.
        /// </summary>
        /// <param name="size">
        /// The size.
        /// </param>
        /// <param name="angleOfTheFigureThatWillBeRotated">
        /// The angle of the figure that will be rotated.
        /// </param>
        /// <returns>
        /// The <see cref="Size"/>.
        /// </returns>
        public static Size GetRotatedSize(Size size, double angleOfTheFigureThatWillBeRotated)
        {
            var cosOfAngleOfTheFigureThatWillBeRotaed = Math.Cos(angleOfTheFigureThatWillBeRotated);
            var sinOfAngleOfTheFigureThatWillBeRotaed = Math.Sin(angleOfTheFigureThatWillBeRotated);
            var absOfAngleOfTheFigureThatWillBeRotaed = Math.Abs(cosOfAngleOfTheFigureThatWillBeRotaed);
            var widthResult = (Math.Abs(cosOfAngleOfTheFigureThatWillBeRotaed) * size.width)
                              + (absOfAngleOfTheFigureThatWillBeRotaed * size.height);
            var heightResult = (Math.Abs(sinOfAngleOfTheFigureThatWillBeRotaed) * size.width)
                               + (absOfAngleOfTheFigureThatWillBeRotaed * size.height);

            return new Size(widthResult, heightResult);
        }
    }
}