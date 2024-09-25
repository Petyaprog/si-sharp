using System;

namespace морской_бой
{
    internal class Program
    {

        static void Array(int rows, int cols, char[,] array, char[] nameCols)
        {
            int currentX = Console.CursorLeft; 
            int currentY = Console.CursorTop; 

            Console.SetCursorPosition(currentX + 2, currentY);

            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{nameCols[j]} ");
            }
            Console.WriteLine();

            for (int i = 1; i < cols; i++)
            {
                int k = i;
                if (k == 10) k = 0;
                Console.Write($"{k} ");
                for (int j = 1; j < rows; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Input(int a, int f, char[,] array, char[] nameCols)
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
                        break;
                    }

                    if (inputRows <= 0 || inputRows > 10)
                    {
                        Console.WriteLine($"Введено неправильное значение {inputRows}");
                        break;
                    }

                    array[inputRows, k + 1] = 'X';

                    Console.Clear();

                    Array(rows, cols, array, nameCols);
                }
            }
        }

        static void Main(string[] args)
        {
            int rows = 11;
            int cols = 11;
            int s = 0;

            char[] nameCols = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И' };

            char[,] array = new char[rows, cols];
            
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    array[i, j] = '_';
                }
            }

            Array(rows, cols, array, nameCols);

            for (int i = 1; i <= 4; i++)
            {
                
                Console.WriteLine();

                Console.WriteLine("Выберите корабль который хотите установить и нажмите соответствующую клавишу ");
                Console.WriteLine("4 палубный кол-во(1) - 1");
                Console.WriteLine("3 палубный кол-во(2) - 2");
                Console.WriteLine("2 палубный кол-во(3) - 3 ");
                Console.WriteLine("1 палубный кол-во(4) - 4 ");

                int a = int.Parse(Console.ReadLine());

                if (a == s)
                {
                    Console.WriteLine("Такой корабль уже установлен");
                    break;
                }

                Console.Clear();

                Array(rows, cols, array, nameCols);

                switch (a)
                {
                    case 1:
                        Input(a, 4, array, nameCols);
                        s = 1;
                        break;
                    case 2:
                        Input(a, 3, array, nameCols);
                        s = 2;
                        break;
                    case 3:
                        Input(a, 2, array, nameCols);
                        s = 3;
                        break;
                    case 4:
                        Input(a, 1, array, nameCols);
                        s = 4;
                        break;

                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }

            }
            
            Console.ReadLine();
            
        }
    }
}
