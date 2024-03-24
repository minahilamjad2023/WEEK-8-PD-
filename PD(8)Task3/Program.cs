using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a BlackjackHand
            BlackJackHand hand = new BlackJackHand();

            // Add some cards to the hand
            hand.AddCard(new Card(1, 1)); // Ace of Clubs
            hand.AddCard(new Card(10, 2)); // 10 of Diamonds
            hand.AddCard(new Card(5, 3)); // 5 of Spades

            // Calculate and print the Blackjack value of the hand
            Console.WriteLine("Blackjack Value: " + hand.GetBlackjackValue());
            Console.ReadKey();
        }
    }
}
