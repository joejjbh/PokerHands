using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class ThreeOfAKind
    {
        public bool CheckIfThreeOfAKind(Hand theHand)
        {
            var sameAsFirstCard = 1;
            var sameAsSecondCard = 1;
            var sameAsThirdCard = 1;
            var valueOfFirstCard = theHand[0].FaceValue;
            var valueOfSecondCard = theHand[1].FaceValue;
            var valueOfThirdCard = theHand[2].FaceValue;
            for (var index = 0; index < theHand.Count; index++)
            {
                var value = theHand[index].FaceValue;
                if (valueOfFirstCard == value && index != 0)
                {
                    sameAsFirstCard += 1;
                }
                if (valueOfSecondCard == value && index != 1)
                {
                    sameAsSecondCard += 1;
                }
                if (valueOfThirdCard == value && index != 2)
                {
                    sameAsThirdCard += 1;
                }
            }
            if (sameAsFirstCard == 3 || sameAsSecondCard == 3 || sameAsThirdCard == 3)
                return true;
            return false;
        }
    }
}
