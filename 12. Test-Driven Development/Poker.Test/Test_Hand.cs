// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test_Hand.cs" company="">
//   
// </copyright>
// <summary>
//   The test_ hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker.Test
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The test_ hand.
    /// </summary>
    [TestClass]
    public class Test_Hand
    {
        /// <summary>
        /// The test_ hand_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_Hand_ValidValue()
        {
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
            Assert.AreEqual("A♣ A♦ K♥ K♠ 7♦", hand.ToString(), "Not valid hand!" + hand);
        }
    }
}