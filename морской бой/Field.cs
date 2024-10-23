using System;

namespace морской_бой
{
    internal class Field
    {
        public void Pole2(char[,] array3, char[,] array4, string[] name, char[] nameCols, int k)
        {
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
                        Console.Write($"{array3[i, j]} ");
                    else
                        Console.Write($"{array4[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\tПротивник");
            Console.WriteLine();
        }

        public void Pole(char[,] array, char[,] array2, char[] nameCols, int k, string[] name)
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
    }
}
