using System;

namespace Паттерны_прототип_и_сингелтон
{
    public abstract class Character
    {  
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public Character(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }
        public abstract Character Clone();

        public override string ToString()
        {
            return $"{GetType().Name}(Name: {Name}, Health: {Health}, Level: {Level})";
        }
    }
}
