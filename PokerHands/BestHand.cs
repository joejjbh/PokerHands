using System.Collections.Generic;

namespace PokerHands
{
    public class BestHand
    {
        public int findBestHand(Hand hand)
        {
            List<IEvaluateHands> evaluators = new List<IEvaluateHands>();
            evaluators.Add(new StraightFlush());
            evaluators.Add(new FourOfAKind());
            evaluators.Add(new FullHouse());
            evaluators.Add(new Flush());
            evaluators.Add(new Straight());
            evaluators.Add(new ThreeOfAKind());
            evaluators.Add(new Pair());

            foreach (var evaluator in evaluators)
            {
                if (evaluator.IsTypeOf(hand))
                    return evaluator.HandValue;
            }
            return 0;



//            IEvaluateHands evaluator = new FourOfAKind();
           

            return -1;

        }

//        public int findBestHand(Hand hand)
//        {
//            StraightFlush sFlush = new StraightFlush();
//            if (sFlush.CheckIfStraightFlush(hand))
//                return 8;
//            FourOfAKind fOAKind = new FourOfAKind();
//            if (fOAKind.CheckIfFourOfAKind(hand))
//                return 7;
//            Flush flush = new Flush();
//            if (flush.CheckIfFlush(hand))
//                return 5;
//            Straight straight = new Straight();
//            if (straight.CheckIfStraight(hand))
//                return 4;
//            ThreeOfAKind tOAKind = new ThreeOfAKind();
//            if (tOAKind.CheckIfThreeOfAKind(hand))
//                return 3;
//            Pair pair = new Pair();
//            if (pair.CheckIfPair(hand))
//                return 1;
//            return 0;
//        }
    }
}