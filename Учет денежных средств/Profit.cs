using System;

namespace Учет_денежных_средств
{
    internal class Profit : Payment
    {
        public string Type;
        public Profit(string type, DateTime Date, int Amount, string Description) :base(Date, Amount, Description)
        {
            Type = type;
            Console.WriteLine("Вызван конструктор Profit.");
        }

        //public Profit()
        //{
        //    Type = type;
        //}
    }
}
