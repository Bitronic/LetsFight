using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsFight
{
    public class Soldier
    {
        private uint life;
        private uint ressourceCost;
        private int damage;

        public Soldier(uint life, uint ressourceCost, int damage) {
            this.life = life;
            this.ressourceCost = ressourceCost;
            this.damage = damage;
        }

        public uint RessourceCost {
            get { return this.ressourceCost; }
        }

        public uint Life {
            get { return this.life; }
        }

        public int Damage {
            get { return this.damage; }
        }

        public void DealDamage(int amount) {
            this.damage -= amount;
        }

        public void AddLife(uint amount) {
            this.life += amount;
        }
    }
}
