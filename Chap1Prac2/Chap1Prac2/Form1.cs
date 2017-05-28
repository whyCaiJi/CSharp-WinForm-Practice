using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap1Prac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Text = "";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Software");
            listBox1.Items.Add("Hardware");
            listBox1.Items.Add("Finance");
            listBox1.Items.Add("Human Resource");
            label1.Text = "" + listBox1.Items.Count + "records added.";
            listBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(listBox1.SelectedIndex, "Inserted Item");
            label1.Text = "" + listBox1.Items.Count + " records added.";
        }
    }
}
