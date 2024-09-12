using System;
using System.Globalization;

namespace учу_сишарп
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Калькулятор");

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            try
            {
                Console.WriteLine("Введите первое число");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите действие (+  -  *  /)");
                string operand = Console.ReadLine();

                Console.WriteLine("Введите второе число");
                int num2 = int.Parse(Console.ReadLine());

                switch (operand)
                {
                    case "+":
                        Console.WriteLine($"Результат: {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Результат: {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Результат: {num1 * num2}");
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Делить на 0 нельзя");
                        }
                        else
                        {
                            Console.WriteLine($"Результат: {num1 / num2}");
                        }
                        break;
                    default:
                        Console.WriteLine("Не корректный символ");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}

