using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kleptocracy
{
    class Card
    {
        private int accountNumber;
        private int bankNumber;

        Card()
        {
            Random rnd = new Random();
            accountNumber = rnd.Next(9999);
            bankNumber = rnd.Next(100);
        }

        Card(int accountNumber, int bankNumber)
        {
            this.accountNumber = accountNumber;
            this.bankNumber = bankNumber;
        }

        int getAccountNumber()
        {
            return accountNumber;
        }

        int getBankNumber()
        {
            return bankNumber;
        }
    }
}
