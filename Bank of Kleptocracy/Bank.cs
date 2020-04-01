using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_of_Kleptocracy
{
    public partial class Bank : Form
    {
        /*
		try
		{
			sem.WaitOne();
			
			// do something
		}
		finally
		{
			sem.Release();
		}
		*/

        //* threads control

        bool isSemaphored = false;
        private Semaphore sem;

        //* vars
        private Account[] accounts;
        public int BankNumber { get; }

        //* initialize this class
        public Bank(bool IsSemaphored, Account[] accounts)
        {
            InitializeComponent();
            this.isSemaphored = IsSemaphored;
            if (isSemaphored)
            {
                sem = new Semaphore(0, 1);
            }
            this.accounts = accounts;
        }

        //* Initialize a number of accounts with random data
        /*public void InitAccounts(int n)
        {
            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    accounts.Append(new Account(rnd));
                }
            }
            finally
            {
                if (isSemaphored)
                    sem.Release();
            }
        }*/

        //* print all the data of every account
        public void Print()
        {
            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                Console.WriteLine("Bank Number: " + BankNumber);
                foreach (var account in accounts)
                {
                    account.Print();
                }
            }
            finally
            {
                if (isSemaphored)
                    sem.Release();
            }
        }

        //* check if account with passed account number and pin exists
        public int checkPin(int accNum, string pin)
        {
            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accNum == accounts[i].AccountNumber)
                    {
                        if (pin == accounts[i].Pin)
                        {
                            return i; //* account index
                        }
                        else
                        {
                            return -2; //* account found, but invalid pin
                        }
                    }
                }
                return -1; //* account not found
            }
            finally
            {
                if (isSemaphored)
                    sem.Release();
            }
        }

        //* check account's balance
        public int balanceCheck(int accNum, string pin)
        {
            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                int accIndex = checkPin(accNum, pin);
                if (accIndex >= 0)
                {
                    return accounts[accIndex].Balance; //* account balance
                }
                else if (accIndex == -1)
                {
                    return -1; //* account not found
                }
                else
                {
                    return -2; //* account found, but invalid pin
                }
            }
            finally
            {
                if (isSemaphored)
                    sem.Release();
            }
        }

        //* withdraw from account's balance
        public int balanceWithdraw(int accNum, string pin, int amount)
        {
            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                int accIndex = checkPin(accNum, pin);
                if (accIndex >= 0)
                {
                    if (amount <= accounts[accIndex].Balance)
                    {
                        accounts[accIndex].Balance -= amount;
                        return 0; //* withdrawal goes through
                    }
                    else return 1; //* not enough balance to withdraw
                }
                else if (accIndex == -1)
                {
                    return -1; //* account not found
                }
                else
                {
                    return -2; //* account found, but invalid pin
                }
            }
            finally
            {
                if (isSemaphored)
                    sem.Release();
            }
        }

        //* deposit into account's balance
        public int balanceDeposit(int accNum, string pin, int amount)
        {
            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                int accIndex = checkPin(accNum, pin);
                if (accIndex >= 0)
                {
                    if (accounts[accIndex].Balance + amount <= Int32.MaxValue)
                    {
                        accounts[accIndex].Balance += amount;
                        return 0; //* deposit goes through
                    }
                    else return 1; //* deposit exceeds allowed limit (come on, our bank isn't THAT safe...)
                }
                else if (accIndex == -1)
                {
                    return -1; //* account not found
                }
                else
                {
                    return -2; //* account found, but invalid pin
                }
            }
            finally
            {
                if (isSemaphored)
                    sem.Release();
            }
        }

        //* add a bank account 													<--- NEEDS ERROR CHECKING
        public int addAccount(int accountNumber, string pin, int balance = 0)
        {
            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                Account[] tempAccounts = new Account[accounts.Length + 1];
                for (int i = 0; i < accounts.Length; i++)
                {
                    tempAccounts[i] = accounts[i];
                }
				tempAccounts[accounts.Length] = new Account(accountNumber, pin, balance);
				
				return 0;
            }
			catch(IndexOutOfRangeException e)
			{
				Console.WriteLine("Index out of bounds in addAccount(). Likely an inconsistency in data. {0}", e);
				return -3; //* array out of bounds
			}
            finally
            {
                if (isSemaphored)
                    sem.Release();
            }
        }
    }
}
