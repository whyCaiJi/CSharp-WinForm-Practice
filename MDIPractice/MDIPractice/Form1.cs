using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Form2 MdiChild = new Form2();
            // Set the MDI Parent to be Form1
            MdiChild.MdiParent = this;
            MdiChild.Show();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Form3 MdiChild = new Form3();
            MdiChild.MdiParent = this;
            MdiChild.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            Form4 MdiChild = new Form4();
            MdiChild.MdiParent = this;
            MdiChild.Show();
        }
    }
}
