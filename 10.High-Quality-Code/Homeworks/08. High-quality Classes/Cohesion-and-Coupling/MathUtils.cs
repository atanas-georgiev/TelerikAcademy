// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MathUtils.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The math utils.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    ///     The math utils.
    /// </summary>
    internal static class MathUtils
    {
        /// <summary>
        /// Calculate distance 2 d.
        /// </summary>
        /// <param name="x1">
        /// The x 1.
        /// </param>
        /// <param name="y1">
        /// The y 1.
        /// </param>
        /// <param name="x2">
        /// The x 2.
        /// </param>
        /// <param name="y2">
        /// The y 2.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// Calculate distance 3 d.
        /// </summary>
        /// <param name="x1">
        /// The x 1.
        /// </param>
        /// <param name="y1">
        /// The y 1.
        /// </param>
        /// <param name="z1">
        /// The z 1.
        /// </param>
        /// <param name="x2">
        /// The x 2.
        /// </param>
        /// <param name="y2">
        /// The y 2.
        /// </param>
        /// <param name="z2">
        /// The z 2.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            var distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }

        /// <summary>
        /// Calculate volume.
        /// </summary>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        /// <param name="depth">
        /// The depth.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public static double CalcVolume(double width, double height, double depth)
        {
            var volume = width * height * depth;
            return volume;
        }

        /// <summary>
        /// Calculate diagonal 3 d.
        /// </summary>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        /// <param name="depth">
        /// The depth.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public static double CalcDiagonal3D(double width, double height, double depth)
        {
            var distance = CalcDistance3D(0, 0, 0, width, height, depth);
            return distance;
        }

        /// <summary>
        /// Calculate diagonal 2 d.
        /// </summary>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public static double CalcDiagonal2D(double width, double height)
        {
            var distance = CalcDistance2D(0, 0, width, height);
            return distance;
        }
    }
}