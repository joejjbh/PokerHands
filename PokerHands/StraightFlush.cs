namespace PokerHands
{
    public class StraightFlush
    {
        public bool CheckIfStraightFlush(Hand theHand)
        {
            Straight straight = new Straight();
            Flush flush = new Flush();
            bool isStraight = straight.CheckIfStraight(theHand);
            bool isFlush = flush.CheckIfFlush(theHand);
            if (isStraight && isFlush)
                return true;
            return false;
        }
    }
}