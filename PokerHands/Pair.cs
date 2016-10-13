using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class Pair
    {
        public bool CheckIfPair(Hand theHand)
        {
//            var sameCard = 1;
//            var valueOfFirstCard = theHand[0].FaceValue;
//            var valueOfSecondCard = theHand[1].FaceValue;
//            var valueOfThirdCard = theHand[2].FaceValue;
//            var valueOfFourthCard = theHand[3].FaceValue;
//            for (var index = 0; index < theHand.Count; index++)
//            {
//                var value = theHand[index].FaceValue;
//                sameCard += 1;
//                if (valueOfFirstCard != value && valueOfSecondCard != value && 
//                    valueOfThirdCard != value && valueOfFourthCard != value && sameCard < 2)
//                    return false;
//            }
//            return true;

            var sameCard = 1;
            var indexOfCard = 0;
            var numberOfPairs = 0;
            var valueOfCard = theHand[0].FaceValue;
            for (var index = 0; index < theHand.Count; index++)
            {
                var value = theHand[index].FaceValue;
                if (valueOfCard == value && index != indexOfCard)
                {
                    sameCard += 1;

                    if (sameCard == 2)
                    {
                        numberOfPairs += 1;
                    }
                    if (index == theHand.Count - 1 && (sameCard < 2 || numberOfPairs == 1))
                    {
                        sameCard = 1;
                        indexOfCard += 1;
                    }           
                }
            }
            if (numberOfPairs == 1)
                return true;
            return false;
        }
    }
}
