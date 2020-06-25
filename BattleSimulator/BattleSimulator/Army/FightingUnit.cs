using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleSimulator.Utilities;

namespace BattleSimulator.Army {
    public class FightingUnit {
        public Unit unit { get; set; }
        public Dice offensiveDie { get; set; }
        public Dice defensiveDie { get; set; }
        public int armorClass { get; set; }
        public int unitStrength { get; set; }
        public int toHit { get; set; }
        public bool attacking { get; set; }
        public Actions action { get; set; }
        public int leadershipBonus { get; set; }
        public int attackRoll { get; set; }
        public int damageDone { get; set; }
        public float damageModifier { get; set; }
    }
}
