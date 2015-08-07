// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hand.cs" company="">
//   
// </copyright>
// <summary>
//   The hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Poker
{
    using System.Collections.Generic;

    /// <summary>
    ///     The hand.
    /// </summary>
    public class Hand : IHand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hand"/> class.
        /// </summary>
        /// <param name="cards">
        /// The cards.
        /// </param>
        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        /// <summary>
        ///     Gets the cards.
        /// </summary>t
        public IList<ICard> Cards { get; private set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Join(" ", this.Cards);
        }
    }
}