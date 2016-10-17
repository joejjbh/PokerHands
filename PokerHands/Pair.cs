namespace PokerHands
{
    public class Pair : XOfAKind , IEvaluateHands
    {
        private const int NumberOfMatchingCards = 2;

        public bool IsTypeOf(Hand theHand)
        {
            return CheckXOfAKind(theHand, NumberOfMatchingCards);
        }

        public int HandValue => 1;
    }
}