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
            Program prog = new Program();
            Player me = prog.createPlayer(false, "Basti");
            Unit unit = new Unit();

            int numberOfFighters = 0;
            int numberOfSpys = 0;
            int numberOfKnights = 0;
            int numberOfKings = 0;

            //Error catching for letters incoming
            Console.WriteLine("Ressourcen die dir zur Verfügung stehen: " + me.Ressources);
            Console.WriteLine("Anzahl Fighters: ");
            numberOfFighters = Convert.ToInt32(Console.ReadLine());
            me.Ressources -= numberOfFighters * unit.Fighter.RessourceCosts;
            Console.WriteLine("Übrige Ressourcen: " + me.Ressources + Environment.NewLine);

            Console.WriteLine("Anzahl Spys: ");
            numberOfSpys = Convert.ToInt32(Console.ReadLine());
            me.Ressources -= numberOfSpys * unit.Spy.RessourceCosts;
            Console.WriteLine("Übrige Ressourcen: " + me.Ressources + Environment.NewLine);

            Console.WriteLine("Anzahl Knights: ");
            numberOfKnights = Convert.ToInt32(Console.ReadLine());
            me.Ressources -= numberOfKnights * unit.Knight.RessourceCosts;
            Console.WriteLine("Übrige Ressourcen: " + me.Ressources + Environment.NewLine);

            Console.WriteLine("Anzahl Kings: ");
            numberOfKings = Convert.ToInt32(Console.ReadLine());
            me.Ressources -= numberOfKings * unit.King.RessourceCosts;
            Console.WriteLine("Übrige Ressourcen: " + me.Ressources + Environment.NewLine);

            Console.ReadKey();
        }
        private Player createPlayer(bool isBot, string playername = null, int count = 0)
        {
            Player player = new Player();
            const int MAX_RESSOURCES = 10000;
            if(playername == null && count == 0)
            {
                ErrorMessage("Es muss ein count oder ein playername angegeben werden");
            }
            player.Playername = playername != null ? playername : "player_" + count ;
            player.Playername = isBot ? "bot_" + count : player.Playername;     //If player isBot change name
            player.isBot = isBot;
            player.Ressources = MAX_RESSOURCES;
            return player;
        }
        public static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
