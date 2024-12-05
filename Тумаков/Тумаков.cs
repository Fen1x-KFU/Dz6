using System;


namespace Тумаков
{
    public class Progrma
    {
        static void StartT(string n)
        {
            Console.WriteLine($"Задание {n}");
        }

        static void Task1()
        {
            StartT("7.1");

            Console.WriteLine("Введиет номер счёта:");
            string scorenum = Console.ReadLine();

            Console.WriteLine("Введите ваш баланс:");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance) == false)
            {
                Console.WriteLine("Вы ввели не число ");
            }

            Console.WriteLine("Введите тип банковского счёта. Он может быть 'Сберегательный' или 'Текущий'!");
            string type = Console.ReadLine();

            BankScore account = new BankScore(scorenum, balance, type);

            account.Print();
        }

        static void Task2()
        {
            StartT("7.2");

            Console.WriteLine("Введиет номер счёта:");
            string scorenum = Console.ReadLine();

            Console.WriteLine("Введите ваш баланс:");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance) == false)
            {
                Console.WriteLine("Вы ввели не число ");
            }

            Console.WriteLine("Введите тип банковского счёта. Он может быть 'Сберегательный' или 'Текущий'!");
            string type = Console.ReadLine();

            BankScore2 account2 = new BankScore2(scorenum, balance, type);

            account2.Print2();
        }

        static void Task3()
        {
            StartT("7.3");

            Console.WriteLine("Введиет номер счёта:");
            string scorenum = Console.ReadLine();

            Console.WriteLine("Введите ваш баланс:");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance) == false)
            {
                Console.WriteLine("Вы ввели не число!");
            }

            Console.WriteLine("Введите тип банковского счёта. Он может быть 'Сберегательный' или 'Текущий'!");
            string type = Console.ReadLine();

            Console.WriteLine("Введите сумму, на которую вы бы хотели пополнить свой баланс!");
            if (decimal.TryParse(Console.ReadLine(), out decimal aDDoFFBalance) == false)
            {
                Console.WriteLine("Вы ввели не число!");
            }

            Console.WriteLine("Введите сумму, которую вы бы хотели снять со своего сёта!");
            if (decimal.TryParse(Console.ReadLine(), out decimal takeoFFBalance) == false)
            {
                Console.WriteLine("Вы ввели не число!");
            }

            BankScore3 account = new BankScore3(scorenum, balance, type, takeoFFBalance, aDDoFFBalance );

            account.Print3();
        }
        static void Main()
        {
            Task1();
            Task2();
            Task3();
        }
    }
}