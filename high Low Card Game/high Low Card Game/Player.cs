using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Player
    {
        private Deck _playDeck;
        private Deck _winDeck;
        private string _name;
                
        public string Name
        {
            get;
            set;
        }
        public Deck PlayDeck
        {
            get;
            set;
        }
        public Deck WinDeck
        {
            get;
            set;
        }
        public Player()
        {
            Name = "NONE";
            PlayDeck = new Deck();
            WinDeck = new Deck();
        }
    }
}
