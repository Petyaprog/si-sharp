using System;

namespace Фабричный_метоод
{

    public abstract class Product
    {
        public abstract string GetInfo();
        public abstract void Transform();
    }


    public class ConcreteProduct1 : Product
    {
        public string info { get; set; }

        public ConcreteProduct1(string info)
        {
            this.info = info.ToLower();
        }

        public override string GetInfo() { return info; }

        public override void Transform()
        {
            string res = "";
            res += info[0];

            for (int i = 1; i < info.Length - 1; i++)
            {
                if (info[i] != ' ') res += " " + info[i];
            }
            info = res;
        }
    }


    public class ConcreteProduct2 : Product
    {
        public string info { get; set; }

        public ConcreteProduct2(string info)
        {
            this.info = info.ToUpper();
        }

        public override string GetInfo() { return info; }

        public override void Transform()
        {
            string res = "";
            res += info[0];
            for (int i = 1; i < info.Length - 1; i++)
            {
                if (info[i] != '*') res += "**" + info[i];
            }
            info = res;
        }
    }


    public abstract class Creator
    {
        public abstract Product FactoryMethod(string info);
    }


    public class ConcreteCreator1 : Creator
    {
        public override Product FactoryMethod(string info)
        {
            return new ConcreteProduct1(info);
        }
    }


    public class ConcreteCreator2 : Creator
    {
        public override Product FactoryMethod(string info)
        {
            return new ConcreteProduct2(info);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
