using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyStruct
{
    struct Account
    {
        public int myMoney;
        public string name;

        public Account(int money, string name)
        {
            myMoney = money;
            this.name = name;
        }
        //입금
        public void deposit(int money)
        {
            myMoney += money;
        }
        //출금
        public void withdraw(int money)
        {
            myMoney -= money;
        }

    }
}
