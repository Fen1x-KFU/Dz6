using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    public class BankScore3
    {
        private string bankscore3;
        private decimal balanceAccount3;
        private TypeAccount typeAccount3;
        private decimal takeOffBalance3;
        private decimal addOffBalance3;
        private decimal copybalance;

        public BankScore3(string bankscore, decimal balanceAccount, string typeAccount, decimal takeOffBalance, decimal addOffBalance)
        {
            copybalance = balanceAccount;
            bankscore3 = bankscore;
            balanceAccount3 = balanceAccount;
            typeAccount3 = new TypeAccount();
            TryParsAccount3(typeAccount);
            balanceAccount3 = IncreaseScore(addOffBalance);
            balanceAccount3 = DecreaseScore(takeOffBalance);
        }

        public BankScore3()
        {
            copybalance = 0;
            bankscore3 = "неопрежидён";
            balanceAccount3 = 0;
            typeAccount3 = new TypeAccount();
            typeAccount3 = (TypeAccount)2;
            balanceAccount3 = IncreaseScore(addOffBalance3);
        }
        public void TryParsAccount3(string type)
        {
            if (type == "Сберегательный")
            {
                typeAccount3 = (TypeAccount)0;
            }
            else if (type == "Тукцщий")
            {
                typeAccount3 = (TypeAccount)1;
            }
            else
            {
                typeAccount3 = (TypeAccount)2;
            }
        }

        public decimal DecreaseScore(decimal takeoffbalance)
        {
            if ((balanceAccount3 - takeoffbalance) >= 0)
            {
                return balanceAccount3 - takeoffbalance;
            }
            else { return balanceAccount3; }
        }

        public decimal IncreaseScore(decimal addoffbalance)
        {
            return balanceAccount3 + addoffbalance;
        }

        public void Print3()
        {
            Console.WriteLine($"Номер счета: {bankscore3}");
            Console.WriteLine($"Баланс: {copybalance}");
            Console.WriteLine($"Тип счета: {typeAccount3}");
            Console.WriteLine($"Ваш баланс обновлён: {balanceAccount3}");
        }
    }
}
