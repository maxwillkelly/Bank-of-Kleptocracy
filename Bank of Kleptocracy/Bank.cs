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
		private Semaphore sem = new Semaphore(0, 1);

		//* vars
		private Account[] accounts;
		public int BankNumber { get; }

		//* initialize this class
		public Bank()
		{
			InitializeComponent();
        }

		//* Initialize a number of accounts with random data
		public void InitAccounts(int n)
		{
			try
			{
				sem.WaitOne();

				accounts = new Account[n];
				Random rnd = new Random();
				for (int i = 0; i < n; i++)
				{
					accounts[i] = new Account(rnd);
				}
			}
			finally
			{
				sem.Release();
			}
		}

		//* print all the data of every account
		public void Print()
		{
			try
			{
				sem.WaitOne();

				Console.WriteLine("Bank Number: " + BankNumber);
				foreach (var account in accounts)
				{
					account.Print();
				}
			}
			finally
			{
				sem.Release();
			}
		}
		
		//* check if account with passed account number exists
		public int checkPin(int accNum, string pin)
		{
			try
			{
				sem.WaitOne();

				for (int i = 0; i < accounts.Length; i++)
				{
					if (accNum == accounts[i].AccountNumber)
					{
						if(pin == accounts[i].Pin)
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
				sem.Release();
			}
		}

		//* check account's balance
		public int balanceCheck(int accNum, string pin)
		{
			try
			{
				sem.WaitOne();

				int accIndex = checkPin(accNum, pin);
				if (accIndex >= 0)
				{
					return accounts[accIndex].Balance; //* account balance
				}
				else if(accIndex == -1)
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
				sem.Release();
			}
		}

		//* withdraw from account's balance
		public int balanceWithdraw(int accNum, string pin, int amount)
		{
			try
			{
				sem.WaitOne();

				int accIndex = checkPin(accNum, pin);
				if (accIndex >= 0)
				{
					if(amount<=accounts[accIndex].Balance)
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
				sem.Release();
			}
		}

		//* deposit into account's balance
		public int balanceDeposit(int accNum, string pin, int amount)
		{
			try
			{
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
				sem.Release();
			}
		}
	}
}
