// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Card.cs" company="">
//   
// </copyright>
// <summary>
//   The card.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Poker
{
    /// <summary>
    ///     The card.
    /// </summary>
    public class Card : ICard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="face">
        /// The face.
        /// </param>
        /// <param name="suit">
        /// The suit.
        /// </param>
        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        /// <summary>
        ///     Gets the face.
        /// </summary>
        public CardFace Face { get; private set; }

        /// <summary>
        ///     Gets the suit.
        /// </summary>
        public CardSuit Suit { get; private set; }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            var result = string.Empty;

            switch (this.Face)
            {
                case CardFace.Two:
                    result += "2";
                    break;
                case CardFace.Three:
                    result += "3";
                    break;
                case CardFace.Four:
                    result += "4";
                    break;
                case CardFace.Five:
                    result += "5";
                    break;
                case CardFace.Six:
                    result += "6";
                    break;
                case CardFace.Seven:
                    result += "7";
                    break;
                case CardFace.Eight:
                    result += "8";
                    break;
                case CardFace.Nine:
                    result += "9";
                    break;
                case CardFace.Ten:
                    result += "10";
                    break;
                case CardFace.Jack:
                    result += "J";
                    break;
                case CardFace.Queen:
                    result += "Q";
                    break;
                case CardFace.King:
                    result += "K";
                    break;
                case CardFace.Ace:
                    result += "A";
                    break;
            }

            switch (this.Suit)
            {
                case CardSuit.Hearts:
                    result += '♥';
                    break;
                case CardSuit.Diamonds:
                    result += '♦';
                    break;
                case CardSuit.Spades:
                    result += '♠';
                    break;
                case CardSuit.Clubs:
                    result += '♣';
                    break;
            }

            return result;
        }

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        /// <summary>
        ///     The get hash code.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public override int GetHashCode()
        {
            return this.Face.GetHashCode() ^ this.Suit.GetHashCode();
        }
    }
}