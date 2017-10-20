using System;
using WarriorGame.Enum;

namespace WarriorGame
{
    class MainClass
    {
        static Random rng = new Random();

        public static void Main(string[] args)
        {
            Warrior king = new Warrior("King SteveThePirate", Faction.King);
            Warrior badGuy = new Warrior("Willie", Faction.BadGuy);

            Warrior knight = new Warrior("Kelly", Faction.Knight);
            Warrior badGuyRandom = new Warrior("Brooke", Faction.BadGuyRandom);


            while (king.IsAlive && badGuy.IsAlive)
            {
                var game = rng.Next(0,20);

                if (game < 10)
                {
                    king.Attack(badGuy);
                }
                else if(game >= 10 && game < 18)
                {
                    badGuy.Attack(king);
                }
                else if (game == 18)
                {
                    badGuyRandom.Attack(king);
                    badGuyRandom.Attack(knight);
                }
                else
                {
                    knight.Attack(badGuy);
                    knight.Attack(badGuyRandom);
                }
            }


        }
    }
}
