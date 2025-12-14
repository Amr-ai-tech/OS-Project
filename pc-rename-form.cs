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
    public partial class pc_rename_form : Form
    {
        public pc_rename_form()
        {
            InitializeComponent();
        }

        private void renamebtn_Click(object sender, EventArgs e)
        {
            string new_name = infobx.Text;
            object[] newName = { new_name };
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                obj.InvokeMethod("Rename", newName);
            }
            MessageBox.Show("done");
        }
    }
}
