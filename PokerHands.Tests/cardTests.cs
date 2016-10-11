using NUnit.Framework;

namespace PokerHands.Tests
{
    [TestFixture]
    public class cardTests
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
            Assert.That(card1.Equals(card2),Is.EqualTo(true));
        }
        [Test]
        public void ShouldSayIfTwoCardsAreDifferent()
        {
            var card1 = new Card("7H");
            var card2 = new Card("9C");
            Assert.That(card1.Equals(card2),Is.EqualTo(false));
        }

        [Test]
        public void test()
        {
            var card = new Card("7H");
            var anotherCard = card;
            Assert.That(card.Equals(anotherCard), Is.EqualTo(true));

        }


    }
}
