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
            s2 = "evev";
            s3 = "evvev";
            s4 = "evvvev";
            s5 = "rbrbrr";
            Console.WriteLine(s1);
            
            Console.WriteLine(creator1.AnOperation(s1));
        }
    }
}
