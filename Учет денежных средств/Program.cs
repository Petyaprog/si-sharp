using System;

namespace Учет_денежных_средств
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logbook logbook = new Logbook("Кирилл", 1397331);
                Payment payment = new Payment();

                logbook.AddDate(new Profit("Доход", DateTime.Now, 50000, "З/П"));
                logbook.AddDate(new Profit("Доход", DateTime.Now, 1660, "Стипендия"));
                logbook.AddDate(new Expenses("Расход", DateTime.Now, 10000, "Еда"));
                logbook.AddDate(new Expenses("Расход", DateTime.Now, 15000, "Одежда"));

                logbook.Print();

                Console.WriteLine($"Количество созданных объектов Payment: {payment.GetObjectCount()}");
                Console.WriteLine($"Количество созданных объектов Logbook: {logbook.GetObjectCount()}");
            
            }
            catch (Exception ex) { Console.WriteLine($"Произошла ошибка: {ex.Message}"); }
        }
    }
}
