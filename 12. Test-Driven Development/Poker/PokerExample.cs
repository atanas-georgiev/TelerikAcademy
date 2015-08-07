// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokerExample.cs" company="">
//   
// </copyright>
// <summary>
//   The poker example.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The poker example.
    /// </summary>
    internal class PokerExample
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine(card);

            IHand hand =
                new Hand(
                    new List<ICard>
                        {
                            new Card(CardFace.Ace, CardSuit.Clubs), 
                            new Card(CardFace.Ace, CardSuit.Diamonds), 
                            new Card(CardFace.King, CardSuit.Hearts), 
                            new Card(CardFace.King, CardSuit.Spades), 
                            new Card(CardFace.Seven, CardSuit.Diamonds)
                        });
            Console.WriteLine(hand);

            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine(checker.IsValidHand(hand));
            Console.WriteLine(checker.IsOnePair(hand));
            Console.WriteLine(checker.IsTwoPair(hand));
        }
    }
}