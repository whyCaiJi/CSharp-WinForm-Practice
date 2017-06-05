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

namespace FileOptionPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string target = @"D:\test.txt";
            FileInfo myFile = new FileInfo(target);
            if (myFile.Exists)
            {
                label1.Text = "Created time: " + myFile.CreationTime.ToString();
                label2.Text = "Folder: " + myFile.Directory.ToString();
                label3.Text = "Folder name: " + myFile.DirectoryName.ToString()
                    + ", file extension is " + myFile.Extension.ToString();
            } 
            else
            {
                MessageBox.Show("File does not exists!");
            }
        }
    }
}

// The difference between File and FileInfo is that
// File is a static class and FileInfo needs to be instantiated
// first before manipualting files.
// FileInfo is recommended over File
