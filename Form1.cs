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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void devbtn_Click(object sender, EventArgs e)
        {
            devform form = new devform();
            form.ShowDialog();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            startform form = new startform();
            form.ShowDialog();
        }

        private void shutbtn_Click(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
