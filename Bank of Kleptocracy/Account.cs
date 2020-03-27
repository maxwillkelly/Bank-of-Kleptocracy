using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kleptocracy
{
    public class Account
    {
        public int AccountNumber { get; }
        public int Pin { get; }
        public int Balance { get; }

        public Account()
        {
            Random rnd = new Random();
            AccountNumber = rnd.Next(1111,9999);
            Pin = rnd.Next(1111,9999);
            Balance = rnd.Next(1000000);
        }

        public Account(int accountNumber, int pin, int balance = 0)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Balance = balance;
        }

        public bool CheckPin(int pin)
        {
            return Pin == pin;
        }
    }
}
