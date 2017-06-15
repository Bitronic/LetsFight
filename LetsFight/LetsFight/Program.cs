using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsFight
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_RESSOURCES = 10000;

        }
        public Player createPlayer(bool isBot, int count, string playername = null)
        {
            Player player = new Player();
            player.Playername = playername != null ? playername : "player_" + count ;
            player.Playername = isBot ? "bot_" + count : player.Playername;     //If player isBot change name

        }
    }
}
