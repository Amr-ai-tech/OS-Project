using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Project
{
    public partial class fileform : Form
    {
        public fileform()
        {
            InitializeComponent();
        }

        private void mkfilebtn_Click(object sender, EventArgs e)
        {
            mkfileform form = new mkfileform();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writefileform form = new writefileform();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readfileform form = new readfileform();
            form.ShowDialog();
        }
    }
}
