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
            Thread controlThread = new Thread(new ThreadStart(LaunchControl));
            controlThread.Start();
            // Starts each ATM
            for (int i = 0; i < numAtms; i++)
            {
                Thread atmThread = new Thread(new ThreadStart(LaunchATM));
                atmThread.Start();
            }
        }

        private void LaunchControl()
        {
            Application.Run(new Bank());
        }

        private void LaunchATM()
        {
            Application.Run(new ATM());
        }
    }
}
