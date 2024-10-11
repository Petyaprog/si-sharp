using System;
using System.Collections.Generic;

namespace Учет_денежных_средств
{
    internal class Logbook
    {
        public string Name;
        public int Card;

        private List<object> payments = new List<object>();
        private int count = 0;

        public Logbook()
        {
            count++;
            Console.WriteLine("Вызван конструктор без параметров Logbook");
        }

        public Logbook(string name, int card)
        {
            Name = name;
            Card = card;
            payments = new List<object>();
            count++;
            Console.WriteLine("Вызван конструктор с параметрами Logbook");
        }

        public void AddDate(Payment payment, Logbook logbook)
        {
            payments.Add(payment);
            payments.Add(logbook);
        }

        public void Print()
        {
            Console.WriteLine();
            foreach (var item in payments)
            {
                if (item is Payment payment)
                {
                    Console.WriteLine($"Дата: {payment.Date}, Сумма: {payment.Amount}, Описание: {payment.Description}");
                }
                else if (item is Logbook logbook)
                {
                    Console.WriteLine($"Имя: {logbook.Name}, Номер карты: {logbook.Card}");
                    Console.WriteLine();
                }
            }
        }
    }
}
