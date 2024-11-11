using System;

namespace Фабричный
{
    public class ConcreteCreator2 : Creator
    {
        public override Product FactoryMethod(string info)
        {
            return new ConcreteProduct2(info);
        }
    }
}
