using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_of_Kleptocracy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Generic Application Code
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creates and starts each thread
            Thread controlThread = new Thread(new ThreadStart(LaunchControl));
            controlThread.Start();
            Thread atmThread = new Thread(new ThreadStart(LaunchATM));
            atmThread.Start();
        }

        static void LaunchControl()
        {
            Application.Run(new Control());
        }

        static void LaunchATM()
        {
            Application.Run(new ATM());
        }
    }
}
