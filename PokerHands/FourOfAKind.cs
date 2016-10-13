using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class FourOfAKind
    {
        public int sameCard = 1;
        public int indexOfCard = 0;

        public bool CheckIfFourOfAKind(Hand theHand)
        {
            while (indexOfCard < theHand.Count - 1)
            {
                var valueOfCard = theHand[indexOfCard].FaceValue;

                for (var index = 0; index < theHand.Count; index++)
                {
                    var value = theHand[index].FaceValue;
                    if (valueOfCard == value && index != indexOfCard)
                    {
                        sameCard += 1;

                        if (index == theHand.Count - 1 && sameCard < 4)
                        {
                            sameCard = 1;
                            indexOfCard += 1;
                            index = 0;
                        }

                    }
                }
            }
            if (sameCard == 4)
                return true;
            return false;
}


//            var sameAsFirstCard = 1;
//            var sameAsSecondCard = 1;
//            var valueOfFirstCard = theHand[0].FaceValue;
//            var valueOfSecondCard = theHand[1].FaceValue;
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
//            }
//            if (sameAsFirstCard == 4 || sameAsSecondCard == 4)
//                return true;
//            return false;
        }

    }

