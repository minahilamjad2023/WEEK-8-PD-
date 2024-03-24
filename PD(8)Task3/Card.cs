using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task3
{
    internal class Card
    {
        private int value;
        private int suit;
        public void SetValue(int value)
        {
            this.value = value;
        }
        public int GetValue()
        {
            return this.value;
        }
        public void SetSuit(int suit)
        {
            this.suit = suit;
        }
        public int GetSuit()
        {
            return this.suit;
        }
        public Card(int theValue, int theSuit)
        {
            value = theValue;
            suit = theSuit;
        }

        public string GetSuitAsString()
        {
            string[] suits = { "Clubs", "Diamonds", "Spades", "Hearts" };
            return suits[suit - 1];
        }

        public string GetValueAsString()
        {
            if (value >= 2 && value <= 10)
            {
                return value.ToString();
            }
            else
            {
                switch (value)
                {
                    case 1:
                        return "Ace";
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                    default:
                        return "Invalid Value";
                }
            }
        }

        public override string ToString()
        {
            return $"{GetValueAsString()} of {GetSuitAsString()}";
        }
    }
}
