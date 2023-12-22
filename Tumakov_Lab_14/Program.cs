namespace Tumakov_Lab_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // YPR 14.1
            Bank account = new Bank(600, Type_Akk.Balance, "George");
            account.DumpToScreen();
            // DZ 14.1

        }
    }
}
