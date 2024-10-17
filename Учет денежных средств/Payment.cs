using System;

namespace Учет_денежных_средств
{
    internal class Payment
    {
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        private static int objectCount = 0;

        public Payment()
        {
            objectCount++;
            Console.WriteLine("Вызван конструктор без параметров Payment");
        }

        public Payment(DateTime date, int amount, string description)
        {
            Date = date;
            Amount = amount;
            Description = description;
            objectCount++;
            Console.WriteLine("Вызван конструктор с параметрами Payment");
        }
        ~Payment()
        {
            objectCount--;
            Console.WriteLine("Вызван деструктор Payment");
        }

        public static int GetObjectCount()
        {
            return objectCount;
        }

        public virtual void Print()
        {
            Console.Write($"Дата: {Date}  \nОписание: {Description}  Сумма: {Amount}");
        }
    }
}
