// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestDeck.cs" company="">
//   
// </copyright>
// <summary>
//   The test account.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using NUnit.Framework;

using Santase.Logic;
using Santase.Logic.Cards;

/// <summary>
/// The test account.
/// </summary>
[TestFixture]
public class TestAccount
{
    /// <summary>
    /// The big numbers.
    /// </summary>
    private static int[] BigNumbers = { 25, 50, 100, int.MaxValue };

    /// <summary>
    /// The test_ deck class initialization not to throw.
    /// </summary>
    [Test]
    public void Test_DeckClassInitializationNotToThrow()
    {
        var deck = new Deck();
    }

    /// <summary>
    /// The test_ deck class init number of cards to be 24.
    /// </summary>
    [Test]
    public void Test_DeckClassInitNumberOfCardsToBe24()
    {
        var deck = new Deck();
        Assert.AreEqual(24, deck.CardsLeft, "Invalid number of cards: " + deck.CardsLeft);
    }

    /// <summary>
    /// The test_ deck class get trump card and try to change it with the same.
    /// </summary>
    [Test]
    public void Test_DeckClassGetTrumpCardAndTryToChangeItWithTheSame()
    {
        var deck = new Deck();
        var trumpCard = deck.GetTrumpCard;
        deck.ChangeTrumpCard(trumpCard);
        Assert.AreEqual(trumpCard, deck.GetTrumpCard, "Trump card should no tbe changed");
    }

    /// <summary>
    /// The test_ deck class get next card and expect to be different.
    /// </summary>
    [Test]
    public void Test_DeckClassGetNextCardAndExpectToBeDifferent()
    {
        var deck = new Deck();
        var card = deck.GetNextCard();
        var card2 = deck.GetNextCard();
        Assert.AreNotEqual(card, card2, "Two consicative card are equal");
    }

    /// <summary>
    /// The test_ deck class get too much cards from the deck.
    /// </summary>
    [Test]
    [ExpectedException(typeof(InternalGameException))]
    public void Test_DeckClassGetTooMuchCardsFromTheDeck()
    {
        var deck = new Deck();
        var card = deck.GetNextCard();
        for (var i = 0; i < 100; i++)
        {
            card = deck.GetNextCard();
        }
    }
}