using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProgressBarPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstring = "Data Source=(local);Initial Catalog=NorthWind;User ID=sa";
            SqlConnection conn = new SqlConnection(sqlstring);

            string sql = "select * from Orders";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;

            DataSet ds = new DataSet();
            adp.Fill(ds);

            conn.Dispose();
            conn.Close();
            conn = null;
            label1.Visible = true;

            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = ds.Tables[0].Rows.Count;
            progressBar1.BackColor = Color.Red;

            for (int i = 0; i<ds.Tables[0].Rows.Count; i++)
            {
                progressBar1.Value++;
                Application.DoEvents();
                this.label1.Text = progressBar1.Value.ToString();
            }
        }
    }
}
