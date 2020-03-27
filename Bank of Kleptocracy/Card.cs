using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kleptocracy
{
    class Card
    {
        public int AccountNumber { get; }
        public int BankNumber { get; }

        Card()
        {
            Random rnd = new Random();
            AccountNumber = rnd.Next(9999);
            BankNumber = rnd.Next(100);
        }

        Card(int accountNumber, int bankNumber)
        {
            AccountNumber = accountNumber;
            BankNumber = bankNumber;
        }
    }
}
