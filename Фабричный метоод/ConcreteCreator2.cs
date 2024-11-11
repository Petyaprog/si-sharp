using System;

namespace Фабричный_метоод
{
    public class ConcreteCreator2 : Creator
    {
        public override Product FactoryMethod(string info) { return new ConcreteCreator2(info); }

    }
}
