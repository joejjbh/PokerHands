using NUnit.Framework;

namespace PokerHands.Tests
{
    [TestFixture]
    class HandQualityTests
    {
        [Test]
        public void ShouldSayIfAllCardsAreTheSameSuit()
        {
            Hand theHand = new Hand("7H, 8H, 10H, JH, 4H");
            Flush flush = new Flush();
            var result = flush.CheckIfFlush(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfStraight()
        {
            Hand theHand = new Hand("7H, 8D, 9H, 10S, JH");
            Straight straight = new Straight();
            var result = straight.CheckIfStraight(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfStraightFlush()
        {
            Hand theHand = new Hand("7H, 8H, 9H, 10H, JH");
            StraightFlush sFlush = new StraightFlush();
            var result = sFlush.CheckIfStraightFlush(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfFourOfAKind()
        {
            Hand theHand = new Hand("8D, 7D, 7S, 7C, 7H");
            FourOfAKind fOAKind = new FourOfAKind();
            var result = fOAKind.CheckIfFourOfAKind(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldReturnFalseIfCountOfCardsIsLessThan4()
        {
            var myHand = new Hand("7H, 7C, 7S");
            var result = new FourOfAKind().CheckIfFourOfAKind(myHand);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void ShouldSayIfThreeOfAKind()
        {
            Hand theHand = new Hand("7H, 4D, 8S, 7C, 7H");
            ThreeOfAKind tOAKind = new ThreeOfAKind();
            var result = tOAKind.CheckIfThreeOfAKind(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfPair()
        {
            Hand theHand = new Hand("6H, 9D, 9S, JC, 6H");
            Pair pair = new Pair();
            var result = pair.CheckIfPair(theHand);
            Assert.That(result, Is.EqualTo(true));
        }
    }
}
