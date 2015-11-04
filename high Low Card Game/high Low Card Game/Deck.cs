using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Deck
    {
        public List<Card> CardDeck;

        public Deck()
        {
            CardDeck = new List<Card>();
        }
        public Deck(int pr, int ps) : this()
        {
            for (int i = 0; i < pr; i++)
            {
                for (int j = 0; j < ps; j++)
                {
                    CardDeck.Add(new Card(i, j));
                }
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < CardDeck.Count; i++)
            {
                var j = random.Next(i, CardDeck.Count);
                var temp = CardDeck[i];
                CardDeck[i] = CardDeck[j];
                CardDeck[j] = temp;
            }
        }

        public Card CardTopDeck()
        {
            return CardDeck[this.CardDeck.Count - 1]; // -1 because position Start 0 but count start 1
        }
        public Card CardAt(int position)
        {
            return CardDeck[this.CardDeck.Count - (1 + position)]; // -1 because position Start 0 but count start 1
        }
        public Card LastCard()
        {
            return CardDeck[0];
        }
        public void RemoveTopCard()
        {
            CardDeck.RemoveAt(this.CardDeck.Count - 1);
        }
    }
}
