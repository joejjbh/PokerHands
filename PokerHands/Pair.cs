namespace PokerHands
{
    public class Pair
    {
        private const int numberOfMatchingCards = 2;

        public bool CheckIfPair(Hand theHand)
        {
            return XOfAKind.CheckXOfAKind(theHand, numberOfMatchingCards);
        }
    }
}