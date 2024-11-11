using System;

namespace Фабричный_метоод
{
    public class ConcreteCreator1 : Creator
    {
       /* public string info { get; set; }

        public ConcreteCreator1(string info) : base()
        {
            this.info = info;
        }*/

        public override Product FactoryMethod(string info) 
        {
            return new ConcreteCreator1(info);
        }
    }
}
