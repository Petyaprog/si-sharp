using System;

namespace Паттерны_прототип_и_сингелтон
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = GameManager.getInstance();

            Character warrior = new Warrior("Thor");
            Character mage = new Mage("Monk");

            Character warriorClone = warrior.Clone();
            warriorClone.Name = "Thor II";

            Character mageClone = mage.Clone();
            mageClone.Level = 2;

            Console.WriteLine(warrior);
            Console.WriteLine(warriorClone);
            Console.WriteLine();
            Console.WriteLine(mage);
            Console.WriteLine(mageClone);
            Console.WriteLine();

            gameManager.AddScore(10);
            gameManager.NextLevel();
            gameManager.AddTask("Defeat the dragon");
            gameManager.ShowStatus();
        }
    }
}
