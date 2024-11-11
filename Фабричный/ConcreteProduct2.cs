using System;

namespace Фабричный
{
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
}
