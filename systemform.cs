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
    public partial class systemform : Form
    {
        public systemform()
        {
            InitializeComponent();
        }

        private void pcinfobtn_Click(object sender, EventArgs e)
        {
            pcinfoform form = new pcinfoform();
            form.ShowDialog();
        }

        private void cpuinfobtn_Click(object sender, EventArgs e)
        {
            cpuinfo form = new cpuinfo();
            form.ShowDialog();
        }

        private void osinfobtn_Click(object sender, EventArgs e)
        {
            osform form = new osform();
            form.ShowDialog();
        }

        private void pctbtn_Click(object sender, EventArgs e)
        {
            pctform form = new pctform();
            form.ShowDialog();
        }

        private void mibtn_Click(object sender, EventArgs e)
        {
            miform form = new miform();
            form.ShowDialog();
        }

        private void pcrbtn_Click(object sender, EventArgs e)
        {
            pc_rename_form form = new pc_rename_form();
            form.ShowDialog();
        }
    }
}
