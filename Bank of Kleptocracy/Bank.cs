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
		//* threads control

		bool isSemaphored = false; 		//* set initial semaphoring status to false
		private Semaphore sem;

		//* vars
		private Account[] accounts; 	//* array of accounts, initialised in the constructor
		// public int BankNumber { get; }

		//* initialize this class
		public Bank(bool IsSemaphored, Account[] accounts)
		{
			InitializeComponent();
			this.isSemaphored = IsSemaphored; 	//* setting whether to use semaphores or not
			if (isSemaphored)
			{
				sem = new Semaphore(0, 1); 		//* initialise semaphore
				sem.Release(1); 				//* release initial semaphore
			}
			this.accounts = accounts; 			//* initialise array of accounts
		}

		//* Initialize a number of accounts with random data
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
			for (int i = 0; i < accounts.Length; i++) 		//* for each account
			{
				if (accNum == accounts[i].AccountNumber) 	//* if the passed account number fits any in the list
				{
					if (pin == accounts[i].Pin) 			//* if the passed pin also fits
					{
						Thread.Sleep(1000); 				//* delay thread for demonstration purposes
						return i; 							//* return account index
					}
					else
					{
						Thread.Sleep(1000); 				//* delay thread for demonstration purposes
						return -2; 							//* return error code (account found, but invalid pin)
					}
				}
			}
			return -1; 										//* return error code (account not found)
		}

		//* check if account with passed account number and pin exists (first check only, when user enters their pin)
		public int checkPin(int accNum, string pin)
		{
			try
			{
				if (isSemaphored)
					sem.WaitOne();

				return checkPinNoSem(accNum, pin);
			}
			finally
			{
				if (isSemaphored)
					sem.Release(1);
			}
		}

		//* check account's balance
		public int balanceCheck(int accNum, string pin)
		{
			try
			{
				if (isSemaphored)
					sem.WaitOne();

				int accIndex = checkPinNoSem(accNum, pin); 	//* check and get index of account in use
				if (accIndex >= 0) 							//* if returned index is not an error code
				{
					Thread.Sleep(1000); 					//* delay thread for demonstration purposes
					return accounts[accIndex].Balance; 		//* account balance
				}
				else
				{
					Thread.Sleep(1000); 					//* delay thread for demonstration purposes
					return accIndex; 						//* return error code from the account check
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
			try
			{
				if (isSemaphored)
					sem.WaitOne();

				int accIndex = checkPinNoSem(accNum, pin); 		//* check and get index of account in use
				if (accIndex >= 0) 								//* if returned index is not an error code
				{
					if (amount <= accounts[accIndex].Balance) 	//* if amount to withdraw is less or equal to account balance
					{
						Thread.Sleep(1000); 					//* delay thread for demonstration purposes
						accounts[accIndex].Balance -= amount; 	//* decrement amount from account balance
						return 0; 								//* return success code (withdrawal goes through)
					}
					else
					{
						Thread.Sleep(1000); 					//* delay thread for demonstration purposes
						return 1; 								//* return error code (not enough balance to withdraw)
					}
				}
				else
				{
					Thread.Sleep(1000); 						//* delay thread for demonstration purposes
					return accIndex; 							//* return error code from the account check
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
			try
			{
				if (isSemaphored)
					sem.WaitOne();

				int accIndex = checkPinNoSem(accNum, pin); 						//* check and get index of account in use
				if (accIndex >= 0) 												//* if returned index is not an error code
				{
					if (accounts[accIndex].Balance + amount <= Int32.MaxValue) 	//* if account balance + amount is less or equal to max of INT32 (2,147,483,647) //// Could have made some workarounds but that's not the point of this project
					{
						Thread.Sleep(1000); 									//* delay thread for demonstration purposes
						accounts[accIndex].Balance += amount; 					//* increment amount to account balance
						return 0; 												//* return success code (withdrawal goes through)
					}
					else
					{
						Thread.Sleep(1000); 									//* delay thread for demonstration purposes
						return 1; 												//* return error code (deposit exceeds allowed limit)
					}
				}
				else
				{
					Thread.Sleep(1000); 										//* delay thread for demonstration purposes
					return accIndex; 											//* return error code from the account check
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
