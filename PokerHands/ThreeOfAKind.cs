namespace PokerHands
{
    public class ThreeOfAKind
    {
        private const int numberOfMatchingCards = 3;

        public bool CheckIfThreeOfAKind(Hand theHand)
        {
            return XOfAKind.CheckXOfAKind(theHand, numberOfMatchingCards);
        }
    }
}
