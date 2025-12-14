using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Project
{
    public partial class pctform : Form
    {
        public pctform()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                switch (Convert.ToInt32(obj["DomainRole"]))
                {
                    case 0:
                        infobx.Text = ("Standalone Workstation");
                        break;
                    case 1:
                        infobx.Text = ("Member Workstation");
                        break;
                    case 2:
                        infobx.Text = ("Standalone Server");
                        break;
                    case 3:
                        infobx.Text = ("Member Server");
                        break;
                    case 4:
                        infobx.Text = ("Backup Domain Controller");
                        break;
                    case 5:
                        infobx.Text = ("Primary Domain Controller");
                        break;
                }
            }
        }
    }
}
