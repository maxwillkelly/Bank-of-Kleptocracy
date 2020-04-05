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
    public partial class Launch : Form
    {
        private int numAtms = 1;
        private bool isSemaphored = false;
        private int generatedAccounts = 3;
        private Account[] accounts;
        private Bank bank;
        private Random rnd;
        private string startLog;

        public Launch()
        {
            InitializeComponent();
        }

        private void selectorNumAtms_ValueChanged(object sender, EventArgs e)
        {
            numAtms = decimal.ToInt32(selectorNumAtms.Value);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Hide();
            initLogString();
            // Randomly generates account applications to produce Accounts and Cards
            accounts = new Account[generatedAccounts];
            rnd = new Random();
            for (var i = 0; i < generatedAccounts; i++)
            {
                accounts[i] = new Account(rnd);
                startLog += "Card Number: " + (i + 1) + "\tAccount Number: " + accounts[i].AccountNumber + "\tPin: " + accounts[i].Pin + "\t\tBalance: " + accounts[i].Balance + "\n";
            }

            startLog += "\nAccounts Generated\n";

            // Creates and starts each thread
            Thread bankThread = new Thread(new ThreadStart(LaunchBank));
            bankThread.Start();

            // Starts each ATM
            for (int i = 0; i < numAtms; i++)
            {
                Thread atmThread = new Thread(new ThreadStart(LaunchATM));
                atmThread.Start();
            }
        }

        private void initLogString()
        {
            startLog += "Preparing to launch simulation\n";
            startLog += "Settings:\tGenerating Accounts: " + generatedAccounts + "\tSimulation Type: ";
            if (isSemaphored)
                startLog += "Correct Balance";
            else
                startLog += "Incorrect Balance";
            startLog += "\nGenerating Accounts...\n\nAccount List:\n";
        }

        private void LaunchBank()
        {
            bank = new Bank(isSemaphored, accounts, startLog);
            Application.Run(bank);
            startLog += "Bank launched\n";
        }

        private void LaunchATM()
        {
            var atm = new ATM(ref bank);
            for (var i = 0; i < accounts.Length; i++)
            {
                var account = accounts[i];
                atm.CreateCard(account.AccountNumber);
            }

            Application.Run(atm);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult popup;
            popup = MessageBox.Show("ATM Simulator \n\nCreated and programmed by:\n\nMax Kelly \nTadas Saltenis \nMax Fyall \n\nThank you", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult popup;
            popup = MessageBox.Show("Our two simulations: \n\nTransactions with incorrect balance:\nThis simulation will demonstrate multiple atms withdrawing money from the same bank account. The end result being the atms withdrawing money with an incorrect final balance after those withdrawels. When in this simulation, to achieve the 'incorrect outcome' you must withdraw money from the ATM's simultaneously within a 4 second time window\n\nTransaction with correct balance:\nThis is similar to the previous simulation. The only difference being the final balance at the end of all the withdrawels will be correct. \n\nSelect the simulation you wish to see by pressing the button of the respective simulation. \n\nYou must then selected the number of atms you want to have in the simulation. \n\nOnce you have done that you may start the simulation.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void radioBtnIncorrectBalance_CheckedChanged(object sender, EventArgs e)
        {
            var radioBtn = (RadioButton)sender;
            if (radioBtn.Checked)
            {
                isSemaphored = false;
                Console.WriteLine("isSemaphored set to false");
            }
        }

        private void radioBtnCorrectBalance_CheckedChanged(object sender, EventArgs e)
        {
            var radioBtn = (RadioButton) sender;
            if (radioBtn.Checked)
            {
                isSemaphored = true;
                Console.WriteLine("isSemaphored set to true");
            }
        }
    }
}
