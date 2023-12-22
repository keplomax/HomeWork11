using System;
using System.Diagnostics;

namespace Tumakov_Lab_14
{
    public enum Type_Akk
    {
        Balance,
        SberKniga
    }
    internal class Bank
    {

        public decimal balance { get; }
        public string AccountHolder { get; set; }
        public string Id { get; }
        public Type_Akk _type { get; }

        public Bank(decimal balance, Type_Akk _type, string AccountHolder)
        {
            this.balance = balance;
            this._type = _type;
            this.AccountHolder = AccountHolder;

        }

        public decimal GetBalance()
        {
            return balance;
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine("Владелец аккаунта: {0} со счетом: {1}", AccountHolder, balance);
        }
    }
}
