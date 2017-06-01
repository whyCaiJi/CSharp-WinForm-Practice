using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColumnHeader Header1 = new ColumnHeader();
            Header1.Text = "姓名";
            Header1.TextAlign = HorizontalAlignment.Center;
            Header1.Width = 100;
            listView1.Columns.Add(Header1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("年龄", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("班级", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("性别", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("职业", 40, HorizontalAlignment.Center);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Columns.Remove(listView1.Columns[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            listView1.Items.Add("row1", "张三", 0);
            listView1.Items["row1"].SubItems.Add("21");
            listView1.Items["row1"].SubItems.Add("98001");
            listView1.Items["row1"].SubItems.Add("男");
            listView1.Items["row1"].SubItems.Add("学生");

            listView1.Items.Add("row2", "李四", 1);
            listView1.Items["row2"].SubItems.Add("22");
            listView1.Items["row2"].SubItems.Add("98002");
            listView1.Items["row2"].SubItems.Add("女");
            listView1.Items["row2"].SubItems.Add("教师");

            listView1.Items.Add("row3", "王五", 2);
            listView1.Items["row3"].SubItems.Add("23");
            listView1.Items["row3"].SubItems.Add("98003");
            listView1.Items["row3"].SubItems.Add("男");
            listView1.Items["row3"].SubItems.Add("干部");

            listView1.Items.Add("row4", "赵六", 3);
            listView1.Items["row4"].SubItems.Add("24");
            listView1.Items["row4"].SubItems.Add("98004");
            listView1.Items["row4"].SubItems.Add("女");
            listView1.Items["row4"].SubItems.Add("军人");

            listView1.EndUpdate();

            for (int i=0; i<listView1.Items.Count; i++)
            {
                if (i%2 == 0)
                {
                    listView1.Items[i].BackColor = Color.Gray;
                }
            }

            this.listView1.GridLines = true;
            this.listView1.View = View.Details;
            this.listView1.LabelEdit = true;
            this.listView1.Scrollable = true;
            this.listView1.HeaderStyle = ColumnHeaderStyle.Clickable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listView1.Clear();
            this.button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lst in listView1.SelectedItems)
            {
                MessageBox.Show(lst.Text);
            }
        }
    }
}
