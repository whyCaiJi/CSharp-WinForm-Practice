using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBoxPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Sunday");
            checkedListBox1.Items.Add("Monday");
            checkedListBox1.Items.Add("Tuesday");
            checkedListBox1.Items.Add("Wednesday");
            checkedListBox1.Items.Add("Thursday");
            checkedListBox1.Items.Add("Friday");
            checkedListBox1.Items.Add("Saturday");           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object o in checkedListBox1.CheckedItems)
            {
                checkedListBox2.Items.Add(o);
            }

            for (int i=checkedListBox1.Items.Count-1; i>=0; i--)
            {
                if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[i]))
                {
                    checkedListBox3.Items.Add(checkedListBox1.Items[i].ToString() + " is moved to the right.");
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object o in checkedListBox1.Items)
            {
                checkedListBox2.Items.Add(o);
            }

            checkedListBox1.Items.Clear();
            checkedListBox3.Items.Add("Left items are all moved to the right.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (object o in checkedListBox2.CheckedItems)
            {
                checkedListBox1.Items.Add(o);
            }

            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox2.CheckedItems.Contains(checkedListBox2.Items[i]))
                {
                    checkedListBox3.Items.Add(checkedListBox1.Items[i].ToString() + " is moved to the left");
                    checkedListBox2.Items.Remove(checkedListBox2.Items[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (object o in checkedListBox2.Items)
            {
                checkedListBox1.Items.Add(o);
            }

            checkedListBox2.Items.Clear();
            checkedListBox3.Items.Add("Right items are all moved to the left.");
        }
    }
}
