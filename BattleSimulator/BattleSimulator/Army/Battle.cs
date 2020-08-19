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
            alliedUnit.DamageDone = Calculate(alliedUnit, enemyUnit);
            enemyUnit.DamageDone = Calculate(enemyUnit, alliedUnit);
        }

        private int Calculate(FightingUnit unitFrom, FightingUnit unitTo) {
            var battleDice = unitFrom.Attacking ? unitFrom.OffensiveDie : unitFrom.DefensiveDie;
            var AC = unitTo.ArmorClass;
            if (!unitTo.Attacking && unitTo.Action == Actions.shieldFormation && unitFrom.Unit.type == UnitTypes.ranged)
                AC += 2;
            else if (!unitTo.Attacking && unitTo.Action == Actions.defensiveStance)
                AC += (unitTo.LeadershipBonus - 6 ) / 4;
            else if (unitTo.Action == Actions.charge && unitTo.Attacking && unitTo.Unit.type == UnitTypes.infantry)
                AC -= 3;
            var toHit = unitFrom.ToHit;
            if (!unitFrom.Attacking && unitFrom.Action == Actions.offensiveStance)
                toHit++;
            var damageMod = (unitFrom.Attacking && unitFrom.Action == Actions.charge && unitFrom.Unit.name != "Polearms") ? 1.5f : 1.0f;
            if (unitFrom.Unit.name == "Polearms" && unitTo.Unit.type == UnitTypes.cavalry) {
                damageMod *= 2;
                if (unitTo.Action == Actions.charge && unitTo.Attacking)
                    damageMod *= 2;
            }

            unitFrom.AttackRoll = unitFrom.AdvantageType switch
            {
                AdvantageType.Advantage => Math.Max(rand.Next(1, 21), rand.Next(1, 21)),
                AdvantageType.Disadvantage => Math.Min(rand.Next(1, 21), rand.Next(1, 21)),
                _ => rand.Next(1, 21)
            };
            
            var attackHit = unitFrom.AttackRoll + toHit;

            var nat20 = unitFrom.AttackRoll == 20;

            var ACdifferential = attackHit - AC;

            if (ACdifferential <= -6 && !(unitFrom.Attacking && unitFrom.Unit.type == UnitTypes.cavalry && unitFrom.Action == Actions.charge))
                battleDice.dieCount = 0;
            else
                battleDice.dieCount += (ACdifferential / 2);

            var pool = DicePool.FromDice(battleDice);

            if (nat20)
                pool.flatBonus = battleDice.dieSides;

            if (!unitFrom.Attacking && unitFrom.Unit.type == UnitTypes.artillery) {
                pool = new DicePool();
                battleDice.dieCount = 0;
            }

            int totalDamage = 0;

            for (int i = 0; i < unitFrom.UnitStrength; i++)
                totalDamage += pool.CalculateDamage(rand);

            if (unitFrom.Attacking)
                unitFrom.OffensiveDie = battleDice;
            else
                unitFrom.DefensiveDie = battleDice;

            unitTo.ArmorClass = AC;
            unitFrom.ToHit = toHit;
            unitFrom.DamageModifier = damageMod;

            return (int)(totalDamage * damageMod);
        }
    }
}
