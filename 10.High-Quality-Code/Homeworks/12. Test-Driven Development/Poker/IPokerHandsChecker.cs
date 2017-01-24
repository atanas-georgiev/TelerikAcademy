// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPokerHandsChecker.cs" company="">
//   
// </copyright>
// <summary>
//   Interface for checking poker hands as defined in http://en.wikipedia.org/wiki/List_of_poker_hands.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    /// <summary>
    ///     Interface for checking poker hands as defined in http://en.wikipedia.org/wiki/List_of_poker_hands.
    /// </summary>
    public interface IPokerHandsChecker
    {
        /// <summary>
        /// The is valid hand.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsValidHand(IHand hand);

        /// <summary>
        /// The is straight flush.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsStraightFlush(IHand hand);

        /// <summary>
        /// The is four of a kind.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsFourOfAKind(IHand hand);

        /// <summary>
        /// The is full house.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsFullHouse(IHand hand);

        /// <summary>
        /// The is flush.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsFlush(IHand hand);

        /// <summary>
        /// The is straight.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsStraight(IHand hand);

        /// <summary>
        /// The is three of a kind.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsThreeOfAKind(IHand hand);

        /// <summary>
        /// The is two pair.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsTwoPair(IHand hand);

        /// <summary>
        /// The is one pair.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsOnePair(IHand hand);

        /// <summary>
        /// The is high card.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsHighCard(IHand hand);

        /// <summary>
        /// The compare hands.
        /// </summary>
        /// <param name="firstHand">
        /// The first hand.
        /// </param>
        /// <param name="secondHand">
        /// The second hand.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int CompareHands(IHand firstHand, IHand secondHand);
    }
}