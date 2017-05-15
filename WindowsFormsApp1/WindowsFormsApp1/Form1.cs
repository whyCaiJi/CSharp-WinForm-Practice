using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            listBox1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox1.SelectedIndex = 0;
            textBox1.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            listBox1.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
