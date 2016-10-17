using System.Collections.Generic;
using NUnit.Framework;

namespace PokerHands.Tests
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void ShouldSeparteCardIntoFaceValueSAndSuit()
        {
            var card = new Card("7H");
            Assert.That(card.FaceValue, Is.EqualTo(7));
            Assert.That(card.Suit, Is.EqualTo('H'));
        }

        [Test]
        public void ShouldConvertSuitToUppercase()
        {
            var card = new Card("7h");
            Assert.That(card.FaceValue, Is.EqualTo(7));
            Assert.That(card.Suit, Is.EqualTo('H'));
        }

        [Test]
        public void ShouldSayIfTwoCardsAreTheSame()
        {
            var card1 = new Card("7H");
            var card2 = new Card("7H");
            Assert.That(card1.Equals(card2), Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfTwoCardsAreDifferent()
        {
            var card1 = new Card("7H");
            var card2 = new Card("9C");
            Assert.That(card1.Equals(card2), Is.EqualTo(false));
        }

        [Test]
        public void Test()
        {
            var card = new Card("7H");
            var anotherCard = card;
            Assert.That(card.Equals(anotherCard), Is.EqualTo(true));
        }

//        [Test]
//        public void NewTest()
//        {
//            Pair x = new Pair();
//            IEvaluateHands y = new Pair();
////          IEvaluateHands y = new Pair();
////          IEvaluateHands y = new Pair();
//
//            List<IEvaluateHands> evaluators = new List<IEvaluateHands>();
////          evaluators.Add();
//
//            var hand = new Hand("");
//            int handValue = -1;
//            foreach (var evaluator in evaluators)
//            {
//                var match = evaluator.IsTypeOf(hand);
//                if (match)
//                    handValue = evaluator.HandValue;
//            }
//
//            Assert.That(handValue, Is.EqualTo(0));
//        }
    }
}