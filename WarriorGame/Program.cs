using System;
using WarriorGame.Enum;

namespace WarriorGame
{
    class MainClass
    {
        static Random rng = new Random();

        public static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("SteveThePirate", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Willie", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }
        }
    }
}
