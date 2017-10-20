using WarriorGame.Enum;

namespace WarriorGame.Equipment
{
    class Armor
    {

        private int KING_ARMOR = 5;
        private int BAD_GUY_ARMOR = 5;
        private int KNIGHT_ARMOR = 10;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.King:
                    armorPoints = KING_ARMOR;
                    break;

                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                case Faction.Knight:
                    armorPoints = KNIGHT_ARMOR;
                    break;
                case Faction.BadGuyRandom:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
            }
        }
    }
}