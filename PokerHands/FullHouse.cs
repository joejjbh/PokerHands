namespace PokerHands
{
    public class FullHouse : IEvaluateHands
    {
        public bool IsTypeOf(Hand theHand)
       
        {
            var tOAKind = new ThreeOfAKind();
            var pair = new Pair();
            var isTOAKind = tOAKind.IsTypeOf(theHand);
            var isPair = pair.IsTypeOf(theHand);
            return isPair && isTOAKind;
        }

        public int HandValue => 6;
    }
}