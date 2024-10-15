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
            payments = new List<object>();
            count++;
            Console.WriteLine("Вызван конструктор без параметров Logbook");
        }

        public Logbook(string name, int card)
        {
            Name = name;
            Card = card;
            count++;
            Console.WriteLine("Вызван конструктор с параметрами Logbook");
        }

        public void AddDate(Logbook logbook, Payment payment, Profit profit)
        {
            payments.Add(logbook);
            payments.Add(payment);
            payments.Add(profit);
        }

        public void Print()
        {
            Console.WriteLine();
            foreach (var item in payments)
            {
                if (item is Logbook logbook)
                {
                    Console.Write($"Имя: {logbook.Name}  Номер карты: {logbook.Card}");
                }
                else if (item is Payment payment)
                {
                    Console.WriteLine($"  Дата: {payment.Date}  \nОписание: {payment.Description}  Сумма: {payment.Amount}\n");
                    //Console.WriteLine();
                }
            }
        }
    }
}
