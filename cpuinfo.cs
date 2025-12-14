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
    public partial class cpuinfo : Form
    {
        public cpuinfo()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher cpuSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            foreach (ManagementObject cpu in cpuSearcher.Get())
            {
                infobx.Text=("Number of Cores: " + cpu["NumberOfCores"]);
            }
        }
    }
}
