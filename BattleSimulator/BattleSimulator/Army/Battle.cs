using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleSimulator.Utilities;

namespace BattleSimulator.Army {
    public class Battle {
        public readonly FightingUnit alliedUnit;
        public readonly FightingUnit enemyUnit;

        private readonly Random rand;

        public Battle() {
            alliedUnit = new FightingUnit();
            enemyUnit = new FightingUnit();

            rand = new Random();
        }

        public void Calculate() {
            alliedUnit.damageDone = Calculate(alliedUnit, enemyUnit);
            enemyUnit.damageDone = Calculate(enemyUnit, alliedUnit);
        }

        private int Calculate(FightingUnit unitFrom, FightingUnit unitTo) {
            var battleDice = unitFrom.attacking ? unitFrom.offensiveDie : unitFrom.defensiveDie;
            var AC = unitTo.armorClass;
            if (!unitTo.attacking && unitTo.action == Actions.shieldFormation && unitFrom.unit.type == UnitTypes.ranged)
                AC += 2;
            else if (!unitTo.attacking && unitTo.action == Actions.defensiveStance)
                AC += ((unitTo.leadershipBonus / 2 - 5) / 2) + 1;
            else if (unitTo.action == Actions.charge && unitTo.attacking && unitTo.unit.type == UnitTypes.infantry)
                AC -= 3;
            var toHit = unitFrom.toHit;
            if (!unitFrom.attacking && unitFrom.action == Actions.offensiveStance)
                toHit++;
            var damageMod = (unitFrom.attacking && unitFrom.action == Actions.charge && unitFrom.unit.name != "Polearms") ? 1.5f : 1.0f;
            if (unitFrom.unit.name == "Polearms" && unitTo.unit.type == UnitTypes.cavalry) {
                damageMod *= 2;
                if (unitTo.action == Actions.charge && unitTo.attacking)
                    damageMod *= 2;
            }

            unitFrom.attackRoll = rand.Next(1, 21);
            //unitFrom.attackRoll = unitFrom.attacking ? 16 : 15;
            var attackHit = unitFrom.attackRoll + toHit;

            var nat20 = unitFrom.attackRoll == 20;

            var ACdifferential = attackHit - AC;

            if (ACdifferential <= -6 && !(unitFrom.attacking && unitFrom.unit.type == UnitTypes.cavalry && unitFrom.action == Actions.charge))
                battleDice.dieCount = 0;
            else
                battleDice.dieCount += (ACdifferential / 2);

            var pool = DicePool.FromDice(battleDice);

            if (nat20)
                pool.flatBonus = battleDice.dieSides;

            if (!unitFrom.attacking && unitFrom.unit.type == UnitTypes.artillery) {
                pool = new DicePool();
                battleDice.dieCount = 0;
            }

            int totalDamage = 0;

            for (int i = 0; i < unitFrom.unitStrength; i++)
                totalDamage += pool.CalculateDamage(rand);

            if (unitFrom.attacking)
                unitFrom.offensiveDie = battleDice;
            else
                unitFrom.defensiveDie = battleDice;

            unitTo.armorClass = AC;
            unitFrom.toHit = toHit;
            unitFrom.damageModifier = damageMod;

            return (int)(totalDamage * damageMod);
        }
    }
}
