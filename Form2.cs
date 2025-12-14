using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OS_Project
{
    public partial class writefileform : Form
    {
        public writefileform()
        {
            InitializeComponent();
        }

        private void wrbtn_Click(object sender, EventArgs e)
        {
            string path = pathpx.Text;
            string text = txtpx.Text;
            File.WriteAllText(path, text);
            MessageBox.Show("Your text has been writen");
        }
    }
}
