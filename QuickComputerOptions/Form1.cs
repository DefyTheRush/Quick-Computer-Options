using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickComputerOptions
{
    public partial class frmComputerUtilitiesMenu : Form
    {
        public frmComputerUtilitiesMenu()
        {
            InitializeComponent();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 00");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/r /t 00");
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32", "powrprof.dll,SetSuspendState 0,1,0");
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32", "User32.dll,LockWorkStation");
        }

        private void btnForceShutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /f /t 00");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/l");
        }
    }
}
