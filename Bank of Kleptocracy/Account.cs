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
        public string Pin { get; }
        public int Balance { get; set; }

        public Account(Random rnd)
        {
            AccountNumber = rnd.Next(1111,9999);
            Pin = rnd.Next(1111,9999).ToString();
            Balance = rnd.Next(1000000);
        }

        public Account(int accountNumber, string pin, int balance = 0)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Balance = balance;
        }

        public bool CheckPin(string pin)
        {
            return Pin == pin;
        }

        public void Print()
        {
            Console.WriteLine("Account Number: " + AccountNumber + "\t" + "Pin: " + Pin + "\t" + "Balance: " + Balance);
        }
    }
}
