using System;

namespace Учет_денежных_средств
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logbook logbook = new Logbook();

                logbook.AddDate(new Logbook("Кирилл", 1486), new Profit("Доход", DateTime.Now, 50000, "З/П"));
                logbook.AddDate(new Logbook("Дима", 9876), new Payment(DateTime.Now, 1660, "Стипендия"));
                logbook.AddDate(new Logbook("Леша", 2464), new Payment(DateTime.Now, 10000, "Еда"));
                logbook.AddDate(new Logbook("Степа", 1135), new Payment(DateTime.Now, 15000, "Одежда"));

                logbook.Print();
            }
            catch (Exception ex) { Console.WriteLine($"Произошла ошибка: {ex.Message}"); }

            Console.ReadLine();
        }
    }
}
