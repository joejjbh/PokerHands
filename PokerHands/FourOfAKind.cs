namespace PokerHands
{
    public class FourOfAKind : XOfAKind, IEvaluateHands
    {
        private const int NumberOfMatchingCards = 4;

        public bool IsTypeOf(Hand hand)
        {
            return CheckXOfAKind(hand, NumberOfMatchingCards);
        }

        public int HandValue => 7;
    }
}
