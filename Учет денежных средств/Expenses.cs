using System;

namespace Учет_денежных_средств
{
    internal class Expenses : Payment
    {
        public string Type { get; set; }

        public Expenses(string type, PaymentInfo info) : base(info)
        {
            Type = type;
            Console.WriteLine("Вызван конструктор Expenses.");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"  Тип: {Type}");
        }
    }
}
