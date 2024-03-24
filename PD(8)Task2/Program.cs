using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Hand hand = new Hand();

            // Deal 5 cards to hand as pocker hand
            for (int i = 0; i < 5; i++)
            {
                hand.AddCard(deck.DealCard());
            }

            Console.WriteLine("Cards in Hand are as follow:");
            for (int i = 0; i < hand.GetCardCount(); i++)
            {
                Console.WriteLine(hand.GetCard(i));
            }
            Console.ReadKey();
        }
    }
}
