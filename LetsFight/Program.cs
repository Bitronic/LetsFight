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
            Player p = new Player("Basti", false, 0);

            //Error catching for letters incoming
            Console.WriteLine("Ressourcen die dir zur Verfügung stehen: " + p.Ressources);

            PrepareUnit(p, "Fighter", Unit.StrategyType.Offensive, new Soldier(100, 50, 50));
            PrepareUnit(p, "Spy", Unit.StrategyType.Defensive, new Soldier(30, 15, 5));
            PrepareUnit(p, "Knight", Unit.StrategyType.Offensive, new Soldier(250, 150, 100));
            PrepareUnit(p, "King", Unit.StrategyType.Defensive, new Soldier(20, 2000, 10));

            Console.ReadKey();
        }

        public static void PrepareUnit(Player p, string unitCaption, Unit.StrategyType strategy, Soldier soldierDetails) {
            Console.WriteLine("Anzahl {0}:", unitCaption);
            uint soldierCount = Convert.ToUInt32(Console.ReadLine());
            Unit u = new Unit(unitCaption, soldierCount, strategy, soldierDetails);
            if(!p.AddUnit(u))
                Console.WriteLine("Ungenügende Ressourcen!");
            Console.WriteLine("Übrige Ressourcen: {0}", p.Ressources + Environment.NewLine);
        }

        public static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
