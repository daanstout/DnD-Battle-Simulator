using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulator.Utilities {
    public struct Dice {
        public int dieCount { get; set; }
        public int dieSides { get; set; }

        public Dice(int dieCount, int dieSides) {
            this.dieCount = dieCount;
            this.dieSides = dieSides;
        }

        public override string ToString() => string.Format("{0}d{1}", dieCount, dieSides);

        public static Dice operator +(Dice left, Dice right) => new Dice(left.dieCount + right.dieCount, left.dieSides);

        public static Dice operator +(Dice left, int count) => new Dice(left.dieCount + count, left.dieSides);
    }
}
