﻿using System.Collections.Generic;

namespace PokerHands
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public Hand(string hand)
        {
            SeperateHand(hand);
        }

        public int Count
        {
            get
            {
                return cards.Count;
            } 
        }

        public Card this[int index]
        {
            get
            {
                return cards[index];
            }
        }

        private void SeperateHand(string stringRepresentationOfHandOfCards)
        {
            char delimiterChars = ',';
            string[] stringCards = stringRepresentationOfHandOfCards.Split(delimiterChars);
            foreach (string individualCardAsString in stringCards)
            {
                cards.Add(new Card(individualCardAsString));
            }
        }

        public void SortCards()
        {
            cards.Sort();
        }

        public Card GetHighestCard()
        {
            SortCards();
            
            return cards[cards.Count - 1];
        }

        public void RemoveCard(Card myCard)
        {
            cards.Remove(myCard);
        }

        public int GetHandQuality()
        {
            if ((cards[0].FaceValue == cards[1].FaceValue) || (cards[0].FaceValue == cards[2].FaceValue))
                return 1;
            return 0;
        }
    }
}