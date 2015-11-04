using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Card
    {
        private int _rank;
        private int _suit;
        private string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        private string[] suits = { "spades", "hearts", "diamonds", "clubs" };

        public int Rank
        {
            get;
            set;
        }
        public int Suit
        {
            get;
            set;
        }
        public Card()
        {
            Rank = 0;
            Suit = 0;
        }
        public Card(int v, int s)
        {
            Rank = v;
            Suit = s;
        }
        public override string ToString()
        {
            return string.Format(ranks[Rank] + " of " + suits[Suit]);
        }
    }
}
