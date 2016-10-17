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
            var result = flush.IsTypeOf(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfStraight()
        {
            Hand theHand = new Hand("7H, 8D, 9H, 10S, JH");
            Straight straight = new Straight();
            var result = straight.IsTypeOf(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfStraightFlush()
        {
            Hand theHand = new Hand("7H, 8H, 9H, 10H, JH");
            StraightFlush sFlush = new StraightFlush();
            var result = sFlush.IsTypeOf(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfFourOfAKind()
        {
            Hand theHand = new Hand("8D, 7D, 7S, 7C, 7H");
            FourOfAKind fOaKind = new FourOfAKind();
            var result = fOaKind.IsTypeOf(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfFullHouse()
        {
            Hand theHand = new Hand("7H,7D,7S,6H,6S");
            FullHouse fHouse = new FullHouse();
            var result = fHouse.IsTypeOf(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldReturnFalseIfCountOfCardsIsLessThan4()
        {
            var myHand = new Hand("7H, 7C, 7S");
            var result = new FourOfAKind().IsTypeOf(myHand);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void ShouldSayIfThreeOfAKind()
        {
            Hand theHand = new Hand("7H, 4D, 8S, 7C, 7H");
            ThreeOfAKind tOaKind = new ThreeOfAKind();
            var result = tOaKind.IsTypeOf(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfPair()
        {
            Hand theHand = new Hand("6H, 9D, 9S, JC, 6H");
            Pair pair = new Pair();
            var result = pair.IsTypeOf(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [TestCase("7H,8H,9H,10H,JH", 8)]
        [TestCase("7H,7S,7D,7C,JH", 7)]
        [TestCase("7H,7D,7S,6H,6S", 6)]
        [TestCase("7H,10H,AH,6H,2H", 5)]
        [TestCase("7H,8C,9H,10H,JH", 4)]
        [TestCase("7H,7C,7S,6H,2H", 3)]
        // need to create and add TwoPair
        [TestCase("7H,7D,AH,6H,2H", 1)]
        [TestCase("7H,5C,AH,10H,JS", 0)]
        public void ShouldSayHightestPossibleHand(string hand, int handQuality)
        {
            Hand theHand = new Hand(hand);
            BestHand bestHand = new BestHand();
            var result = bestHand.findBestHand(theHand);
            Assert.That(result, Is.EqualTo(handQuality));

        }
    }
}
