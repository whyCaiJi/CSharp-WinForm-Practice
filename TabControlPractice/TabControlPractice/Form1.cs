using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ShowInfo()
        {
            label1.Text = "Current tab: " + this.tabControl1.
                SelectedIndex.ToString() + " page, the tab name is "
                + tabControl1.SelectedTab.Text + ". There are "
                + tabControl1.TabCount.ToString() + " tabs.";
        }
    }
}
