using System;

namespace Учет_денежных_средств
{
    internal class Profit : Payment
    {
        public string Type { get; set; }
        public Profit(string type, PaymentInfo info) :base(info)
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
