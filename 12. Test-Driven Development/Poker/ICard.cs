// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICard.cs" company="">
//   
// </copyright>
// <summary>
//   The Card interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    /// <summary>
    /// The Card interface.
    /// </summary>
    public interface ICard
    {
        /// <summary>
        /// Gets the face.
        /// </summary>
        CardFace Face { get; }

        /// <summary>
        /// Gets the suit.
        /// </summary>
        CardSuit Suit { get; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string ToString();
    }
}