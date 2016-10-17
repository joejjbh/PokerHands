namespace PokerHands
{
    public class Hands
    {
        public string GetWinningHand(Hand playerOneCards, Hand playerTwoCards)
        {
            BestHand playerOneBestHand = new BestHand();
            BestHand playerTwoBestHand = new BestHand();
            var playerOneHandValue = playerOneBestHand.FindBestHand(playerOneCards);
            var playerTwoHandValue = playerTwoBestHand.FindBestHand(playerTwoCards);

            if (playerOneHandValue == playerTwoHandValue)
            {
                return "It is a draw";
            }
            if (playerOneHandValue > playerTwoHandValue)
                return "Player One Wins";
            return "Player Two Wins";
        }
    }
}


//            if (playerOneHighestCard.FaceValue == playerTwoHighestCard.FaceValue)
//            {
//                playerOneCards.RemoveCard(playerOneHighestCard);
//                playerTwoCards.RemoveCard(playerTwoHighestCard);
//                if (playerOneCards.Count == 0)
//                {
//                    return "It is a draw";
//                }
//                return GetWinningHand(playerOneCards, playerTwoCards);
//            }
//
//            if (playerOneHighestCard.FaceValue > playerTwoHighestCard.FaceValue)
//                return "Player One Wins";
//
//            return "Player Two Wins";
//        }
//    }
