using System;
using NUnit.Framework;

namespace PokerHands.Tests
{
    [TestFixture]
    public class PokerHandsTests
    {
        //[TestCase("7D", "2S", "Player One Wins")]
        //[TestCase("2C", "7C", "Player Two Wins")]
        //[TestCase("9D", "4C", "Player One Wins")]
        //[TestCase("4C", "9D", "Player Two Wins")]
        //[TestCase("4S", "AS", "Player Two Wins")]
        //public void ShouldSayWhichPlayerWins(string playerOneCards, string playerTwoCards, string expectedResult)
        //{
        //    var winningHand = new Hands();
        //    string result = winningHand.GetWinningHand(playerOneCards, playerTwoCards);
        //    Assert.That(result, Is.EqualTo(expectedResult));
        //}

        [TestCase("2H", 2)]
        [TestCase("3H", 3)]
        [TestCase("4S", 4)]
        [TestCase("5H", 5)]
        [TestCase("6D", 6)]
        [TestCase("7H", 7)]
        [TestCase("8S", 8)]
        [TestCase("9H", 9)]
        [TestCase("10S", 10)]
        [TestCase("JD ", 11)]
        [TestCase("QC", 12)]
        [TestCase("KD", 13)]
        [TestCase("AC", 14)]
        public void ShouldReturnValueForCard(string cardAsString, int expectedResult)
        {
            Card card = new Card(cardAsString);
            Assert.That(card.FaceValue, Is.EqualTo(expectedResult));
        }

        [TestCase("3D,4C,8D,9H,AS", 14)]
        [TestCase("3S,KH,4S, 9D,QH ", 13)]
        [TestCase("3S,10H ", 10)]
        public void ShouldReturnTheHighestCardFromAHand(string hand, int expectedResult)
        {
            Hand myHand = new Hand(hand);
            int result = myHand.GetHighestCard().FaceValue;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase("3H,7C,KD,QH,4H", "2C,8S,AS,6H,5C", "Player Two Wins")]
        [TestCase("3H,7C,KD,QH,4H", "2C,KS,JS,6H,5C", "Player One Wins")]
        [TestCase("4H,7C,KD,JH,AS", "3H,7C,KD,JH,AS", "Player One Wins")]
        [TestCase("3H,7C,KD,JH,AS", "3H,7C,KD,JH,AS", "It is a draw")]
        [TestCase("4H,7C,KD,JH,AS", "3H,7C,QD,JH,10S","Player One Wins")]
        public void ShouldReturnWhichHandHasTheHighestCard(string hand1, string hand2, string expectedResult)
        {
            Hand playerOneHand = new Hand(hand1);
            Hand playerTwoHand = new Hand(hand2);
            Hands allCards = new Hands();
            string finalResult = allCards.GetWinningHand(playerOneHand, playerTwoHand);
            Assert.That(finalResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ShouldRemoveACard()
        {
            Card myCard = new Card("7H"); 
            Hand myHand = new Hand("7H");
            myHand.RemoveCard(myCard);
            Assert.That(myHand.Count, Is.EqualTo(0));
        }


//        [TestCase("7H,7C,KD,JH,AS", 1)]
//        [TestCase("7H,7C,7D,JH,AS", 3)]
//        [TestCase("7H,7C,7D,7S,AS", 7)]
//        [TestCase("7H,7C,7D,6S,6D", 6)]
//        //[TestCase("7H,7C,8D,6S,6D", 2)]
//        public void ShouldResturnHandQuality(string hand, int expectedResult)
//        {
//            var myHand = new Hand(hand);
//            var result = myHand.GetHandQuality();
//            Assert.That(result, Is.EqualTo(expectedResult));
//        }
        [Test]
        public void ShouldReturnHandQuality()
        {
            Hand myHand = new Hand("7H,7C,KD,JH,AS");
            Assert.That(myHand.GetHandQuality(), Is.EqualTo(1));
        }

        [Test]
        public void ShouldConvertHandStringIntoAHandOfOneCard()
        {
            var hand = new Hand("7H");
            Assert.That(hand.Count, Is.EqualTo(1));
            Assert.That(hand[0].Suit, Is.EqualTo('H'));
            Assert.That(hand[0].FaceValue, Is.EqualTo(7));
        }

        [TestCase("7H,9C", 2)]
        [TestCase(" 7H, 9C ", 2)]
        [TestCase("7H, 9C, 8C, AS, KD", 5)]
        public void ShouldConvertHandStringIntoAHand(string hand, int numberOfCards)
        {
            
            Hand cards = new Hand(hand);
            Assert.That(cards.Count, Is.EqualTo(numberOfCards));
            Assert.That(cards[0].Suit, Is.EqualTo('H'));
            Assert.That(cards[0].FaceValue, Is.EqualTo(7));
            Assert.That(cards[1].Suit, Is.EqualTo('C'));
            Assert.That(cards[1].FaceValue, Is.EqualTo(9));
        }
    }
}
