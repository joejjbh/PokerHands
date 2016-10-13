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
            return XOfAKind.CheckXOfAKind(theHand, 3);
        }
    }
}
