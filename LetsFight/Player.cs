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
        private int ressources,
            villageCounter,
            offensiveUnits,
            defensiveUnits,
            lostVillages,
            capturedVillages;
        public const int MAX_RESSOURCES = 10000;

        public Player(bool isBot, int count) : this(null, isBot, count) {

        }

        public Player(string playerName, bool isBot, int count) {
            this.playerName = isBot ? "bot_" + (char)count : (playerName != null) ? playerName : "player_" + (char)count;
            this.isBot = isBot;
            this.ressources = MAX_RESSOURCES;
        }

        public string PlayerName {
            get { return this.playerName; }
        }

        public bool IsBot {
            get { return this.isBot; }
        }

        public int Ressources {
            get { return this.ressources; }
            set {
                this.ressources = value <= MAX_RESSOURCES
                ? value
                : MAX_RESSOURCES;
            }
        }

        public int VillageCounter {
            get { return this.villageCounter; }
            set { this.villageCounter = value; }
        }

        public int LostVillages {
            get { return this.lostVillages; }
            set { this.lostVillages = value; }
        }

        public int CapturedVillages {
            get { return this.capturedVillages; }
            set { this.capturedVillages = value; }
        }

        public int DefensiveUnits {
            get { return this.defensiveUnits; }
            set { this.defensiveUnits = value; }
        }

        public int OffensiveUnits {
            get { return this.offensiveUnits; }
            set { this.offensiveUnits = value; }
        }
    }
}
