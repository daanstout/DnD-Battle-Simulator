using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BattleSimulator.Army;

namespace BattleSimulator {
    public partial class BattleResult : Form {
        public BattleResult(Battle battle) {
            InitializeComponent();

            battle.Calculate();

            alliedUnitAttackRoll.Text = battle.alliedUnit.AttackRoll.ToString();
            enemyUnitAttackRoll.Text = battle.enemyUnit.AttackRoll.ToString();

            alliedUnitDamageTextbox.Text = battle.alliedUnit.DamageDone.ToString();
            enemyUnitDamageTextbox.Text = battle.enemyUnit.DamageDone.ToString();

            alliedUnitDamageDieTextbox.Text = battle.alliedUnit.Attacking ? battle.alliedUnit.OffensiveDie.ToString() : battle.alliedUnit.DefensiveDie.ToString();
            enemyUnitDamageDieTextbox.Text = battle.enemyUnit.Attacking ? battle.enemyUnit.OffensiveDie.ToString() : battle.enemyUnit.DefensiveDie.ToString();

            alliedUnitArmorClassTextbox.Text = battle.alliedUnit.ArmorClass.ToString();
            enemyUnitArmorClassTextbox.Text = battle.enemyUnit.ArmorClass.ToString();

            alliedUnitDamageModifierTextbox.Text = battle.alliedUnit.DamageModifier.ToString();
            enemyUnitDamageModifierTextbox.Text = battle.enemyUnit.DamageModifier.ToString();

            alliedUnitToHitTextbox.Text = battle.alliedUnit.ToHit.ToString();
            enemyUnitToHitTextbox.Text = battle.enemyUnit.ToHit.ToString();

            alliedUnitAdvantageTextbox.Text = battle.alliedUnit.AdvantageType.ToString();
            enemyUnitAdvantageTextbox.Text = battle.enemyUnit.AdvantageType.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
