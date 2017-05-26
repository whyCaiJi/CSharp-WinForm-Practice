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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("颜色反馈");
            comboBox1.SelectedIndex = 0;
            textBox3.Text = "";
            textBox1.Focus();
            textBox3.Items.Add("I want yellow color!");
            textBox3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("输入的内容不能为空", "信息提示");
            }
            else
            {
                this.Hide();
                Form3 childForm3 = new Form3(this.textBox1.Text, 
                    this.textBox2.Text, this.comboBox1.SelectedItem.ToString(),
                    this.textBox3.SelectedItem.ToString());
                childForm3.Show();
            }
        }
    }
}
