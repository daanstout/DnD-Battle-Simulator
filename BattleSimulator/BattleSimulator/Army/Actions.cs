using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulator.Army {
    public enum Actions {
        [Description("Offensive Stance")]
        offensiveStance,
        [Description("Defensive Stance")]
        defensiveStance,
        [Description("Charge")]
        charge,
        [Description("Shield Formation")]
        shieldFormation,
        [Description("None")]
        none
    }
}
