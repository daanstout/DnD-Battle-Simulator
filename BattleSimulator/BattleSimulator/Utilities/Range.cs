using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulator.Utilities {
    public struct Range {
        public int range { get; set; }
        public int maxRange { get; set; }

        public Range(int range, int maxRange) {
            this.range = range;
            this.maxRange = maxRange;
        }

        public override string ToString() => string.Format("{0}/{1}", range, maxRange);
    }
}
