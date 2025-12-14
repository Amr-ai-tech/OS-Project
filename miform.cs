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
    public partial class miform : Form
    {
        public miform()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory");

            foreach (ManagementObject obj in Searcher.Get())
            {
                infobx.Text=("Available MBs: " + obj["AvailableMBytes"]+Environment.NewLine);
                infobx.AppendText("Cache bytes: " + obj["CacheBytes"]+Environment.NewLine);
                infobx.AppendText("Committed bytes: " + obj["CommittedBytes"] + Environment.NewLine);
                infobx.AppendText("Commit limit: " + obj["CommitLimit"] + Environment.NewLine);
            }
        }
    }
}
