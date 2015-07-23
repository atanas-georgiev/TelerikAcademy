// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UtilsExamples.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The utils examples.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// The utils examples.
    /// </summary>
    internal class UtilsExamples
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", MathUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", MathUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            double width = 3, height = 4, depth = 5;
            Console.WriteLine("Volume = {0:f2}", MathUtils.CalcVolume(width, height, depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", MathUtils.CalcDiagonal3D(width, height, depth));
            Console.WriteLine("Diagonal XY = {0:f2}", MathUtils.CalcDiagonal2D(width, height));
            Console.WriteLine("Diagonal XZ = {0:f2}", MathUtils.CalcDiagonal2D(width, depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", MathUtils.CalcDiagonal2D(height, depth));
        }
    }
}