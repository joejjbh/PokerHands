using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class StraightFlush
    {
        public string CheckIfFlush(Hand theHand)
        {
//            foreach (Card card in theHand)
//            {
//                if (theHand.cards..GroupBy(n => n).Any(c => c.Count() == 2))
//                {
//                    
//                }
//            }
            if (theHand[0].Suit == theHand[1].Suit && theHand[1].Suit == theHand[2].Suit
                && theHand[2].Suit == theHand[3].Suit && theHand[3].Suit == theHand[4].Suit)
            {
                return "Yes";
            }
            return "No";
        }

        public string CheckIfStraight(Hand theHand)
        {
           
            return "";
        }
    }
}
