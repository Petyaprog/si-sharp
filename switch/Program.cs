using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console .ReadLine());

            switch (a)
            {
                case 0:
                    Console.WriteLine("Вы ввели 0");
                    break;
                case 1: 
                    Console.WriteLine("Вы ввели 1");
                    break;
                default: 
                    Console.WriteLine("Введите 0 или 1");
                    break;
            }
            Console.ReadLine();
        }
    }
}
