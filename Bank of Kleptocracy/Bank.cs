using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_of_Kleptocracy
{
    public partial class Bank : Form
    {
        private Account[] accounts;
        public int BankNumber { get; }

        public Bank()
        {
            InitializeComponent();
        }

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

        public void Print()
        {
            Console.WriteLine("Bank Number: " + BankNumber);
            foreach (var account in accounts)
            {
                account.Print();
            }
        }
    }
}
