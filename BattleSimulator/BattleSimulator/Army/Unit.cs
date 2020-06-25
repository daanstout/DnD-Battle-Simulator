using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using BattleSimulator.Utilities;

namespace BattleSimulator.Army {
    public class Unit {
        public UnitTypes type { get; set; }
        public string name { get; set; }
        public string description { get; set;  }
        public Dice offensiveDie { get; set; }
        public Dice defensiveDie { get; set; }
        public int armorClass { get; set; }
        public Range? range { get; set; }

        public override string ToString() => name;

        public Unit Copy() {
            return new Unit() {
                type = type,
                name = name,
                description = description,
                offensiveDie = offensiveDie,
                defensiveDie = defensiveDie,
                armorClass = armorClass,
                range = range
            };
        }
    }
}
