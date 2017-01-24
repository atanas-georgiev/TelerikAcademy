// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokerHandsChecker.cs" company="">
//   
// </copyright>
// <summary>
//   The poker hands checker.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Poker
{
    using System;
    using System.Linq;

    /// <summary>
    ///     The poker hands checker.
    /// </summary>
    public class PokerHandsChecker : IPokerHandsChecker
    {
        /// <summary>
        ///     The valid hand cards count.
        /// </summary>
        public const int ValidHandCardsCount = 5;

        /// <summary>
        /// The is valid hand.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        /// <exception cref="ArgumentException">
        /// </exception>
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("hand", "Hand cannot be null.");
            }

            if (hand.Cards.Count != ValidHandCardsCount)
            {
                throw new ArgumentException("Invalid hand.");
            }

            if (hand.Cards.Distinct().Count() != ValidHandCardsCount)
            {
                throw new ArgumentException("Duplicate cards.");
            }

            return true;
        }

        /// <summary>
        /// The is straight flush.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The is four of a kind.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsFourOfAKind(IHand hand)
        {
            this.IsValidHand(hand);
            return hand.Cards.GroupBy(card => card.Face).Any(gr => gr.Count() == 4);
        }

        /// <summary>
        /// The is full house.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The is flush.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsFlush(IHand hand)
        {
            this.IsValidHand(hand);
            return hand.Cards.GroupBy(card => card.Suit).Count() == 1;
        }

        /// <summary>
        /// The is straight.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The is three of a kind.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The is two pair.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The is one pair.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The is high card.
        /// </summary>
        /// <param name="hand">
        /// The hand.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}