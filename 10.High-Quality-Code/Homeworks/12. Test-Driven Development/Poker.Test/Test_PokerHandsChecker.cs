// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test_PokerHandsChecker.cs" company="">
//   
// </copyright>
// <summary>
//   The test_ poker hands checker.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Poker.Test
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     The test_ poker hands checker.
    /// </summary>
    [TestClass]
    public class Test_PokerHandsChecker
    {
        /// <summary>
        ///     The flush cards hand.
        /// </summary>
        private readonly IHand flushCardsHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs), 
                        new Card(CardFace.Two, CardSuit.Clubs), 
                        new Card(CardFace.King, CardSuit.Clubs), 
                        new Card(CardFace.Jack, CardSuit.Clubs), 
                        new Card(CardFace.Eight, CardSuit.Clubs)
                    });

        /// <summary>
        /// The four of a kind hand.
        /// </summary>
        private readonly IHand fourOfAKindHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs), 
                        new Card(CardFace.Ace, CardSuit.Diamonds), 
                        new Card(CardFace.Ace, CardSuit.Hearts), 
                        new Card(CardFace.Ace, CardSuit.Spades), 
                        new Card(CardFace.Eight, CardSuit.Clubs)
                    });

        /// <summary>
        ///     The invalid count cards hand.
        /// </summary>
        private readonly IHand invalidCountCardsHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs), 
                        new Card(CardFace.Ace, CardSuit.Diamonds), 
                        new Card(CardFace.King, CardSuit.Hearts), 
                        new Card(CardFace.King, CardSuit.Spades), 
                        new Card(CardFace.Seven, CardSuit.Diamonds), 
                        new Card(CardFace.Two, CardSuit.Diamonds)
                    });

        /// <summary>
        ///     The invalid duplicated cards hand.
        /// </summary>
        private readonly IHand invalidDuplicatedCardsHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.King, CardSuit.Spades), 
                        new Card(CardFace.King, CardSuit.Spades), 
                        new Card(CardFace.King, CardSuit.Spades), 
                        new Card(CardFace.King, CardSuit.Spades), 
                        new Card(CardFace.King, CardSuit.Spades)
                    });

        /// <summary>
        ///     The null hand.
        /// </summary>
        private readonly IHand nullHand = null;

        /// <summary>
        ///     The poker hands checker.
        /// </summary>
        private readonly PokerHandsChecker pokerHandsChecker = new PokerHandsChecker();

        /// <summary>
        ///     The valid cards hand.
        /// </summary>
        private readonly IHand validCardsHand =
            new Hand(
                new List<ICard>
                    {
                        new Card(CardFace.Ace, CardSuit.Clubs), 
                        new Card(CardFace.Ace, CardSuit.Diamonds), 
                        new Card(CardFace.King, CardSuit.Hearts), 
                        new Card(CardFace.King, CardSuit.Spades), 
                        new Card(CardFace.King, CardSuit.Clubs)
                    });

        /// <summary>
        ///     The test is valid hand_ null hand_ should throw.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestIsValidHand_NullHand_ShouldThrow()
        {
            this.pokerHandsChecker.IsValidHand(this.nullHand);
        }

        /// <summary>
        ///     The test is valid hand_ invalid count card_ should throw.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsValidHand_InvalidCountCard_ShouldThrow()
        {
            this.pokerHandsChecker.IsValidHand(this.invalidCountCardsHand);
        }

        /// <summary>
        ///     The test is valid hand_ duplicated card_ should throw.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsValidHand_DuplicatedCard_ShouldThrow()
        {
            this.pokerHandsChecker.IsValidHand(this.invalidDuplicatedCardsHand);
        }

        /// <summary>
        ///     The test is valid hand_ valid hand_ should return true.
        /// </summary>
        [TestMethod]
        public void TestIsValidHand_ValidHand_ShouldReturnTrue()
        {
            Assert.IsTrue(this.pokerHandsChecker.IsValidHand(this.validCardsHand));
        }

        /// <summary>
        ///     The test is flush_ in valid hand_ should return false.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestIsFlush_InValidHand_ShouldThrow()
        {
            this.pokerHandsChecker.IsFlush(this.nullHand);
        }

        /// <summary>
        ///     The test is flush_ not flush hand_ should return false.
        /// </summary>
        [TestMethod]
        public void TestIsFlush_NotFlushHand_ShouldReturnFalse()
        {
            Assert.IsFalse(this.pokerHandsChecker.IsFlush(this.validCardsHand));
        }

        /// <summary>
        ///     The test is flush_ valid flush hand_ should return true.
        /// </summary>
        [TestMethod]
        public void TestIsFlush_ValidFlushHand_ShouldReturnTrue()
        {
            Assert.IsTrue(this.pokerHandsChecker.IsFlush(this.flushCardsHand));
        }

        /// <summary>
        /// The test is four of a kind_ in valid hand_ should throw.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestIsFourOfAKind_InValidHand_ShouldThrow()
        {
            this.pokerHandsChecker.IsFourOfAKind(this.nullHand);
        }

        /// <summary>
        /// The test is four of a kind_ not four of a kind_ should return false.
        /// </summary>
        [TestMethod]
        public void TestIsFourOfAKind_NotFourOfAKind_ShouldReturnFalse()
        {
            Assert.IsFalse(this.pokerHandsChecker.IsFourOfAKind(this.validCardsHand));
        }

        /// <summary>
        /// The test is four of a kind_ four of a kind_ should return true.
        /// </summary>
        [TestMethod]
        public void TestIsFourOfAKind_FourOfAKind_ShouldReturnTrue()
        {
            Assert.IsTrue(this.pokerHandsChecker.IsFourOfAKind(this.fourOfAKindHand));
        }
    }
}