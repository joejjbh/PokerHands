using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            StraightFlush sFlush = new StraightFlush();
            var result = sFlush.CheckIfFlush(theHand);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShouldSayIfStraight()
        {
            Hand theHand = new Hand("7H, 8H, 9H, 10H, JH");
            StraightFlush sFlush = new StraightFlush();
            var result = sFlush.CheckIfStraight(theHand);
            Assert.That(result, Is.EqualTo(true));
        }
    }
}
