using System;

namespace Учет_денежных_средств
{
    internal interface ILogbook
    {
        void AddDate(Payment payment);
        void Print();
    }
}