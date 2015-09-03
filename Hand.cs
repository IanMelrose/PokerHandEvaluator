using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hand_Evaluator
{
    class Hand
    {
        private List<Card> theHand;

        public Hand()
        {
            theHand = new List<Card>();
        }

        public void AddCard(Card theCard)
        {
            theHand.Add(theCard);
        }

        public List<Card> GetCards()
        {
            return theHand;
        }
    }
}
