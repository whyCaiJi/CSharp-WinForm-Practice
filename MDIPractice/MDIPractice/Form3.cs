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
    public partial class Form3 : Form
    {
        private string some_name;
        private string email_address;
        private string topic;
        private string option;

        // Attribute: name
        public string SomeName
        {
            get
            {
                return some_name;
            }

            set
            {
                some_name = value;
            }
        }

        // Attribute: email
        public string SomeEmail
        {
            get
            {
                return email_address;
            }

            set
            {
                email_address = value;
            }
        }

        public string Sometopic
        {
            get
            {
                return topic;
            }

            set
            {
                topic = value;
            }
        }

        public string Someoption
        {
            get
            {
                return option;
            }

            set
            {
                option = value;
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(SomeName);
            listBox1.Items.Add(SomeEmail);
            listBox1.Items.Add(Sometopic);
            listBox1.Items.Add(Someoption);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your feedback!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.MdiParent = this.MdiParent;
            fm2.Show();
            this.Close();
        }
    }
}
