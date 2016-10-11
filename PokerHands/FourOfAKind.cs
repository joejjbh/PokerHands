using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class FourOfAKind
    {
        public bool CheckIfFourOfAKind(Hand theHand)
        {
            var sameCard = 1;
            var valueOfFirstCard = theHand[0].FaceValue;
            var valueOfSecondCard = theHand[1].FaceValue;
            for (var index = 2; index < theHand.Count; index++)
            {
                var value = theHand[index].FaceValue;
                sameCard += 1;
                if (valueOfFirstCard != value && valueOfSecondCard != value && sameCard < 4)
                    return false;
            }
            return true;
        }
    
    }
}
