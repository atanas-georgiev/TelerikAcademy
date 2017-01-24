// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHand.cs" company="">
//   
// </copyright>
// <summary>
//   The Hand interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;

    /// <summary>
    /// The Hand interface.
    /// </summary>
    public interface IHand
    {
        /// <summary>
        /// Gets the cards.
        /// </summary>
        IList<ICard> Cards { get; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string ToString();
    }
}