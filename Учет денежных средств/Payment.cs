using System;

namespace Учет_денежных_средств
{
    internal class Payment
    {
        public PaymentInfo Info { get; set; }
        private static int objectCount = 0;

        public Payment()
        {
            objectCount++;
            Console.WriteLine("Вызван конструктор без параметров Payment");
        }

        public Payment(PaymentInfo info)
        {
            Info = info;
            objectCount++;
            Console.WriteLine("Вызван конструктор с параметрами Payment");
        }
        ~Payment()
        {
            objectCount--;
            Console.WriteLine("Вызван деструктор Payment");
        }

        public int GetObjectCount()
        {
            return objectCount;
        }

        public virtual void Print()
        {
            Console.Write($"Дата: {Info.Date}  \nОписание: {Info.Description}  Сумма: {Info.Amount}");
        }
    }
}
