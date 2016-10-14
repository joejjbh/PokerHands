namespace PokerHands
{
    public class Hands
    {
        private int handQuality = 0;
        private const int threeOfAKind = 3;

        public string GetWinningHand(Hand playerOneCards, Hand playerTwoCards)
        {
            Card playerOneHighestCard = playerOneCards.GetHighestCard();
            Card playerTwoHighestCard = playerTwoCards.GetHighestCard();
//            int playerOneHandQuality = playerOneCards.GetHandQuality();

            if (playerOneHighestCard.FaceValue == playerTwoHighestCard.FaceValue)
            {
                playerOneCards.RemoveCard(playerOneHighestCard);
                playerTwoCards.RemoveCard(playerTwoHighestCard);
                if (playerOneCards.Count == 0)
                {
                    return "It is a draw";
                }
                return GetWinningHand(playerOneCards, playerTwoCards);
            }

            if (playerOneHighestCard.FaceValue > playerTwoHighestCard.FaceValue)
                return "Player One Wins";

            return "Player Two Wins";
        }
    }
}