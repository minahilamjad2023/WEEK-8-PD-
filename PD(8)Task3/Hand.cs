using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task3
{
    internal class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void Clear()
        {
            cards.Clear();
        }

        public void AddCard(Card c)
        {
            cards.Add(c);
        }

        public void RemoveCard(Card c)
        {
            cards.Remove(c);
        }

        public void RemoveCard(int position)
        {
            cards.RemoveAt(position);
        }

        public int GetCardCount()
        {
            return cards.Count;
        }

        public Card GetCard(int position)
        {
            if (position >= 0 && position < cards.Count)
            {
                return cards[position];
            }
            else
            {
                return null;
            }
        }

        public void SortBySuit()
        {
            cards.Sort((c1, c2) => c1.GetSuitAsString().CompareTo(c2.GetSuitAsString()));
        }

        public void SortByValue()
        {
            cards.Sort((c1, c2) =>
            {
                if (c1.GetValueAsString() == c2.GetValueAsString())
                {
                    return c1.GetSuitAsString().CompareTo(c2.GetSuitAsString());
                }
                else
                {
                    return c1.GetValueAsString().CompareTo(c2.GetValueAsString());
                }
            });
        }
    }
}
