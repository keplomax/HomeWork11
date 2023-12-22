using System;

namespace HomeWork11
{
    class Program
    {
        static void Main()
        {
            // YPR 13 
            Bank account = new Bank(1000, Type_Akk.SberKniga, "John Smith");
            Console.WriteLine($"Тип счета: {account._type}");
            Console.WriteLine($"Баланс: {account.balance}");
            Console.WriteLine($"Владелец: {account.AccountHolder}");

            BankTransaction transaction = new BankTransaction(500);
            Console.WriteLine($"Транзакция: {transaction.sum}");
            account[0] = new BankTransaction(500);
            account[1] = new BankTransaction(200);
            Console.WriteLine($"Перва транзакция:{account[0]}\n Вторая транзакция:{account[1]}");
            // DZ13
            Building building = new Building();

            Console.Write("Введите название здания: ");
            building.Name = Console.ReadLine();

            Console.Write("Введите количество этажей: ");
            building.Floors = int.Parse(Console.ReadLine());

            Console.Write("Введите площадь здания: ");
            building.Area = double.Parse(Console.ReadLine());

            Console.WriteLine("Информация о здании:");
            Console.WriteLine("Название: " + building.Name);
            Console.WriteLine("Количество этажей: " + building.Floors);
            Console.WriteLine("Площадь: " + building.Area);
            Buildings buildings = new Buildings();

            for (int i = 0; i < 10; i++)
            {
                Building buildin = new Building();

                Console.WriteLine("Введите информацию о здании #" + (i + 1));

                Console.Write("Название здания: ");
                buildin.Name = Console.ReadLine();

                Console.Write("Количество этажей: ");
                buildin.Floors = int.Parse(Console.ReadLine());

                Console.Write("Площадь здания: ");
                buildin.Area = double.Parse(Console.ReadLine());

                buildings[i] = buildin;
            }

            Console.WriteLine("\nИнформация о зданиях:");
            for (int i = 0; i < 10; i++)
            {
                Building buildin = buildings[i];

                Console.WriteLine("Здание #" + (i + 1));
                Console.WriteLine("Название: " + buildin.Name);
                Console.WriteLine("Количество этажей: " + buildin.Floors);
                Console.WriteLine("Площадь: " + buildin.Area);
                Console.WriteLine();
            }

        }
    }
}
