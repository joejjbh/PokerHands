namespace PokerHands
{
    public class StraightFlush : Straight, IEvaluateHands
    {
        public bool IsTypeOf(Hand theHand)
        {
            var straight = new Straight();
            var flush = new Flush();
            var isStraight = straight.IsTypeOf(theHand);
            var isFlush = flush.IsTypeOf(theHand);
            return isStraight && isFlush;
        }

        public int HandValue => 8;
    }
}