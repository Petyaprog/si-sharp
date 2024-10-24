using System;

namespace Учет_денежных_средств
{
    internal class Profit : Payment
    {
        public string Type { get; set; }
        public Profit(string type, DateTime Date, int Amount, string Description) :base(Date, Amount, Description)
        {
            Type = type;
            Console.WriteLine("Вызван конструктор Profit.");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"  Тип: {Type}");
        }
    }
}
