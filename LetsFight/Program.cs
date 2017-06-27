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
            Player me = new Player("Basti", false, -1);
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

        public static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
