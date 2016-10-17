namespace PokerHands
{
    public interface IEvaluateHands
    {
        bool IsTypeOf(Hand hand);

        int HandValue { get; }
    }
}