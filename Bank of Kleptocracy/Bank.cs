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
        public int bankNumber { get; }

        public Bank()
        {

        }

        public void InitAccount(int balance, int pin, int accountNumber)
        {

        }

        public Account GetAccount(int accountNumber)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].accountNumber == accountNumber)
                {
                    return accounts[i];
                }
            }
            return null;
        }
    }
}
