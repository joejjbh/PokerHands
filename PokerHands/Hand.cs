using System.Collections;
using System.Collections.Generic;

namespace PokerHands
{
//    public class temp_delete
//    {
//        private void DOSOMETHING()
//        {
//            var hand = new Hand("7h, 7c, 7s, 7d, JH");
//
//            var secondHand = new List<Card>()
//            {
//                new Card("8h"), 
//                new Card("9h") ,
//                new Card("10h") ,
//                new Card("6h") ,
//                new Card("5h") 
//                };
//
//            var otherHand = new Hand(secondHand);
//        }
//    }

    public class Hand : IEnumerator, IEnumerable
    {
        private List<Card> _cards = new List<Card>();
        int position = -1;

        public Hand(string hand)
        {
            SeperateHand(hand);
        }

        private Hand(List<Card> cards)
        {
            _cards = cards;
        }

        public int Count => _cards.Count;

        public Card this[int index] => _cards[index];

        private void SeperateHand(string stringRepresentationOfHandOfCards)
        {
            var delimiterChars = ',';
            var stringCards = stringRepresentationOfHandOfCards.Split(delimiterChars);
            foreach (var individualCardAsString in stringCards)
            {
                _cards.Add(new Card(individualCardAsString));
            }
        }

        public void SortCards()
        {
            _cards.Sort();
        }

        public Card GetHighestCard()
        {
            SortCards();
            
            return _cards[_cards.Count - 1];
        }

        public void RemoveCard(Card myCard)
        {
            _cards.Remove(myCard);
        }

        public bool MoveNext()
        {
            position++;
            return (position < _cards.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return new Hand(_cards);
        }

        public object Current => _cards[position];

        //        public int GetHandQuality()
        //        {
        //            if ((cards[0].FaceValue == cards[1].FaceValue) || (cards[0].FaceValue == cards[2].FaceValue))
        //                return 1;
        //            return 0;
        //        }

        
    }
}