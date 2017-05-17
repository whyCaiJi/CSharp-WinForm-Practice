using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是一个简单提示", "信息提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // MessageBox.Show() method could return a DialogResult object
            // The result could be caught and stored for further processing.
            // The third parameter states the type of buttons
            DialogResult result = MessageBox.Show("这是一个问询提示", "问询提示",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                label1.Text = "您选择了YES";
            }
            else
            {
                label1.Text = "您选择了NO";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("这是一个复杂提示", "复杂提示",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                label1.Text = "You chose YES";
            }
            else if (result == DialogResult.No)
            {
                label1.Text = "You chose NO";
            }
            else
            {
                label1.Text = "You chose Cancel";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }
    }
}
