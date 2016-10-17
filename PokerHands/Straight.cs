namespace PokerHands
{
    public class Straight: IEvaluateHands
    {
        public bool IsTypeOf(Hand theHand)
        {
            theHand.SortCards();
            var valueOfLastCard = theHand[theHand.Count - 1].FaceValue;
            for (var index = 3; index >= 0; index--)
            {
                var value = theHand[index].FaceValue;
                if (value != valueOfLastCard - 1)
                {
                    return false;
                }
                valueOfLastCard = value;
            }
            return true;
        }

        public int HandValue => 4;
    }
}