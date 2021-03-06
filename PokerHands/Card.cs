﻿using System;
using System.Collections.Generic;

namespace PokerHands
{
    public class Card : IComparable<Card>
    {
        private static readonly Dictionary<string, int> cardValues = new Dictionary<string, int>()
        {
            {"2", 2},
            {"3", 3},
            {"4", 4},
            {"5", 5},
            {"6", 6},
            {"7", 7},
            {"8", 8},
            {"9", 9},
            {"10", 10},
            {"J", 11},
            {"Q", 12},
            {"K", 13},
            {"A", 14}
          };     
 
        public Card(string card)
        {
            Suit = GetCardSuit(card);
            FaceValue = GetCardValue(card);
        }

        private char GetCardSuit(string card)
        {
            card = card.Trim();
            return char.ToUpper(card[card.Length - 1]);
        }

        private int GetCardValue(string card)
        {
            card = card.Trim();
            return cardValues[card.Remove(card.Length - 1)];
        }

        //public int SortByFaceValueAscending(string faceValue1, string faceValue2)
        //{
        //    return faceValue1.CompareTo(faceValue2);
        //}

        public int CompareTo(Card compareCard)
        {
            return compareCard == null ? 1 : FaceValue.CompareTo(compareCard.FaceValue);
        }

        public override bool Equals(object obj)
        {
            var that = obj as Card;

            return that != null && (FaceValue == that.FaceValue && Suit == that.Suit);
        }

        public char Suit { get; internal set; }
        public int FaceValue { get; internal set; }
    }
}