using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulator.Utilities {
    public struct DicePool {
        public int numD4 { get; set; }
        public int numD6 { get; set; }
        public int numD8 { get; set; }
        public int numD10 { get; set; }
        public int numD12 { get; set; }
        public int numD20 { get; set; }
        public int flatBonus { get; set; }

        public int CalculateDamage(Random rand) {
            int damage = 0;

            for (int i = 0; i < numD4; i++)
                damage += rand.Next(1, 5);

            for (int i = 0; i < numD6; i++)
                damage += rand.Next(1, 7);

            for (int i = 0; i < numD8; i++)
                damage += rand.Next(1, 9);

            for (int i = 0; i < numD10; i++)
                damage += rand.Next(1, 11);

            for (int i = 0; i < numD12; i++)
                damage += rand.Next(1, 13);

            for (int i = 0; i < numD20; i++)
                damage += rand.Next(1, 21);

            damage += flatBonus;

            return damage;
        }

        public static DicePool FromDice(Dice dice) {
            var pool = new DicePool();

            switch (dice.dieSides) {
                case 4:
                    pool.numD4 = dice.dieCount;
                    break;
                case 6:
                    pool.numD6 = dice.dieCount;
                    break;
                case 8:
                    pool.numD8 = dice.dieCount;
                    break;
                case 10:
                    pool.numD10 = dice.dieCount;
                    break;
                case 12:
                    pool.numD12 = dice.dieCount;
                    break;
                case 20:
                    pool.numD20 = dice.dieCount;
                    break;
                default:
                    break;
            }

            return pool;
        }
    }
}
