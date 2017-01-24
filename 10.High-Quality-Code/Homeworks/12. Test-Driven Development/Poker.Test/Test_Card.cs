// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test_Card.cs" company="">
//   
// </copyright>
// <summary>
//   The test_ card.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The test_ card.
    /// </summary>
    [TestClass]
    public class Test_Card
    {
        /// <summary>
        /// The test_ two hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_TwoHearts_ValidValue()
        {
            var card = new Card(CardFace.Two, CardSuit.Hearts);
            Assert.AreEqual("2♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ three hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_ThreeHearts_ValidValue()
        {
            var card = new Card(CardFace.Three, CardSuit.Hearts);
            Assert.AreEqual("3♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ four hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_FourHearts_ValidValue()
        {
            var card = new Card(CardFace.Four, CardSuit.Hearts);
            Assert.AreEqual("4♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ five hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_FiveHearts_ValidValue()
        {
            var card = new Card(CardFace.Five, CardSuit.Hearts);
            Assert.AreEqual("5♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ six hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_SixHearts_ValidValue()
        {
            var card = new Card(CardFace.Six, CardSuit.Hearts);
            Assert.AreEqual("6♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ seven hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_SevenHearts_ValidValue()
        {
            var card = new Card(CardFace.Seven, CardSuit.Hearts);
            Assert.AreEqual("7♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ eight hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_EightHearts_ValidValue()
        {
            var card = new Card(CardFace.Eight, CardSuit.Hearts);
            Assert.AreEqual("8♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ nine hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_NineHearts_ValidValue()
        {
            var card = new Card(CardFace.Nine, CardSuit.Hearts);
            Assert.AreEqual("9♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ ten hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_TenHearts_ValidValue()
        {
            var card = new Card(CardFace.Ten, CardSuit.Hearts);
            Assert.AreEqual("10♥", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ jack diamonds_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_JackDiamonds_ValidValue()
        {
            var card = new Card(CardFace.Jack, CardSuit.Diamonds);
            Assert.AreEqual("J♦", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ queen clubs_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_QueenClubs_ValidValue()
        {
            var card = new Card(CardFace.Queen, CardSuit.Clubs);
            Assert.AreEqual("Q♣", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ king spades_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_KingSpades_ValidValue()
        {
            var card = new Card(CardFace.King, CardSuit.Spades);
            Assert.AreEqual("K♠", card.ToString(), "Not valid card!" + card);
        }

        /// <summary>
        /// The test_ ace hearts_ valid value.
        /// </summary>
        [TestMethod]
        public void Test_AceHearts_ValidValue()
        {
            var card = new Card(CardFace.Ace, CardSuit.Hearts);
            Assert.AreEqual("A♥", card.ToString(), "Not valid card!" + card);
        }
    }
}