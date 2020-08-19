using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleSimulator.Utilities;

namespace BattleSimulator.Army {
    public class FightingUnit {
        public Unit Unit { get; set; }
        public Dice OffensiveDie { get; set; }
        public Dice DefensiveDie { get; set; }
        public int ArmorClass { get; set; }
        public int UnitStrength { get; set; }
        public int ToHit { get; set; }
        public bool Attacking { get; set; }
        public Actions Action { get; set; }
        public int LeadershipBonus { get; set; }
        public int AttackRoll { get; set; }
        public int DamageDone { get; set; }
        public float DamageModifier { get; set; }
        public AdvantageType AdvantageType { get; set; }
    }
}
