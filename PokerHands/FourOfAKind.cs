namespace PokerHands
{
    public class FourOfAKind
    {
        private const int numberOfMatchingCards = 4;

        public bool CheckIfFourOfAKind(Hand theHand)
        {
            return XOfAKind.CheckXOfAKind(theHand, numberOfMatchingCards);
        }
    }
}