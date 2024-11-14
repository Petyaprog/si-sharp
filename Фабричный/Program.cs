using System;

namespace Фабричный
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteCreator1 creator1 = new ConcreteCreator1();
            ConcreteCreator2 creator2 = new ConcreteCreator2();

            string s1, s2, s3, s4, s5;
            s1 = "veevev";
            s2 = "rrrrtt";
            s3 = "evvev";
            s4 = "qwqwqw";
            s5 = "rbrbrr";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine();
            
            Console.WriteLine(creator1.AnOperation(s1));
            Console.WriteLine(creator1.AnOperation(s2));
            Console.WriteLine(creator2.AnOperation(s3));
            Console.WriteLine(creator2.AnOperation(s4));
            Console.WriteLine(creator1.AnOperation(s5));
        }
    }
}
