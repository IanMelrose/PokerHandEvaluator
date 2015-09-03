using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hand_Evaluator
{
    class Deck
    {
        private String[] rankNames = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        private String[] suitNames = { "Hearts", "Spades", "Diamonds", "Clubs" };
        private int[] rankValues = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41 };
        private int[] suitValues = { 2, 3, 5, 7 };
        private List<Card> theDeck;

        public Deck()
        {
            Card newCard;
            theDeck = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    newCard = new Card(suitNames[j], rankNames[i], suitValues[j], rankValues[i]);
                    theDeck.Add(newCard);
                }
            }
        }

        public List<Card> Shuffle()
        {
            List<Card> originalDeck = theDeck;
            List<Card> newDeck = new List<Card>();
            int counter = 0;
            Random r = new Random();

            while (originalDeck.Count > 0)               //loop until originalDeck is empty
            {
                counter = r.Next(originalDeck.Count);       //generate a number between 0 and the size of originalDeck

                newDeck.Add(originalDeck.ElementAt(counter));      //remove a card at the indicated position in originalDeck and add it to newDeck
                originalDeck.RemoveAt(counter);
            }

            return newDeck;
        }
    }
}
