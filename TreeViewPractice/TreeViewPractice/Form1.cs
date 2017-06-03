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

        private void AddParent()
        {
            try
            {
                if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show("Please select a node", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        TreeNode tmp;
                        tmp = new TreeNode(textBox1.Text);
                        treeView1.SelectedNode.Parent.Nodes.Add(tmp);
                        treeView1.ExpandAll();
                    }
                    else
                    {
                        MessageBox.Show("Requires a node name!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch
            {
                TreeNode tem = new TreeNode("Root");
                treeView1.Nodes.Add(tem);
            }
        }

        // Mouse event handled by MouseEventArgs object
        // Read more on the MouseEventArgs class in the future
        // ContextMenuStrip is the right click menu we normally see
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
        }

        // Expand the selected node
        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Expand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = treeView1.Nodes[0];
            // The self-defined ExpandAll() method is called
            treeView1.SelectedNode.ExpandAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = treeView1.Nodes[0];
            treeView1.SelectedNode.Collapse();
        }

        private void addChildNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChildNode();
        }

        private void addNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddParent();
        }

        private void deleteNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Nodes.Count == 0)
            {
                treeView1.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Please delete all child nodes!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
