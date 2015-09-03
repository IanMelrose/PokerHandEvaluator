using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hand_Evaluator
{
    class Card
    {
        private String suitName;                    //Suit names (Hearts, Spades, Diamonds, Clubs)
        private String rankName;                    //Rank names (2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, Ace)
        private int suitValue;                      //Suit values (2, 3, 5, 7) - Assigning each rank a prime number as a sort of primary key value
        private int rankValue;                      //Rank values (2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41)

        /// <summary>
        /// Generic constructor for our card class, assigns the relvant values and names to the card
        /// </summary>
        /// <param name="suitName"></param>
        /// <param name="rankName"></param>
        /// <param name="suitValue"></param>
        /// <param name="rankValue"></param>
        public Card(String suitName, String rankName, int suitValue, int rankValue)
        {
            this.suitName = suitName;
            this.suitValue = suitValue;
            this.rankName = rankName;
            this.rankValue = rankValue;
        }

        public String SuitName
        {
            get { return suitName; }
            set { suitName = value; }
        }

        public String RankName
        {
            get { return rankName; }
            set { rankName = value; }
        }

        public int SuitValue 
        { 
            get { return suitValue; } 
            set { suitValue = value; } 
        }

        public int RankValue
        {
            get { return rankValue; }
            set { rankValue = value; }
        }
    }
}
