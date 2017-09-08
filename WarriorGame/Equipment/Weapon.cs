using System;
using WarriorGame.Enum;

namespace WarriorGame.Equipment
{
    class Weapon
    {
        private int GOOD_GUY_DAMAGE = 25;
        private int BAD_GUY_DAMAGE = 23;

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
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;

                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;

                    
            }
        }
    }
}
