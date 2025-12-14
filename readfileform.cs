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
    public partial class readfileform : Form
    {
        public readfileform()
        {
            InitializeComponent();
        }

        private void wrbtn_Click(object sender, EventArgs e)
        {
            string path = pathpx.Text;
            string content = File.ReadAllText(path);
            txtpx.Text = content;
        }
    }
}
