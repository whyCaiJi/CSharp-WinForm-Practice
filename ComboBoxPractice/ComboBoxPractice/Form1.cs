using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("财务部");
            this.comboBox1.Items.Add("产品部");
            this.comboBox1.Items.Add("销售部");
            this.comboBox1.Items.Add("生产部");
            this.comboBox1.SelectedIndex = 1;

            this.comboBox2.Items.Add("财务部");
            this.comboBox2.Items.Add("产品部");
            this.comboBox2.Items.Add("销售部");
            this.comboBox2.Items.Add("生产部");
            this.comboBox2.SelectedIndex = 1;

            listBox1.Items.Add("财务部");
            listBox1.Items.Add("产品部");
            listBox1.Items.Add("销售部");
            listBox1.Items.Add("生产部");
            this.listBox1.SelectedIndex = 1;
            this.textBox1.Text = this.listBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String mess = comboBox1.SelectedItem.ToString();
            comboBox2.SelectedItem = mess;
            listBox1.SelectedItem = mess;
            textBox1.Text = mess;
        }
    }
}
