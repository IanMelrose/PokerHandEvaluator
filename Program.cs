using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hand_Evaluator
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck theDeck = new Deck();
            theDeck.Shuffle();
        }
    }
}
