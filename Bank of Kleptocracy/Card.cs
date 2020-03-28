using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kleptocracy
{
    class Card
    {
        public int AccountNumber { get; }
        public int BankNumber { get; }

        public Card(Random rnd)
        {
            AccountNumber = rnd.Next(111,9999);
            BankNumber = rnd.Next(100);
        }

        public Card(int accountNumber, int bankNumber)
        {
            AccountNumber = accountNumber;
            BankNumber = bankNumber;
        }

        public void Print()
        {
            Console.Write("Bank Number: " + BankNumber + "\t" + "Account Number: " + AccountNumber);
        }
    }
}
