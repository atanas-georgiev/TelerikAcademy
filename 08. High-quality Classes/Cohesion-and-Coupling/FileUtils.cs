// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileUtils.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The file utils.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// The file utils.
    /// </summary>
    internal static class FileUtils
    {
        /// <summary>
        /// The get file extension.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetFileExtension(string fileName)
        {
            var indexOfLastDot = fileName.LastIndexOf(".", StringComparison.InvariantCulture);
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            var extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// The get file name without extension.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            var indexOfLastDot = fileName.LastIndexOf(".", StringComparison.InvariantCulture);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            var extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}