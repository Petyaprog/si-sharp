using System;

namespace Паттерны_прототип_и_сингелтон
{
    public class Warrior : Character
    {
        public Warrior(string name): base(name, health: 150, level: 1){ }

        public override Character Clone()
        {
            return new Warrior(Name) { Health = this.Health, Level = this.Level };
        }
    }
}
