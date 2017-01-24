// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Potato.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The potato.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task02Refactoring
{
    /// <summary>
    ///     The potato.
    /// </summary>
    public class Potato
    {
        /// <summary>
        ///     Gets a value indicating whether has not been peeled.
        /// </summary>
        public bool HasNotBeenPeeled { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether is rotten.
        /// </summary>
        public bool IsRotten { get; private set; }
    }
}