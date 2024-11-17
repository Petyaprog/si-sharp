using System;

namespace Паттерны_прототип_и_сингелтон
{
    public class Mage : Character
    {
        public Mage(string name) : base(name, health: 100, level: 1) { }

        public override Character Clone()
        {
            return new Mage(Name) { Health = this.Health, Level = this.Level };
        }
    }
}
