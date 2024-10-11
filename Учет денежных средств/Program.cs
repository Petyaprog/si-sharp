using System;

namespace Учет_денежных_средств
{
    class Program
    {
        static void Main(string[] args)
        {
            Logbook logbook = new Logbook("Мой журнал", 11);

            logbook.AddDate(new Payment("23.02.2024", 10000, "Хавчик"), new Logbook("Петя", 55));
            logbook.AddDate(new Payment("23.02.2024", 10000, "аува"), new Logbook("Петя", 55));
            logbook.AddDate(new Payment("23.02.2024", 10000, "Хаукцквчик"), new Logbook("Петя", 55));
            logbook.AddDate(new Payment("23.02.2024", 10000, "2324"), new Logbook("Петя", 55));

            logbook.Print();
        }
    }
}
