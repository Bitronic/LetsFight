using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsFight
{
    class Unit
    {
        public Unit_Definition Fighter = new Unit_Definition() { Life = 100, Damage = 50, Orientation = Unit_Definition.UnitOrientation.Offensive, RessourceCosts = 50 };
        public Unit_Definition Spy = new Unit_Definition() { Life = 30, Damage = 5, Orientation = Unit_Definition.UnitOrientation.Defensive, RessourceCosts = 15 };
        public Unit_Definition Knight = new Unit_Definition() { Life = 250, Damage = 100, Orientation = Unit_Definition.UnitOrientation.Offensive, RessourceCosts = 150 };
        public Unit_Definition King = new Unit_Definition() { Life = 20, Damage = 10, Orientation = Unit_Definition.UnitOrientation.Defensive, RessourceCosts = 2000 };
    }
    class Unit_Definition
    {
        public int Life { get; set; }
        public int Damage { get; set; }
        public enum UnitOrientation
        {
            Offensive,
            Defensive
        };
        public UnitOrientation Orientation { get; set; }
        public bool isOffensive()
        {
            return Orientation == UnitOrientation.Offensive;
        }
        public bool isDefensive()
        {
            return Orientation == UnitOrientation.Defensive;
        }
        public int RessourceCosts { get; set; }
    }
}
