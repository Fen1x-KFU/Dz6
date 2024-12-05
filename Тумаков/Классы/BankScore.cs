using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    enum TypeAccount
    { 
        Сберегательный,
        Текущий,
        Неопредилён
    }
    public class BankScore
    {
        private string scoreNumerAccount;
        private decimal balanceAccount;
        private TypeAccount typeAccount;

        // Методы для доступа к данным - заполнение и чтение
        public BankScore(string scorenum, decimal balance, string type)
        {
            scoreNumerAccount = scorenum;
            balanceAccount = balance;
            typeAccount = new TypeAccount();
            TypeAccountParse(type);
        }

        public BankScore()
        {
            scoreNumerAccount = "неопредилён";
            balanceAccount = 0;
            typeAccount = new TypeAccount();
            typeAccount = (TypeAccount)2;
        }
       private void TypeAccountParse(string type) 
       {
            if (type == "Сберегательный")
            {
                typeAccount = (TypeAccount)0;
            }
            else if (type == "Текущий")
            {
                typeAccount = (TypeAccount)1;
            }
            else
            {
                typeAccount = (TypeAccount)2;
            }
       }
       public void Print()
       {
           Console.WriteLine($"Номер счета: {scoreNumerAccount}");
           Console.WriteLine($"Баланс: {balanceAccount}");
           Console.WriteLine($"Тип счета: {typeAccount}");
       }
    }
}
