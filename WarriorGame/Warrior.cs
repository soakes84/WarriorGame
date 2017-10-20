using System;
using WarriorGame.Equipment;
using WarriorGame.Enum;
using System.Threading;

namespace WarriorGame
{
    class Warrior
    {
        private const int KING = 90;
        private const int GOOD_GUY_STARTING_HEALTH = 80;
        private const int BAD_GUY_STARTING_HEALTH = 80;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;


        public bool IsAlive 
        {
            get
            {
                return isAlive;  
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.King:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                case Faction.Knight:
                    weapon = new Weapon(faction, 50);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuyRandom:
                    weapon = new Weapon(faction, 20);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
            }
        }


        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            AttackResult(enemy, damage);

            Thread.Sleep(200);
		}
        private void AttackResult(Warrior enemy, int damage)
            {
                if (enemy.health <= 0)
                {
                    enemy.isAlive = false;

                    Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                    Tools.ColorfulWriteLine($"{name} murked him!", ConsoleColor.Green);
                }
                
                else
                {
                    Console.WriteLine($"{name} attacked {enemy.name}. {damage} damage was inflicted, remaining health of {enemy.name} is {enemy.health}");
                    Console.WriteLine("---------------------------");
                }
            }
    }
}
