using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BattleSimulator.Army;
using BattleSimulator.Utilities;

using Newtonsoft.Json;

namespace BattleSimulator {
    public partial class BattleSimulator : Form {
        private readonly List<Unit> units;
        private bool alliedAttacking = true;
        private bool enemyAttacking = false;
        private readonly Random rand;
        private Battle battle;

        public BattleSimulator() {
            InitializeComponent();

            rand = new Random();

            units = new List<Unit>();

            var files = Directory.GetFiles(@"Data/");

            foreach (var file in files)
                units.AddRange(JsonConvert.DeserializeObject<List<Unit>>(File.ReadAllText(file)));

            units.ForEach(unit => {
                alliedUnitCombobox.Items.Add(unit);
                enemyUnitCombobox.Items.Add(unit);
            });

            foreach(var item in Enum.GetValues(typeof(Actions))) {
                alliedUnitActionCombobox.Items.Add(item);
                enemyUnitActionCombobox.Items.Add(item);
            }

            alliedUnitActionCombobox.SelectedIndex = 2;
            enemyUnitActionCombobox.SelectedIndex = 2;

            CalculateAlliedToHit();
            CalculateEnemyToHit();
        }

        private int ToHitFromLeadership(int leadership) {
            return (leadership / 2) - 5;
        }

        private void CalculateAlliedToHit() {
            var toHit = alliedUnitBaseToHitNumeric.Value;
            toHit += ToHitFromLeadership((int)alliedUnitLeadershipBonusNumeric.Value);
            alliedUnitToHitBonusTextbox.Text = toHit.ToString();
        }

        private void CalculateEnemyToHit() {
            var toHit = enemyUnitBaseToHitNumeric.Value;
            toHit += ToHitFromLeadership((int)enemyUnitLeadershipBonusNumeric.Value);
            enemyUnitToHitBonusTextbox.Text = toHit.ToString();
        }

        private bool CheckForm() {
            if (alliedUnitCombobox.SelectedItem == null)
                return false;

            if (enemyUnitCombobox.SelectedItem == null)
                return false;



            return true;
        }

        private void AlliedUnitCombobox_SelectedIndexChanged(object sender, EventArgs e) {
            if (!(sender is ComboBox alliedCombobox))
                return;


            if (!(alliedCombobox.SelectedItem is Unit unit))
                return;

            alliedUnitTypeTextbox.Text = unit.type.ToString();
            alliedUnitOffensiveDieTextbox.Text = unit.offensiveDie.ToString();
            alliedUnitDefensiveDieTextbox.Text = unit.defensiveDie.ToString();
            alliedUnitArmorClassTextbox.Text = unit.armorClass.ToString();
            alliedUnitRangeTextbox.Text = unit.range?.ToString();
        }

        private void EnemyUnitCombobox_SelectedIndexChanged(object sender, EventArgs e) {
            if (!(sender is ComboBox enemyCombobox))
                return;

            if (!(enemyCombobox.SelectedItem is Unit unit))
                return;

            enemyUnitTypeTextbox.Text = unit.type.ToString();
            enemyUnitOffensiveDieTextbox.Text = unit.offensiveDie.ToString();
            enemyUnitDefensiveDieTextbox.Text = unit.defensiveDie.ToString();
            enemyUnitArmorClassTetxbox.Text = unit.armorClass.ToString();
            enemyUnitRangeTextbox.Text = unit.range?.ToString();
        }

        private void AlliedUnitAttackingRadio_CheckedChanged(object sender, EventArgs e) {
            if (!(sender is RadioButton radio))
                return;

            alliedAttacking = radio.Checked;

            if (!alliedAttacking && !enemyAttacking)
                enemyUnitAttackingRadio.Checked = true;
        }

        private void EnemyUnitAttackingRadio_CheckedChanged(object sender, EventArgs e) {
            if (!(sender is RadioButton radio))
                return;

            enemyAttacking = radio.Checked;

            if (!alliedAttacking && !enemyAttacking)
                alliedUnitAttackingRadio.Checked = true;
        }

        private void AlliedLeadershipBonusNumeric_ValueChanged(object sender, EventArgs e) {
            CalculateAlliedToHit();
        }

        private void EnemyLeadershipBonusNumeric_ValueChanged(object sender, EventArgs e) {
            CalculateEnemyToHit();
        }

        private void AlliedUnitBaseToHitNumeric_ValueChanged(object sender, EventArgs e) {
            CalculateAlliedToHit();
        }

        private void EnemyUnitBaseToHitNumeric_ValueChanged(object sender, EventArgs e) {
            CalculateEnemyToHit();
        }

        private void RollAlliedLeadershipButton_Click(object sender, EventArgs e) {
            var mod = (int)alliedLeadershipModifierNumeric.Value;
            var roll = rand.Next(1, 21);

            var value = mod + roll;

            if (value < 1)
                value = 1;

            alliedUnitLeadershipBonusNumeric.Value = value;
        }

        private void RollEnemyLeadershipButton_Click(object sender, EventArgs e) {
            var mod = (int)enemyLeadershipModifierNumeric.Value;
            var roll = rand.Next(1, 21);

            var value = mod + roll;

            if (value < 1)
                value = 1;
            else if (value > 30)
                value = 30;

            enemyUnitLeadershipBonusNumeric.Value = value;
        }

        private void SimulateButton_Click(object sender, EventArgs e) {
            if (!CheckForm())
                return;

            battle = new Battle();

            var alliedUnit = alliedUnitCombobox.SelectedItem as Unit;

            battle.alliedUnit.armorClass = alliedUnit.armorClass + (int)alliedUnitArmorClassAdditionNumeric.Value;
            battle.alliedUnit.defensiveDie = alliedUnit.defensiveDie + (int)alliedUnitDefensiveDieAdditionNumeric.Value;
            battle.alliedUnit.offensiveDie = alliedUnit.offensiveDie + (int)alliedUnitOffensiveDieAdditionNumeric.Value;
            battle.alliedUnit.toHit = Convert.ToInt32(alliedUnitToHitBonusTextbox.Text);
            battle.alliedUnit.unit = alliedUnit.Copy();
            battle.alliedUnit.unitStrength = (int)alliedUnitStrengthNumeric.Value;
            battle.alliedUnit.attacking = alliedAttacking;
            battle.alliedUnit.action = (Actions)alliedUnitActionCombobox.SelectedItem;
            battle.alliedUnit.leadershipBonus = (int)alliedUnitLeadershipBonusNumeric.Value;

            var enemyUnit = enemyUnitCombobox.SelectedItem as Unit;

            battle.enemyUnit.armorClass = enemyUnit.armorClass + (int)enemyUnitArmorClassAdditionNumeric.Value;
            battle.enemyUnit.defensiveDie = enemyUnit.defensiveDie + (int)enemyUnitDefensiveDieAdditionNumeric.Value;
            battle.enemyUnit.offensiveDie = enemyUnit.offensiveDie + (int)enemyUnitOffensiveDieAdditionNumeric.Value;
            battle.enemyUnit.toHit = Convert.ToInt32(enemyUnitToHitBonusTextbox.Text);
            battle.enemyUnit.unit = enemyUnit.Copy();
            battle.enemyUnit.unitStrength = (int)enemyUnitStrengthNumeric.Value;
            battle.enemyUnit.attacking = enemyAttacking;
            battle.enemyUnit.action = (Actions)enemyUnitActionCombobox.SelectedItem;
            battle.enemyUnit.leadershipBonus = (int)enemyUnitLeadershipBonusNumeric.Value;

            new BattleResult(battle).ShowDialog();
        }
    }
}
