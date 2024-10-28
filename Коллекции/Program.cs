using System;
using System.Collections.Generic;

namespace Коллекции
{
    internal class Program
    {
        public static void ConclusionDictionary(Dictionary<int, string> Writers)
        {
            foreach (var item in Writers)
            {
                Console.WriteLine($"Номер: {item.Key} Значение {item.Value}");
            }
        }

        public static void ConclusionList(List<string> Animals)
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

        public static void Menu1() //Список
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1 - Вывод по номеру элемента");
            Console.WriteLine("2 - Узнать длину");
            Console.WriteLine("3 - Добавить n элементов");
            Console.WriteLine("4 - Искать элемент");
            Console.WriteLine("5 - Удалять элементы");
            Console.WriteLine("6 - Изменить порядок элементов");
            Console.WriteLine("7 - Переход к словарю");
        }

        public static void Menu2() //Словарь
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1 - Добавить n элементов");
            Console.WriteLine("2 - Искать элемент");
            Console.WriteLine("3 - Удалять элементы");
            Console.WriteLine("4 - Выход");
        }

        static void Main(string[] args)
        {
            List<string> Animals = new List<string>(30)
            {
                "Goat",
                "Goose",
                "Hamster"
            };
           
            Menu1();
            bool output = true;

            while (output)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {     
                    switch (num)
                    {
                        case 1:
                            Console.Write("Введите номер элемента: ");
                            int NumItem = int.Parse(Console.ReadLine());
                            Console.WriteLine(Animals[NumItem - 1]);
                            Console.WriteLine("Нажмите Enter");
                            KeyDown();
                            Menu1();
                            break;
                        case 2:
                            Console.WriteLine($"Длинна списка: {Animals.Count}");
                            Console.WriteLine("Нажмите Enter");
                            KeyDown();
                            Menu1();
                            break;
                        case 3:
                            Console.WriteLine("Список до добавления");
                            ConclusionList(Animals);
                            Console.Write("Введите кол-во элементов для добавления: ");
                            int AddNumItem = int.Parse(Console.ReadLine());

                            for (int i = 0; i < AddNumItem; i++)
                            {
                                Console.Write($"{i + 1}-ый элемент: ");
                                Animals.Add(Console.ReadLine());
                            }
                            Console.WriteLine("Список после добавления");
                            ConclusionList(Animals);
                            Console.WriteLine("Нажмите Enter");
                            KeyDown();
                            Menu1();
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
                            Menu1();
                            break;
                        case 5:
                            ConclusionList(Animals);
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
                                    ConclusionList(Animals);
                                }
                                else
                                {
                                    Console.WriteLine("Неверный номер элемента. Попробуйте снова.");
                                    i--;
                                }
                            }
                            Console.WriteLine("Нажмите Enter");
                            KeyDown();
                            Menu1();
                            break;
                        case 6:
                            Console.WriteLine("Список по возрастанию");
                            ConclusionList(Animals);

                            Animals.Reverse();

                            Console.WriteLine("\nСписок по убыванию");
                            ConclusionList(Animals);
                            Console.WriteLine("Нажмите Enter");
                            KeyDown();
                            Menu1();
                            break;
                        case 7:
                            output = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Введен недопустимый символ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Повторите попытку, нажав Enter");
                    KeyDown();
                    Menu1();
                }
            }

            Dictionary<int, string> Writers = new Dictionary<int, string>()
            {
                { 1, "Пушкин" },
                { 2, "Есенин" },
                { 3, "Булгаков" },
            };

            Menu2();
            output = true;

            while (output)
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Словарь до добавления");
                        ConclusionDictionary(Writers);
                        Console.WriteLine("\nСколько писателей добавить?");
                        int count = int.Parse(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Введите номер писателя: ");
                            if (int.TryParse(Console.ReadLine(), out int id))
                            {
                                Console.Write("Введите фамилию писателя: ");
                                string name = Console.ReadLine();
                                Writers[id] = name;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, нужно в виде числа.");
                            }
                        }
                        Console.WriteLine("\nСловарь после добавления");
                        ConclusionDictionary(Writers);

                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Menu2();
                        break;
                    case 2:
                        Console.WriteLine("Введите номер элемента для поиска");
                        int Dnum = int.Parse(Console.ReadLine());

                        if (Writers.ContainsKey(Dnum))
                        {
                            Console.WriteLine($"Писатель: {Writers[Dnum]}");
                        }
                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Menu2();
                        break;
                    case 3:
                        ConclusionDictionary(Writers);
                        Console.Write($"Введите кол-во элементов для удаления. Всего их: {Writers.Count}: ");
                        int NumDel = int.Parse(Console.ReadLine());

                        for (int i = 0; i < NumDel; i++)
                        {
                            Console.Write($"\nВведите номер элемента. Всего их: {Writers.Count}: ");
                            int NumItemDel = int.Parse(Console.ReadLine());

                            if (Writers.ContainsKey(NumItemDel))
                            {
                                Console.WriteLine($"Элемент {Writers[NumItemDel]} удален");
                                Writers.Remove(NumItemDel);
                                Console.WriteLine();
                                ConclusionDictionary(Writers);
                            }
                            else
                            {
                                Console.WriteLine("Неверный номер элемента. Попробуйте снова.");
                                i--;
                            }
                        }
                        Console.WriteLine("Нажмите Enter");
                        KeyDown();
                        Menu2();
                        break;
                    case 4:
                        output = false;
                        break;
                }
            }
        }
    }
}