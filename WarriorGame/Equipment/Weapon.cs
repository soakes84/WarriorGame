using System;
using WarriorGame.Enum;

namespace WarriorGame.Equipment
{
    class Weapon
    {
        private int GOOD_GUY_DAMAGE = 25;
        private int BAD_GUY_DAMAGE = 23;

        static Random rng = new Random();

        private int damage;

        public int Damage 
        {
            get 
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.King:
                    damage = GOOD_GUY_DAMAGE;
                    break;

                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
            }
        }

        public Weapon(Faction faction, int damage)
        {
            var attackPower = damage;

            switch (faction)
            {
                case Faction.Knight:
                    damage = rng.Next(0, attackPower);
                   break;
               case Faction.BadGuy:
                    damage = rng.Next(0, attackPower);
                   break;
            }

        }
    }
}
