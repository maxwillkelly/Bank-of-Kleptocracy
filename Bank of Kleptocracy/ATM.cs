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
    public partial class ATM : Form
    {
        const string branchName = "Bank of Kleptocracy";
        Bank[] banks;
        Account activeAccount;
        Card cardInserted;

        public ATM()
        {
            InitializeComponent();
        }

        public void InitBanks()
        {
            banks = new Bank[10];
        }

        public Account FindAccount(int accountNumber, int bankNumber)
        {
            for (int i = 0; i < banks.Length; i++)
            {
                if (banks[i].bankNumber == bankNumber)
                {
                    return banks[i].GetAccount(accountNumber);
                }
            }
            return null;
        }

        public int CheckBalance()
        {
            if (activeAccount == null)
                return -1;
            return activeAccount.balance;
        }

        public bool InsertCard()
        {
            return false;
        }

        public bool EjectCard()
        {
            return false;
        }

        public bool Withdraw(int amount)
        {
            return true;
        }
    }
}
