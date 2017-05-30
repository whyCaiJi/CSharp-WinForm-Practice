using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusStripPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Date Now: " + DateTime.Now.ToShortDateString()
                + "; Time Now: " + DateTime.Now.ToShortTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Word Count: " + richTextBox1.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusStrip sb = new StatusStrip();
            ToolStripLabel tsl = new ToolStripLabel();
            tsl.Text = "Newly added tool strip";
            ToolStripItem[] tsi = new ToolStripItem[1];
            tsi[0] = tsl;
            sb.Items.AddRange(tsi);
            this.Controls.Add(sb);
        }
    }
}
