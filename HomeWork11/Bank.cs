using System;

namespace HomeWork11
{
    public enum Type_Akk
    {
        Balance,
        SberKniga
    }
    internal class Bank
    {
        private BankTransaction[] transactions;
        public decimal balance { get; }
        public string AccountHolder { get; set; }
        public string Id { get; }
        public Type_Akk _type { get; }
        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
            set { transactions[index] = value; }
        }
        public Bank(decimal balance, Type_Akk _type, string AccountHolder)
        {
            this.balance = balance;
            this._type = _type;
            this.AccountHolder = AccountHolder;
            transactions = new BankTransaction[100];
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Transfer(Bank bank1, decimal sum, decimal balance)
        {
            if (balance < sum)
            {
                Console.WriteLine("No money");
            }
            else
            {
                BankTransaction transaction = new BankTransaction(sum);
                balance -= sum;

            }
        }
    }
}