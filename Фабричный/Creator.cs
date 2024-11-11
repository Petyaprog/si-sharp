using System;

namespace Фабричный
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod(string info);

        public string AnOperation(string info)
        { 
            Product product = FactoryMethod(info);

            product.Transform();
            product.Transform();

            return product.GetInfo();
        }
    }
}
