using System;

namespace Регулярные_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Мир таков, каков он есть.";
            string s2 = "На Патриарших прудах в Москве.";

            Console.WriteLine($"s1: {s1}\ns2: {s2}\n");

            int result = string.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2\n");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2\n");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны\n");
            }

            Console.WriteLine("Поиск подстроки");
            Console.Write("Выберите строку: ");
            string str2 = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string str = Console.ReadLine();
            bool indexOfChar = false;
            if (str2 != "s1" && str2 != "s2")
            {
                Console.WriteLine("Ошибка: такой строки нет");
            }
            else
            {
                if (str2 == "s1")
                {
                    str2 = s1;
                    indexOfChar = str2.Contains(str);
                    str2 = "s1";
                }
                else
                if (str2 == "s2")
                {
                    str2 = s2;
                    indexOfChar = str2.Contains(str);
                    str2 = "s2";
                }

                if (indexOfChar)
                {
                    Console.Write($"В строке {str2} подстрока '{str}' находится на позиции: ");
                    if (str2 == "s1") str2 = s1; else str2 = s2;
                    Console.WriteLine(str2.IndexOf(str) + 1);
                }
                else { Console.WriteLine($"В строке {str2} подстрока '{str}' не найдена"); }
            }

            str = s1 + " " + s2;
            Console.WriteLine($"\nСоединение строк: \n{str}\n");

            Console.Write("Смена регистра строки s2: ");
            Console.WriteLine(s2.ToUpper());

            Console.WriteLine("\nРабота с текстом");
            string text = "Свяжитесь со мной по телефону +7 (999) 123-45-67 или напишите на email: myemail@example.com. \n" +
                "Я буду рад, если вы свяжетесь со мной. Пожалуйста, не стесняйтесь и свяжитесь со мной любым удобным способом. \n" +
                "Жду вашего звонка или сообщения на email!";
            Console.WriteLine(text);

        }
    }
}
