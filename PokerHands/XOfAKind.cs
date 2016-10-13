using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class XOfAKind
    {
        public static bool CheckXOfAKind(Hand theHand, int x)
        {
            if (theHand.Count < x) return false;

            var copyOfCardsInHand = new List<Card>();
            for (var index = 0; index < theHand.Count; index++)
            {
                copyOfCardsInHand.Add(theHand[index]);
            }

            for (var index = 0; index < copyOfCardsInHand.Count; index++)
            {
                var valueOfCardToMatch = theHand[index].FaceValue;

                var countOfMatches = copyOfCardsInHand.Count(c => c.FaceValue == valueOfCardToMatch);
                if (countOfMatches == x)
                    return true;
            }
            return false;
        }
    }
}


//    public class XOfAKind
    //    {
    //        public bool CheckIfThreeOfAKind(Hand theHand)
    //        {
    //            var sameCard = 1;
    //            var indexOfCard = 0;
    //            var valueOfCard = theHand[0].FaceValue;
    //            for (var index = 0; index < theHand.Count; index++)
    //            {
    //                var value = theHand[index].FaceValue;
    //                if (valueOfCard == value && index != indexOfCard)
    //                {
    //                    sameCard += 1;
    //
    //                    if (index == theHand.Count - 1 && sameCard < 3)
    //                    {
    //                        sameCard = 1;
    //                        indexOfCard += 1;
    //                    }
    //                }
    //            }
    //            if (sameCard == 3)
    //                return true;
    //            return false;
    //            var sameAsFirstCard = 1;
    //            var sameAsSecondCard = 1;
    //            var sameAsThirdCard = 1;
    //            var valueOfFirstCard = theHand[0].FaceValue;
    //            var valueOfSecondCard = theHand[1].FaceValue;
    //            var valueOfThirdCard = theHand[2].FaceValue;
    //            for (var index = 0; index < theHand.Count; index++)
    //            {
    //                var value = theHand[index].FaceValue;
    //                if (valueOfFirstCard == value && index != 0)
    //                {
    //                    sameAsFirstCard += 1;
    //                }
    //                if (valueOfSecondCard == value && index != 1)
    //                {
    //                    sameAsSecondCard += 1;
    //                }
    //                if (valueOfThirdCard == value && index != 2)
    //                {
    //                    sameAsThirdCard += 1;
    //                }
    //            }
    //            if (sameAsFirstCard == 3 || sameAsSecondCard == 3 || sameAsThirdCard == 3)
    //                return true;
    //            return false;

