using System;

namespace Учет_денежных_средств
{
    public struct PaymentInfo
    {
        public DateTime Date;
        public int Amount;
        public string Description;

        public PaymentInfo(DateTime date, int amount, string description)
        {
            Date = date;
            Amount = amount;
            Description = description;
        }
    }
}
