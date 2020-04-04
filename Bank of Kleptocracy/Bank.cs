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
    delegate void SetLogCallback(string text);

	public partial class Bank : Form
	{
		//* threads control

        bool isSemaphored = false;      //* set initial semaphoring status to false
        private Semaphore sem;

        //* vars
        private Account[] accounts;     //* array of accounts, initialized in the constructor
        // public int BankNumber { get; }

        //* initialize this class
        public Bank(bool IsSemaphored, Account[] accounts, string log)
		{
			InitializeComponent();
			this.isSemaphored = IsSemaphored; 	//* setting whether to use semaphores or not
			if (isSemaphored)
			{
				sem = new Semaphore(0, 1); 		//* initialize semaphore
				sem.Release(1); 				//* release initial semaphore
			}
			this.accounts = accounts;           //* initialize array of accounts
            appendLog(log);                     //* log function
		}

        private void appendLog(string log)
        {
            if (logBox.InvokeRequired) 
            {
                SetLogCallback d = appendLog;
                Invoke(d, log);
            }
            else
            {
                logBox.Text += log;
            }
		}

		//* initialize a number of accounts with random data
		// public void InitAccounts(int n)
		// {
		// 	try
		// 	{
		// 		if (isSemaphored)
		// 			sem.WaitOne();

        // 		Random rnd = new Random();
        // 		for (int i = 0; i < n; i++)
        // 		{
        // 			accounts.Append(new Account(rnd));
        // 		}
        // 	}
        // 	finally
        // 	{
        // 		if (isSemaphored)
        // 			sem.Release(1);
        // 	}
        // }

        //* check if account with passed account number and pin exists (used in first pin check, withdrawal, deposit, etc.)
        private int checkPinNoSem(int accNum, string pin)
        {
            for (int i = 0; i < accounts.Length; i++)       //* for each account
            {
                if (accNum == accounts[i].AccountNumber)    //* if the passed account number fits any in the list
                {
                    if (pin == accounts[i].Pin)             //* if the passed pin also fits
                    {
                        Thread.Sleep(1000);                 //* delay thread for demonstration purposes

                        appendLog("<BANK> PIN check successful\n");

                        return i;                           //* return account index
                    }
                    else
                    {
                        Thread.Sleep(1000);                 //* delay thread for demonstration purposes

                        appendLog("<BANK> PIN check unsuccessful\n");

                        return -2;                          //* return error code (account found, but invalid pin)
                    }
                }
            }

            appendLog("<BANK> Account with account number [" + accNum + "] not found\n");

            return -1;                                      //* return error code (account not found)
        }

		//* check if account with passed account number and pin exists (first check only, when user enters their pin)
		public int checkPin(int accNum, string pin)
		{
            appendLog("<BANK> Attempting to check PIN\n");
			
			try
			{
				if (isSemaphored)
					sem.WaitOne();

                logBox.Text += "<BANK> Attempting to check PIN\n";

		//* check account's balance
		public int balanceCheck(int accNum, string pin)
		{
			appendLog("<BANK> Attempting to check balance of account [" + accNum + "]\n");

        //* check account's balance
        public int balanceCheck(int accNum, string pin)
        {
            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                logBox.Text += "<BANK> Attempting to check balance of account [" + accNum + "]\n";

                int accIndex = checkPinNoSem(accNum, pin);  //* check and get index of account in use

                    appendLog("<BANK> Balance of account [" + accNum + "] is: [" + accounts[accIndex].Balance + "]\n");

                    return accounts[accIndex].Balance;      //* account balance
                }
                else
                {
                    Thread.Sleep(1000);                     //* delay thread for demonstration purposes

                    appendLog("<BANK> Balance check of account [" + accNum + "] failed\n");

                    return accIndex;                        //* return error code from the account check
                }
            }
            finally
            {
                if (isSemaphored)
                    sem.Release(1);
            }
        }

		//* withdraw from account's balance
		public int balanceWithdraw(int accNum, string pin, int amount)
		{
            appendLog("<BANK> Attempting to withdraw [" + amount + "] from balance of account [" + accNum + "]\n");

            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                logBox.Text += "<BANK> Attempting to withdraw [" + amount + "] from balance of account [" + accNum + "]\n";

                int accIndex = checkPinNoSem(accNum, pin);      //* check and get index of account in use

                        appendLog("<BANK> Withdrawn [" + amount + "] from balance of account [" + accNum + "]. New balance: " + accounts[accIndex].Balance +"\n");

                        logBox.Text += "<BANK> Withdrawn [" + amount + "] from balance of account [" + accNum + "]. New balance: " + accounts[accIndex].Balance + "\n";

                        appendLog("<BANK> Withdrawal of [" + amount + "] from balance of account [" + accNum + "] failed. Balance too low: [" + accounts[accIndex].Balance + "]\n");

                        return 1;                               //* return error code (not enough balance to withdraw)
                    }
                }
                else
                {
                    Thread.Sleep(1000);                         //* delay thread for demonstration purposes

                    appendLog("<BANK> Withdrawal of [" + amount + "] from balance of account [" + accNum + "] failed. Balance: [" + accounts[accIndex].Balance + "]\n");

                    return accIndex;                            //* return error code from the account check
                }
            }
            finally
            {
                if (isSemaphored)
                    sem.Release(1);
            }
        }

		//* deposit into account's balance
		public int balanceDeposit(int accNum, string pin, int amount)
		{
            appendLog("<BANK> Attempting to deposit [" + amount + "] to balance of account [" + accNum + "]\n");

            try
            {
                if (isSemaphored)
                    sem.WaitOne();

                logBox.Text += "<BANK> Attempting to deposit [" + amount + "] to balance of account [" + accNum + "]\n";

                int accIndex = checkPinNoSem(accNum, pin);                      //* check and get index of account in use

                        appendLog("<BANK> Deposited [" + amount + "] to balance of account [" + accNum + "]. New balance: [" + accounts[accIndex].Balance + "]\n");

                        return 0;                                               //* return success code (withdrawal goes through)
                    }
                    else
                    {
                        Thread.Sleep(1000); 									//* delay thread for demonstration purposes

                        appendLog("<BANK> Deposit of [" + amount + "] to balance of account [" + accNum + "] failed. Balance after deposit exceeds limit. Balance: [" + accounts[accIndex].Balance + "]\n");

                        return 1;                                               //* return error code (deposit exceeds allowed limit)
                    }
                }
                else
                {
                    Thread.Sleep(1000);                                         //* delay thread for demonstration purposes

                    appendLog("<BANK> Deposit of [" + amount + "] to balance of account [" + accNum + "] failed. Balance: [" + accounts[accIndex].Balance + "]\n");

                    return accIndex;                                            //* return error code from the account check
                }
            }
            finally
            {
                if (isSemaphored)
                    sem.Release(1);
            }
        }

        //* add a bank account
        // public int addAccount(int accNum, string pin, int balance = 0)
        // {
        // 	try
        // 	{
        // 		if (isSemaphored)
        // 			sem.WaitOne();

        // 		Account[] tempAccounts = new Account[accounts.Length + 1];
        // 		for (int i = 0; i < accounts.Length; i++)
        // 		{
        // 			tempAccounts[i] = accounts[i];
        // 		}
        // 		tempAccounts[accounts.Length] = new Account(accNum, pin, balance);

        // 		return 0;
        // 	}
        // 	catch (IndexOutOfRangeException e)
        // 	{
        // 		Console.WriteLine("Index out of bounds in addAccount(). Likely an inconsistency in data. {0}", e);
        // 		return -3; //* array out of bounds
        // 	}
        // 	finally
        // 	{
        // 		if (isSemaphored)
        // 			sem.Release(1);
        // 	}
        // }

        //* print the data of every account
        // public void Print()
        // {
        // 	try
        // 	{
        // 		if (isSemaphored)
        // 			sem.WaitOne();

        // 		Console.WriteLine("Bank Number: " + BankNumber);
        // 		foreach (var account in accounts)
        // 		{
        // 			account.Print();
        // 		}
        // 	}
        // 	finally
        // 	{
        // 		if (isSemaphored)
        // 			sem.Release(1);
        // 	}
        // }
    }
}
