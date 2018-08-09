﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace QuickComputerOptions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "Computer Utilities Menu";
            bool createdNew;

            Mutex mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("You cannot have more than one instance of this program running", "Already running");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmComputerUtilitiesMenu());
        }
    }
}
