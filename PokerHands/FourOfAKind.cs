using System;

namespace PokerHands
{
    public class FourOfAKind
    {
        public bool CheckIfFourOfAKind(Hand theHand)
        {
            return XOfAKind.CheckXOfAKind(theHand, 4);
        }
    }
}