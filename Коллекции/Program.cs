using System;
using System.Collections.Generic;

namespace Коллекции
{
    internal class Program
    {
        public static void Conclusion(List<string> Animals)
        {
            foreach (var item in Animals)
            {
                Console.WriteLine(item);
            }
        }
        public static void KeyDown()
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }
        public static void Menu()
        { 
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1 - Вывод по номеру элемента");
            Console.WriteLine("2 - Узнать длину");
            Console.WriteLine("3 - Добавить n элементов");
            Console.WriteLine("4 - Искать элемент");
            Console.WriteLine("5 - Удалять элементы");
            Console.WriteLine("6 - Изменить порядок элементов");
            Console.WriteLine("7 - Выход");
        }

        static void Main(string[] args)
        {
            List<string> Animals = new List<string>(30)
            {
                "Goat",
                "Goose",
                "Hamster"
            };

            Menu();
            bool output = true;

            while (output)
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Write("Введите номер элемента: ");
                        int NumItem = int.Parse(Console.ReadLine());
                        Console.WriteLine(Animals[NumItem - 1]);
                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Console.Clear();
                        Menu();
                        break;
                    case 2:
                        Console.WriteLine($"Длинна списка: {Animals.Count}");
                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Console.Clear();
                        Menu();
                        break;
                    case 3:
                        Console.WriteLine("Список до добавления");
                        Conclusion(Animals);
                        Console.Write("Введите кол-во элементов для добавления: ");
                        int AddNumItem = int.Parse(Console.ReadLine());

                        for (int i = 0; i < AddNumItem; i++)
                        {
                            Console.Write($"{i + 1}-ый элемент: ");
                            Animals.Add(Console.ReadLine());
                        }
                        Console.WriteLine("Список после добавления");
                        Conclusion(Animals);
                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Console.Clear();
                        Menu();
                        break;
                    case 4:
                        Console.WriteLine("Введите элемент для поиска");
                        string str = Console.ReadLine();

                        if (Animals.Contains(str))
                        {
                            Console.WriteLine($"Элемент {str} найден на позиции {Animals.IndexOf(str) + 1}");
                        }
                        else
                        {
                            Console.WriteLine("Такой элемент не содержится в списке");
                        }
                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Console.Clear();
                        Menu();
                        break;
                    case 5:
                        Conclusion(Animals);
                        Console.Write($"Введите кол-во элементов для удаления. Всего их: {Animals.Count}: ");
                        int NumDel = int.Parse(Console.ReadLine());

                        for (int i = 0; i < NumDel; i++)
                        {
                            Console.Write($"\nВведите номер элемента. Всего их: {Animals.Count}: ");
                            int NumItemDel = int.Parse(Console.ReadLine()) - 1;

                            if (NumItemDel >= 0 && NumItemDel < Animals.Count)
                            {
                                Console.WriteLine($"Элемент {Animals[NumItemDel]} удален");
                                Animals.RemoveAt(NumItemDel);
                                Console.WriteLine();
                                Conclusion(Animals);
                            }
                            else
                            {
                                Console.WriteLine("Неверный номер элемента. Попробуйте снова.");
                                i--;
                            }
                        }
                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Console.Clear();
                        Menu();
                        break;
                    case 6:
                        Console.WriteLine("Список по возрастанию");
                        Conclusion(Animals);

                        Animals.Reverse();

                        Console.WriteLine("\nСписок по убыванию");
                        Conclusion(Animals);
                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Console.Clear();
                        Menu();
                        break;
                    case 7:
                        output = false;
                        break;
                    default:
                        Console.WriteLine("Введите допустимый символ");
                        break;
                }
            }
        }
    }
}