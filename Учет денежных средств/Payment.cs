using System;

namespace Учет_денежных_средств
{
    internal class Payment
    {
        public DateTime Date;
        public int Amount;
        public string Description;

        public Payment()
        {
            Console.WriteLine("Вызван конструктор без параметров Payment");
        }

        public Payment(DateTime date, int amount, string description)
        {
            Date = date;
            Amount = amount;
            Description = description;
            Console.WriteLine("Вызван конструктор с параметрами Payment");
        }
    }
}
