using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsFight
{
    public class Unit
    {
        public enum StrategyType
        {
            Offensive = 0,
            Defensive = 1
        }

        private Soldier soldierDetails;
        private uint soldierCount;
        private string caption;
        private StrategyType strategy;

        public Unit(string caption, uint soldierCount, StrategyType strategy, Soldier soldierDetails) {
            this.soldierDetails = soldierDetails;
            this.soldierCount = soldierCount;
            this.strategy = strategy;
        }

        public uint RessourceCost {
            get { return this.soldierDetails.RessourceCost * this.soldierCount; }
        }

        public uint SoldierCount {
            get { return this.soldierCount; }
        }

        public StrategyType Strategy {
            get { return this.strategy; }
        }
    }
}
