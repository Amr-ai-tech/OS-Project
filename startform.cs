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
    public partial class startform : Form
    {
        public startform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filebtn_Click(object sender, EventArgs e)
        {
            fileform form = new fileform();
            form.ShowDialog();
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            systemform form = new systemform();
            form.ShowDialog();
        }
    }
}
