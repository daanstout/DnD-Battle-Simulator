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
        private readonly Battle battle;
        public BattleResult(Battle battle) {
            InitializeComponent();

            this.battle = battle;

            battle.Calculate();

            alliedUnitAttackRoll.Text = battle.alliedUnit.attackRoll.ToString();
            enemyUnitAttackRoll.Text = battle.enemyUnit.attackRoll.ToString();

            alliedUnitDamageTextbox.Text = battle.alliedUnit.damageDone.ToString();
            enemyUnitDamageTextbox.Text = battle.enemyUnit.damageDone.ToString();

            alliedUnitDamageDieTextbox.Text = battle.alliedUnit.attacking ? battle.alliedUnit.offensiveDie.ToString() : battle.alliedUnit.defensiveDie.ToString();
            enemyUnitDamageDieTextbox.Text = battle.enemyUnit.attacking ? battle.enemyUnit.offensiveDie.ToString() : battle.enemyUnit.defensiveDie.ToString();

            alliedUnitArmorClassTextbox.Text = battle.alliedUnit.armorClass.ToString();
            enemyUnitArmorClassTextbox.Text = battle.enemyUnit.armorClass.ToString();

            alliedUnitDamageModifierTextbox.Text = battle.alliedUnit.damageModifier.ToString();
            enemyUnitDamageModifierTextbox.Text = battle.enemyUnit.damageModifier.ToString();

            alliedUnitToHitTextbox.Text = battle.alliedUnit.toHit.ToString();
            enemyUnitToHitTextbox.Text = battle.enemyUnit.toHit.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
