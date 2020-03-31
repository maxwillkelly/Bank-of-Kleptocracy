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
        private Bank bank;
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

        private void LaunchBank()
        {
            bank = new Bank(isSemaphored);
            Application.Run(bank);
        }

        private void LaunchATM()
        {
            Application.Run(new ATM(ref bank));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult popup;
            popup = MessageBox.Show("ATM Simulator \n\nCreated and programmed by:\n\nMax Kelly \nTadas Saltenis \nMax Fyall \n\nThank you", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult popup;
            popup = MessageBox.Show("Our two simulations: \n\nTransactions with incorrect balance:\nThis simulation will demonstrate multiple atms withdrawing money from the same bank account. The end result being the atms withdrawing money with an incorrect final balance after those withdrawels.\n\nTransaction with correct balance:\nThis is similar to the previous simulation. The only difference being the final balance at the end of all the withdrawels will be correct. \n\nSelect the simulation you wish to see by pressing the button of the respective simulation. \n\nYou must then selected the number of atms you want to have in the simulation. \n\nOnce you have done that you may start the simulation.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
