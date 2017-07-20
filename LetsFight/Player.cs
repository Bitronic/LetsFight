using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsFight
{
    public class Player
    {
        private string playerName;
        private bool isBot;
        private uint ressources,
            lostVillages,
            capturedVillages = 0;
        private List<Unit> offensiveUnits, defensiveUnits;
        public const int MAX_RESSOURCES = 10000;

        public Player(bool isBot, uint count) : this(null, isBot, count) {

        }

        public Player(string playerName, bool isBot, uint count) {
            this.playerName = isBot ? "bot_" + (char)count : (playerName != null) ? playerName : "player_" + (char)count;
            this.isBot = isBot;
            this.ressources = MAX_RESSOURCES;
            this.offensiveUnits = new List<Unit>();
            this.defensiveUnits = new List<Unit>();
        }

        public void AddRessources(uint amount) {
            uint newResAmount = 0;
            this.ressources = ((newResAmount = this.ressources + amount) <= MAX_RESSOURCES)
                ? newResAmount
                : MAX_RESSOURCES;
        }

        public bool RemoveRessources(uint amount) {
            if (amount < this.ressources) {
                this.ressources -= amount;
                return true;
            }

            return false;
        }

        public void AddVillage() {
            this.capturedVillages++;
        }

        public void RemoveVillage() {
            this.lostVillages++;
        }

        public bool AddUnit(Unit unit) {
            bool success = false;
            if (success = this.RemoveRessources(unit.RessourceCost)) {
                switch (unit.Strategy) {
                    case Unit.StrategyType.Offensive:
                        this.offensiveUnits.Add(unit);
                        break;
                    case Unit.StrategyType.Defensive:
                        this.defensiveUnits.Add(unit);
                        break;
                }
            }

            return success;
        }

        public string PlayerName {
            get { return this.playerName; }
        }

        public bool IsBot {
            get { return this.isBot; }
        }

        public uint Ressources {
            get { return this.ressources; }
        }

        public uint VillageCounter {
            get { return this.capturedVillages - this.lostVillages; }
        }

        public uint LostVillages {
            get { return this.lostVillages; }
        }

        public uint CapturedVillages {
            get { return this.capturedVillages; }
        }

        public uint DefensiveUnits {
            get { return (uint)this.defensiveUnits.Count; }
        }

        public uint OffensiveUnits {
            get { return (uint)this.offensiveUnits.Count; }
        }
    }
}
