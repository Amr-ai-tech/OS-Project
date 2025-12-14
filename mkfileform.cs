using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Project
{
    public partial class mkfileform : Form
    {
        public mkfileform()
        {
            InitializeComponent();
        }

        private void crbtn_Click(object sender, EventArgs e)
        {
            string path = pathpx.Text;
            File.Create(path).Close();
            MessageBox.Show("Your file has been created");
        }
    }
}
