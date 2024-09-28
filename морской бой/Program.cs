using System;
using static System.Net.Mime.MediaTypeNames;

namespace морской_бой
{
    internal class Program
    {

        //static void Pole(int rows, int cols, char[,] array, char[,] array2, string[] name)
        //{
            
        //}

        static void Array(int rows, int cols, char[,] array, char[,] array2, char[] nameCols)
        {
            for (int f = 0; f < 2; f++)
            {
                Console.Write("  ");
                for (int j = 0; j < 10; j++)
                    Console.Write($"{nameCols[j]} ");
                Console.WriteLine();
            
                for (int i = 1; i < cols; i++)
                {
                    int k = i;
                    if (k == 10) k = 0;
                    Console.Write($"{k} ");
                    for (int j = 1; j < rows; j++)
                    {
                        if (f == 0)
                            Console.Write($"{array[i, j]} ");
                        else
                            Console.Write($"{array2[i, j]} ");
                    }
                    Console.WriteLine();
                }
                if (f == 0) Console.WriteLine("\t Вы");
                else Console.WriteLine("\tПротивник");

                Console.WriteLine();
            }
        }

        static void Input(int a, int f, char[,] array, char[] nameCols, char[,] array2)
        {
            int rows = 11;
            int cols = 11;

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

                    int k = -1;

                    for (int i = 0; i < nameCols.Length; i++)
                    {
                        if (nameCols[i] == inputCols)
                        {
                            k = i;
                            break;
                        }
                    }

                    if (k == -1)
                    {
                        Console.WriteLine($"Символ {inputCols} не найден");
                        Console.ReadLine();
                        d++;
                        Console.Clear();
                        Array(rows, cols, array, array2, nameCols);
                        break;

                    }

                    if (inputRows <= 0 || inputRows > 10)
                    {
                        Console.WriteLine($"Введено неправильное значение {inputRows}");
                        Console.ReadLine();
                        d++;
                        Console.Clear();
                        Array(rows, cols, array, array2, nameCols);
                        break;
                    }

                    array[inputRows, k + 1] = 'X';

                    Console.Clear();

                    Array(rows, cols, array, array2, nameCols);
                }

            }
        }

        static void Main(string[] args)
        {
            //Console.SetWindowSize(310, 200);
            int rows = 11;
            int cols = 11;

            int [] s = new int[4];
            char[] nameCols = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'К' };
            string[] name = { "Первый игрок: ", "Второй игрок: "};
            char[,] array = new char[rows, cols];
            char[,] array2 = new char[rows, cols];

            for (int k = 0; k < 2; k++)
            {
                for (int i = 1; i < rows; i++)
                {
                    for (int j = 1; j < cols; j++)
                    {
                        if (name[k] == "Первый игрок: ")
                            array[i, j] = '_';
                        else array2[i, j] = '_';
                    }
                }
            }

            for (int k = 0; k < 2; k++) 
            {
               
                Console.WriteLine($"{name[k]}");
                Console.WriteLine();

                for (int i = 1; i <= 4; i++)
                {

                    Array(rows, cols, array, array2, nameCols);

                    Console.WriteLine("Выберите корабль который хотите установить и нажмите соответствующую клавишу ");
                    Console.WriteLine("4 палубный кол-во(1) - 1");
                    Console.WriteLine("3 палубный кол-во(2) - 2");
                    Console.WriteLine("2 палубный кол-во(3) - 3");
                    Console.WriteLine("1 палубный кол-во(4) - 4");

                    int a = int.Parse(Console.ReadLine());

                    if (a == s[0] || a == s[1] || a == s[2] || a == s[3])
                    {
                        Console.WriteLine("Такой корабль уже установлен");
                        break;
                    }

                    Console.Clear();
                    Array(rows, cols, array, array2, nameCols);

                    switch (a)
                    {
                        case 1:
                            Input(a, 4, array, nameCols, array2);
                            s[0] = 1;
                            break;
                        case 2:
                            Input(a, 4, array, nameCols, array2);
                            s[1] = 2;
                            break;
                        case 3:
                            Input(a, 4, array, nameCols, array2);
                            s[2] = 3;
                            break;
                        case 4:
                            Input(a, 4, array, nameCols, array2);
                            s[3] = 4;
                            break;

                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }

                }
            }

            //Console.Clear();

            ////Console.WriteLine("Второй игрок");

           
            //Array(rows, cols, array, nameCols);

            //Console.WriteLine();
            //Console.WriteLine("Бой");
            //Console.WriteLine("Стреляет первый игрок");

            //Console.Write("Столбец: ");
            //char x = char.Parse(Console.ReadLine().ToUpper());

            //Console.Write("Строка: ");
            //sbyte y = sbyte.Parse(Console.ReadLine());

            //int k = 0;
            //for (int i = 0; i < nameCols.Length; i++)
            //{
            //    if (nameCols[i] == x)
            //    {
            //        k = i;
            //        break;
            //    }
            //}

            //if (array[k, y] == 'X') 
            //{
            //    Console.WriteLine("попал");
            //    array[k, y] = '*';
            //    Console.Clear();
            //} 

            //else Console.WriteLine("промазал");



            Console.ReadLine();
            
        }
    }
}
