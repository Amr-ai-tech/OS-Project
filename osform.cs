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
    public partial class osform : Form
    {
        public osform()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject obj in searcher.Get())
            {
                infobx.Text=("Operating System Name: " + obj["Caption"]+Environment.NewLine);
                infobx.AppendText("Version: " + obj["Version"] + Environment.NewLine);
                infobx.AppendText("Manufacturer: " + obj["Manufacturer"] + Environment.NewLine);
                infobx.AppendText("System Path: " + obj["WindowsDirectory"] + Environment.NewLine);
            }
        }
    }
}
