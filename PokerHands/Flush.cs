namespace PokerHands
{
    public class Flush: IEvaluateHands
    {
        public bool IsTypeOf(Hand theHand)
        {
            var suitOfFirstCard = theHand[0].Suit;
            for (var index = 1; index < theHand.Count; index++)
            {
                var suit = theHand[index].Suit;
                if (suitOfFirstCard != suit)
                    return false;
            }
            return true;
        }
        public int HandValue => 5;
    }
}