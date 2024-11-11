﻿using System;

namespace Фабричный_метоод
{
    public class ConcreteProduct1 : Product
    {
        public string info { get; set; }

        public ConcreteProduct1(string info) :base()
        {
            this.info = info;
            info.ToLower();
        }
        

       public override string GetInfo() { return info; }

        public override void Transform()
        {
            string res = "";
            res += info[0];

            for (int i = 1; i < info.Length - 1; i++)
            {
                if (info[i] != ' ')  res += " " + info[i];
            }
            info = res;
        }
    }
}
