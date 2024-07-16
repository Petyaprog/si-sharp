using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тернарный_оператор
{
    internal class Пример
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int output = (input < 0) ? -1 : input;

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
