using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kleptocracy
{
    public class Account
    {
        public int accountNumber { get; }
        public int pin { get; }
        public int balance { get; }

        public Account(int accountNumber, int pin, int balance = 0)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.balance = balance;
        }

        public bool CheckPin(int pin)
        {
            return this.pin == pin;
        }
    }
}
