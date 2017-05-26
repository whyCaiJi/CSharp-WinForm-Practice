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
        private string _name;
        private string _emailId;
        private string _subject;
        private string _feedback;

        public Form3(string varName, string varEmail, string varSubject,
            string varFeedback)
        {
            InitializeComponent();
            this._name = varName;
            this._emailId = varEmail;
            this._subject = varSubject;
            this._feedback = varFeedback;

            listBox1.Items.Add("Name: " + this._name);
            listBox1.Items.Add("Email: " + this._emailId);
            listBox1.Items.Add("Subject: " + this._subject);
            listBox1.Items.Add("Feedback: " + this._feedback);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your feedback!");
            this.Close();
        }
    }
}
