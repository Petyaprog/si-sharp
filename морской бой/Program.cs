using System;

namespace морской_бой
{
    internal class Program
    {

        static void Pole2(char[,] array3, char[,] array4, string[] name, char[] nameCols, int k)
        {

            for (int j = 0; j < 10; j++)
                Console.Write($"{nameCols[j]} ");
            Console.WriteLine();

            for (int i = 1; i < 11; i++)
            {
                int z = i;
                if (z == 10) z = 0;
                Console.Write($"{z} ");
                for (int j = 1; j < 11; j++)
                {
                    if (name[k] == "Первый игрок: ")
                        Console.Write($"{array4[i, j]} ");
                    else
                        Console.Write($"{array3[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\tПротивник");
            Console.WriteLine();
        }

        static void Pole(char[,] array, char[,] array2, char[] nameCols, int k, string[] name)
        {
            Console.WriteLine($"{name[k]}");
            Console.WriteLine();
            Console.Write("  ");

            for (int j = 0; j < 10; j++)
                Console.Write($"{nameCols[j]} ");
                Console.WriteLine();
            
            for (int i = 1; i < 11; i++)
            {
                int z = i;
                if (z == 10) z = 0;
                Console.Write($"{z} ");
                for (int j = 1; j < 11; j++)
                {
                    if (name[k] == "Первый игрок: ")
                        Console.Write($"{array[i, j]} ");
                    else
                        Console.Write($"{array2[i, j]} ");
                }
                Console.WriteLine();
            }
             Console.WriteLine("\t Вы");
             Console.WriteLine();
        }

        static void Input(int a, int f, char[,] array, char[] nameCols, char[,] array2, string[] name, int k)
        {

            for (int d = a; d >= 1; d--)
            {
                for (int n = 1; n <= f; n++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Введите координаты {f} палубного корабля. Осталось ввести:{d}");

                    Console.Write("Столбец: ");
                    char inputCols = char.Parse(Console.ReadLine().ToUpper());

                    Console.Write("Строка: ");
                    sbyte inputRows = sbyte.Parse(Console.ReadLine());

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

                    if (s == -1)
                    {
                        Console.WriteLine($"Символ {inputCols} не найден");
                        Console.ReadLine();
                        d++;
                        Console.Clear();
                        Pole(array, array2, nameCols, k, name);
                        break;

                    }

                    if (inputRows <= 0 || inputRows > 10)
                    {
                        Console.WriteLine($"Введено неправильное значение {inputRows}");
                        Console.ReadLine();
                        d++;
                        Console.Clear();
                        Pole(array, array2, nameCols, k, name);
                        break;
                    }

                    if (name[k] == "Первый игрок: ")
                    {
                        array[inputRows, s + 1] = 'X';
                    }
                    else
                    {
                        array2[inputRows, s + 1] = 'X';
                    }

                    Console.Clear();

                    Pole(array, array2, nameCols, k, name);
                }

            }
        }

        static void Main(string[] args)
        {

            int [] s = new int[4];
            char[] nameCols = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'К' };
            string[] name = {"Первый игрок: ", "Второй игрок: "};
            char[,] array = new char[11, 11];
            char[,] array2 = new char[11, 11];
            char[,] array3 = new char[11, 11];
            char[,] array4 = new char[11, 11];
            int k;

            for (k = 0; k < 2; k++)
            {
                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if (name[k] == "Первый игрок: ")
                        {
                            array[i, j] = '_';
                            array3[i, j] = '_';
                        }
                        else
                        {
                            array2[i, j] = '_';
                            array4[i, j] = '_';
                        } 
                    }
                }
            }

            for (k = 0; k < 2; k++) 
            {
                for (int i = 1; i <= 2; i++)  /////  4
                {

                    Pole(array, array2, nameCols, k, name);

                    Console.WriteLine("Выберите корабль который хотите установить и нажмите соответствующую клавишу ");
                    Console.WriteLine("4 палубный кол-во(1) - 1");
                    Console.WriteLine("3 палубный кол-во(2) - 2");
                    Console.WriteLine("2 палубный кол-во(3) - 3");
                    Console.WriteLine("1 палубный кол-во(4) - 4");

                    int a = int.Parse(Console.ReadLine());

                    //if (a == s[0] || a == s[1] || a == s[2] || a == s[3])
                    //{
                    //    Console.WriteLine("Такой корабль уже установлен");
                    //    break;
                    //}

                    Console.Clear();
                    Pole(array, array2, nameCols, k, name);

                    switch (a)
                    {
                        case 1:
                            Input(a, 4, array, nameCols, array2, name, k);
                            s[0] = 2;
                            break;
                        case 2:
                            Input(a, 3, array, nameCols, array2, name, k);
                            s[1] = 2;
                            break;
                        case 3:
                            Input(a, 2, array, nameCols, array2, name, k);
                            s[2] = 3;
                            break;
                        case 4:
                            Input(a, 1, array, nameCols, array2, name, k);
                            s[3] = 4;
                            break;

                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    Console.Clear();
                }
               
            }

            Console.Clear();


            Pole(array, array2, nameCols, k, name);
            Pole2(array3, array4, name, nameCols, k);

            for (k = 0; k < 2; k++)
            {

                if (name[k] == "Первый игрок: ") 
                {
                    Console.WriteLine();
                    Console.WriteLine("Бой");
                    Console.WriteLine("Стреляет первый игрок");

                    Console.Write("Столбец: ");
                    char x = char.Parse(Console.ReadLine().ToUpper());

                    Console.Write("Строка: ");
                    sbyte y = sbyte.Parse(Console.ReadLine());

                    int c = 0;
                    for (int i = 0; i < nameCols.Length; i++)
                    {
                        if (nameCols[i] == x)
                        {
                            c = i;
                            break;
                        }
                    }

                    if (array2[c, y] == 'X')
                    {
                        Console.WriteLine("попал");
                        array4[c, y] = '*';
                        //k--;
                        Console.Clear();
                        Pole(array, array2, nameCols, k, name);
                        Pole2(array3, array4, name, nameCols, k);
                    }

                    else Console.WriteLine("промазал");
                } 

            }

            Console.ReadLine();
            
        }
    }
}
