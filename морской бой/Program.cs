using System;

namespace морской_бой
{
    internal class Program
    {

        public static int c = 0;

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
                Field.Pole(array, array2, nameCols, k, name);

                BattleAndInput.Input(1, 4, array, nameCols, array2, name, k);

                BattleAndInput.Input(2, 3, array, nameCols, array2, name, k);

                BattleAndInput.Input(3, 2, array, nameCols, array2, name, k);

                BattleAndInput.Input(4, 1, array, nameCols, array2, name, k);

                Console.Clear();
            }

            Console.Clear();

            for (; ;)
            {
                if (c == 3) break;
                BattleAndInput.Battle(array, array2, array3, array4, name, nameCols, 0);
                if (c == 3) break;
                BattleAndInput.Battle(array, array2, array3, array4, name, nameCols, 1);
                if (c == 3) break;
            }

        Console.ReadLine();
            
        }
    }
}
