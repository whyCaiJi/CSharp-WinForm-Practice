using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileCopyPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string somefile = @"D:\test.txt";
            string target = @"D:\1.txt";
            if (!File.Exists(somefile))
            {
                MessageBox.Show("File does not exist!");
            }
            else
            {
                if (File.Exists(target))
                {
                    File.Delete(target);
                }
                File.Copy(somefile, target);
                MessageBox.Show("File successfully copied!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string target = @"D:\1.txt";
            if (File.Exists(target))
            {
                File.Delete(target);
            }
            File.CreateText(target);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string target = @"D:\1.txt";
            if (!File.Exists(target))
            {
                MessageBox.Show("File does not exist!");
            }
            else
            {
                File.Delete(target);
                MessageBox.Show("File successfully deleted!");
            }
        }
    }
}
