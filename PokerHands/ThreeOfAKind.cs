namespace PokerHands
{
    public class ThreeOfAKind : XOfAKind, IEvaluateHands
    {
        private const int NumberOfMatchingCards = 3;


        public bool IsTypeOf(Hand hand)
        {
            return CheckXOfAKind(hand, NumberOfMatchingCards);
        }

        public int HandValue => 3;
    }
}
