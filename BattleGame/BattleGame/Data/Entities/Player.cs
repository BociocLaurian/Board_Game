using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Data.Entities
{
    public class Player
    {
        public string Name { get; set; }

        public int HighLevelEnergyNr { get; set; }

        public int MediumLevelEnergyNr { get; set; }

        public int LowLevelEnergyNr { get; set; }

        public Player() { }

        public Player(string name)
        {
            this.Name = name;
        }       

    }
}
