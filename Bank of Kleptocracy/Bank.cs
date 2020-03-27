using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kleptocracy
{
    class Bank
    {
        private Account[] accounts;
        public int BankNumber { get; }

        public Bank(int bankNumber)
        {
            BankNumber = bankNumber;
            InitAccounts();
        }

        private void InitAccounts()
        {
            accounts = new Account[10];
        }

        public Account GetAccount(int accountNumber)
        {
            foreach (var account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }

            return null;
        }
    }
}
