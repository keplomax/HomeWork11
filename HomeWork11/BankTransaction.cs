using System;

namespace HomeWork11
{
    internal class BankTransaction
    {
        public decimal sum { get; }
        DateTime t_time
        { get; }
        public BankTransaction(decimal sum)
        {
            t_time = DateTime.Now;
            this.sum = sum;
        }

        public string Print()
        {
            return $"В {t_time} была проведена операция на сумму: {sum}";
        }
    }
}
