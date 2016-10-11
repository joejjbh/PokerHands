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
            var sameCard = 1;
            var valueOfFirstCard = theHand[0].FaceValue;
            var valueOfSecondCard = theHand[1].FaceValue;
            var valueOfThirdCard = theHand[2].FaceValue;
            for (var index = 0; index < theHand.Count; index++)
            {
                var value = theHand[index].FaceValue;
                sameCard += 1;
                if (valueOfFirstCard != value && valueOfSecondCard != value && valueOfThirdCard != value && sameCard < 3)
                    return false;
            }
            return true;
        }
    }
}
