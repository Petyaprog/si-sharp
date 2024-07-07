using System;
using System.Globalization;

namespace учу_сишарп
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b;

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.WriteLine("Сложение двух чисел");

            try
            {
                Console.WriteLine("Введите число 1");
                a = float.Parse(Console.ReadLine(), numberFormatInfo);

                Console.WriteLine("Введите число 2");
                b = float.Parse(Console.ReadLine(), numberFormatInfo);

                Console.WriteLine("Результат " + (a + b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка конвертации");
            }

            Console.ReadLine();
        }
    }
}