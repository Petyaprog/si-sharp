using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using static Учет_денежных_средств.Program;

namespace Учет_денежных_средств
{
    internal class Logbook : ILogbook
    {
        public string Name { get; set; }
        public int Card { get; set; }

        private List<Payment> payments = new List<Payment>();
        private static int objectCount = 0;

        public event PaymentAddedEventHandler PaymentAdded;

        public Logbook()
        {
            objectCount++;
            Console.WriteLine("Вызван конструктор без параметров Logbook");
        }

        public Logbook(string name, int card)
        {
            Name = name;
            Card = card;
            objectCount++;
            Console.WriteLine("Вызван конструктор с параметрами Logbook");
        }

        ~Logbook()
        {
            objectCount--;
            Console.WriteLine("Вызван деструктор Logbook");
        }

        public int GetObjectCount()
        {
            return objectCount;
        }

        public void AddDate(Payment payment)
        {
            payments.Add(payment);
            PaymentAdded?.Invoke();
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Имя: {Name}  Номер карты: {Card}\n");

            foreach (var item in payments)
            {
                item.Print();
                Console.WriteLine();
            }
        }
    }
}