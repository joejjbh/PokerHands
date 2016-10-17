using System.Collections.Generic;
using System.Linq;

namespace PokerHands
{
    public abstract class XOfAKind
    {
        public bool CheckXOfAKind(Hand theHand, int x)
        {
            if (theHand.Count < x) return false;


            var copyOfCardsInHand = new List<Card>();
//            foreach (Card card in theHand)
//            {
//                var valueOfCardToMatch = card.FaceValue;
//                
//                var countOfMatches = theHand.Count(c => c.FaceValue == valueOfCardToMatch);
//                if (countOfMatches == x)
//                    return true;
//            }
//            return false;
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