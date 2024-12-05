using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    public class BankScore2
    {
        private string bankscore2;
        private decimal balanceAccount2;
        private TypeAccount typeAccount2;
        static private int count = 0;
        private int identificator;
        
        public BankScore2(string bankscore, decimal balanceAccount, string typeAccount)
        {
            bankscore2 = bankscore;
            balanceAccount2 = balanceAccount;
            typeAccount2 = new TypeAccount();
            TryParsAccount2(typeAccount);
            Counter();
            identificator = count;
        }

        public BankScore2()
        {
            bankscore2 = "неопредилён";
            balanceAccount2 = 0;
            typeAccount2 = new TypeAccount();
            typeAccount2 = (TypeAccount)2;
            Counter();
            identificator = count;
        }

        public void TryParsAccount2(string type)
        {
            if (type == "Сберегательный")
            {
                typeAccount2 = (TypeAccount)0;
            }
            else if (type == "Тукцщий")
            {
                typeAccount2 = (TypeAccount)1;
            }
            else
            {
                typeAccount2 = (TypeAccount)2;
            }
        }

        private void Counter()
        {
            count++;
        }

        public void Print2()
        {
            Console.WriteLine($"Номер счета: {bankscore2}");
            Console.WriteLine($"Баланс: {balanceAccount2}");
            Console.WriteLine($"Тип счета: {typeAccount2}");
            Console.WriteLine($"Вы создали {identificator} экземпляр!");
        }
    }


}
