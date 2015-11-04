using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player play1 = new Player();
            Player play2 = new Player();
            Game.Setting(play1, play2);
            do
                Game.Playing(play1, play2);
            while (play1.PlayDeck.CardDeck.Count != 0);
            Game.WhoWinGame(play1, play2);
            System.Console.ReadKey();
        }
    }
}
