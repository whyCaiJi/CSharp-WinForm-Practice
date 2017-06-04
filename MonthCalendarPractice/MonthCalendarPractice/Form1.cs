using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendarPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Today is " + monthCalendar1.TodayDate.ToString();
            label2.Text = "";
            label3.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label2.Text = "Starting date: " + monthCalendar1.SelectionStart.ToString();
            label3.Text = "Ending date: " + monthCalendar1.SelectionEnd.ToString();
            label7.Text = "Date after 3 months: " + monthCalendar1.SelectionStart.AddMonths(3).ToString();
            label8.Text = "Date after 3 days: " + monthCalendar1.SelectionStart.AddDays(3).ToString();
            label9.Text = "Date after 3 years: " + monthCalendar1.SelectionStart.AddYears(3).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                int i = comboBox1.SelectedIndex;
                switch (i)
                {
                    case 0:
                        monthCalendar1.TitleBackColor = System.Drawing.Color.Red;
                        break;
                    case 1:
                        monthCalendar1.TitleBackColor = System.Drawing.Color.Yellow;
                        break;
                    case 2:
                        monthCalendar1.TitleBackColor = System.Drawing.Color.Blue;
                        break;
                    case 3:
                        monthCalendar1.TitleBackColor = System.Drawing.Color.Green;
                        break;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                int i = comboBox2.SelectedIndex;
                switch (i)
                {
                    case 0:
                        monthCalendar1.TrailingForeColor = System.Drawing.Color.Red;
                        break;
                    case 1:
                        monthCalendar1.TrailingForeColor = System.Drawing.Color.Yellow;
                        break;
                    case 2:
                        monthCalendar1.TrailingForeColor = System.Drawing.Color.Blue;
                        break;
                    case 3:
                        monthCalendar1.TrailingForeColor = System.Drawing.Color.Green;
                        break;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex >= 0)
            {
                int i = comboBox3.SelectedIndex;
                switch (i)
                {
                    case 0:
                        monthCalendar1.TitleForeColor = System.Drawing.Color.Red;
                        break;
                    case 1:
                        monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow;
                        break;
                    case 2:
                        monthCalendar1.TitleForeColor = System.Drawing.Color.Blue;
                        break;
                    case 3:
                        monthCalendar1.TitleForeColor = System.Drawing.Color.Green;
                        break;
                }
            }
        }
    }
}
