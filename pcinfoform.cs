using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace OS_Project
{
    public partial class pcinfoform : Form
    {
        public pcinfoform()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher =
               new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");

            foreach (ManagementObject obj in searcher.Get())
            {
                infobx.Text=("Computer Name:  " + obj["Name"]+Environment.NewLine);
                infobx.AppendText("Domain:  " + obj["Domain"]+ Environment.NewLine);
                infobx.AppendText("Model:  " + obj["Model"]+ Environment.NewLine);
            }
        }
    }
}
