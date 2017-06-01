using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            // Tree node object must be instantiated before added into the tree view
            TreeNode tem = new TreeNode("Root");
            treeView1.Nodes.Add(tem);
        }

        private void AddChildNode()
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Please select a node", "Message", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                if (textBox1.Text != "")
                {
                    TreeNode tmp;
                    tmp = new TreeNode(textBox1.Text);
                    treeView1.SelectedNode.Nodes.Add(tmp);
                    treeView1.SelectedNode = tmp;
                    treeView1.ExpandAll();
                }
                else
                {
                    MessageBox.Show("A node requires a name", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}
