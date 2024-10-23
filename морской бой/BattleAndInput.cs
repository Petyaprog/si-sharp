using System;

namespace морской_бой
{
    internal class BattleAndInput
    {
        public void KeyDown()
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }
        public void Battle(char[,] array, char[,] array2, char[,] array3, char[,] array4, string[] name, char[] nameCols, int k)
        {
            Field field = new Field();
            int s = 0;
            do
            {
                int b = 0;
                int q = 0;
                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if (array[i, j] == 'X') q = 1;
                        if (array2[i, j] == 'X') b = 2;
                    }
                }
                if ((q != 1) && (b == 2))
                {
                    Console.Clear();
                    Console.WriteLine("Бой окончен");
                    Console.WriteLine("Победил второй игрок ");
                    Program.c = 3;
                    break;
                }

                if ((q == 1) && (b != 2))
                {
                    Console.Clear();
                    Console.WriteLine("Бой окончен");
                    Console.WriteLine("Победил первый игрок ");
                    Program.c = 3;
                    break;
                }

                field.Pole(array, array2, nameCols, k, name);
                field.Pole2(array3, array4, name, nameCols, k);

                Console.WriteLine("Бой (* - попал; + - промазал)");
                Console.WriteLine($"Стреляет {name[k]}");

                string input = Console.ReadLine().ToUpper();

                char x = input[0];

                int y = (char)input[1] - (char)'0';

                b = 0;
                for (int i = 0; i < nameCols.Length; i++)
                {
                    if (nameCols[i] == x)
                    {
                        b = i;
                        break;
                    }
                }
                b++;
                if (k == 0)
                {

                    if (array2[y, b] == 'X')
                    {
                        Console.WriteLine("попал");
                        array3[y, b] = '*';
                        array2[y, b] = '*';
                        KeyDown();
                    }
                    else
                    {
                        Console.WriteLine("промазал");
                        array3[y, b] = '+';
                        s = 1;
                        KeyDown();
                    }

                }
                if (k == 1)
                {
                    if (array[y, b] == 'X')
                    {
                        Console.WriteLine("попал");
                        array4[y, b] = '*';
                        array[y, b] = '*';
                        KeyDown();
                    }
                    else
                    {
                        Console.WriteLine("промазал");
                        array4[y, b] = '+';
                        s = 1;
                        KeyDown();
                    }
                }
            }
            while (s != 1);
        }

        public void Input(int a, int f, char[,] array, char[] nameCols, char[,] array2, string[] name, int k)
        {
            Field field = new Field();
            try
            {
                for (int d = a; d >= 1; d--)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Введите координаты {f} палубного корабля. Осталось ввести:{d}");

                    string input = Console.ReadLine().ToUpper();

                    char inputCols = input[0];

                    int inputRows = (char)input[1] - (char)'0';

                    if (input.Length >= 3 && input[1] == '1' && input[2] == '0')
                    {
                        inputRows = 10;
                    }

                    Console.WriteLine();

                    int s = -1;

                    for (int i = 0; i < nameCols.Length; i++)
                    {
                        if (nameCols[i] == inputCols)
                        {
                            s = i;
                            break;
                        }
                    }

                    Console.WriteLine("Выберите направление размещения корабля:");
                    Console.WriteLine("1 - Вертикально");
                    Console.WriteLine("2 - Горизонтально");

                    int direction = int.Parse(Console.ReadLine());

                    if (direction == 1)
                    {
                        for (int i = 0; i < f; i++)
                        {
                            if (name[k] == "Первый игрок: ")
                            {
                                array[inputRows + i, s + 1] = 'X';
                            }
                            else
                            {
                                array2[inputRows + i, s + 1] = 'X';
                            }
                        }
                    }
                    else if (direction == 2)
                    {
                        for (int i = 0; i < f; i++)
                        {
                            if (name[k] == "Первый игрок: ")
                            {
                                array[inputRows, s + i + 1] = 'X';
                            }
                            else
                            {
                                array2[inputRows, s + i + 1] = 'X';
                            }
                        }
                    }

                    Console.Clear();

                    field.Pole(array, array2, nameCols, k, name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
