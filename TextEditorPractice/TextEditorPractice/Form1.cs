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

namespace TextEditorPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private static string directory_path = "d:\\";

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("文件名禁止为空！", "警告");
                }
                else
                {
                    directory_path = directory_path + textBox1.Text.Trim() + ".txt";
                    // This line either open the file or create a new one
                    StreamWriter sw = File.CreateText(directory_path);
                    button2.Enabled = true;
                    button3.Enabled = false;
                    button1.Enabled = true;
                    richTextBox1.Enabled = true;
                    MessageBox.Show("文件成功建立。", "消息");
                    sw.Close();
                }
            }
            catch (Exception mm)
            {
                MessageBox.Show("磁盘操作错误，原因： "
                    + Convert.ToString(mm), "警报");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "打开文本文件";
                open.FileName = "";
                open.AddExtension = true;
                open.CheckFileExists = true;
                open.CheckPathExists = true;
                open.Filter = "文本文件(*.txt)|*.txt";
                open.ValidateNames = true;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(open.FileName,
                        System.Text.Encoding.Default);
                    this.richTextBox1.Text = sr.ReadToEnd();
                    this.textBox1.Text = open.FileName;
                    sr.Close();
                }

                MessageBox.Show("文件打开成功！", "消息");
            }
            catch (Exception mm)
            {
                MessageBox.Show("磁盘操作错误， 原因： " + Convert.ToString(mm),
                    "警报");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream textfile = File.Open(directory_path, FileMode.OpenOrCreate,
                    FileAccess.Write);
                StreamWriter sw = new StreamWriter(textfile, Encoding.
                    GetEncoding("GB2312"));
                sw.Write(richTextBox1.Text.ToString());
                MessageBox.Show("文件写成功。", "警报");
                sw.Close();
            }
            catch (Exception mm)
            {
                MessageBox.Show("磁盘操作错误， 原因： " + Convert.ToString(mm),
                    "警报");
            }
        }
    }
}
