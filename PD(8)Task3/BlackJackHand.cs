using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task3
{
    internal class BlackJackHand:Hand
    {
        public int GetBlackjackValue()
        {
            int val = 0; // The value computed for the hand.
            bool ace = false; // This will be set to true if the hand contains an ace.
            int cardsCount = GetCardCount(); // Number of cards in the hand.

            // Count the value of the hand
            for (int i = 0; i < cardsCount; i++)
            {
                Card card = GetCard(i);
                int cardValue = card.GetValue();

                // Face cards are worth 10
                if (cardValue >= 10)
                {
                    val += 10;
                }
                // Ace can be worth 1 or 11 depending on the total value of the hand
                else if (cardValue == 1)
                {
                    ace = true;
                    val += 11;
                }
                else
                {
                    val += cardValue;
                }
            }

            // If the hand contains an Ace and the total value is over 21, adjust Ace's value to 1
            if (ace && val > 21)
            {
                val -= 10;
            }

            return val;
        }
    }
}
