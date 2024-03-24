using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task2
{
    internal class Deck:Hand
    {
        private List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public int CardsLeft()
        {
            return cards.Count;
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                return null;
            }
            else
            {
                Card card = cards[0];
                cards.RemoveAt(0);
                return card;
            }
        }
    }
}
