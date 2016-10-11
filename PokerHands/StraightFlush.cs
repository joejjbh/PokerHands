using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class StraightFlush
    {
        public bool CheckIfFlush(Hand theHand)
        {
            var suitOfFirstCard = theHand[0].Suit;
            for (var index = 1; index < theHand.Count; index++)
            {
                var suit = theHand[index].Suit;
                if (suitOfFirstCard != suit)
                    return false;
            }
            return true;
        }

        public bool CheckIfStraight(Hand theHand)
        {
            theHand.SortCards();
            int valueOfLastCard = theHand[theHand.Count - 1].FaceValue;
            for (var index = 3; index >= 0; index--)
            {
                var value = theHand[index].FaceValue;
                if (value != valueOfLastCard - 1)
                {
                    return false;
                }
                valueOfLastCard = value;
            }
            return true;
            
        }

    }
}
