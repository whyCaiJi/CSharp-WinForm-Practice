using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Year 1", "Result");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Year 2", "Result");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Year 3", "Result");
            }
            else
            {
                MessageBox.Show("Year 4", "Result");
            }
        }
    }
}
