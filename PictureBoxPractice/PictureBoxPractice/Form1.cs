using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowPic()
        {
            pictureBox1.Image = Image.FromFile(System.Environment.GetFolderPath(System.
                Environment.SpecialFolder.Desktop) + @"\a.jpg");
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            } 
            else
            {
                ShowPic();
            }
        }
    }
}
