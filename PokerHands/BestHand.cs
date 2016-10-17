using System.Collections.Generic;

namespace PokerHands
{
    public class BestHand
    {
        public int FindBestHand(Hand hand)
        {
            var evaluators = BuildHandEvaluators();

            foreach (var evaluator in evaluators)
            {
                if (evaluator.IsTypeOf(hand))
                    return evaluator.HandValue;
            }
            return 0;
        }

        private static IEnumerable<IEvaluateHands> BuildHandEvaluators()
        {
            var evaluators = new List<IEvaluateHands>
            {
                new StraightFlush(),
                new FourOfAKind(),
                new FullHouse(),
                new Flush(),
                new Straight(),
                new ThreeOfAKind(),
                new Pair()
            };
            return evaluators;
        }
    }
}