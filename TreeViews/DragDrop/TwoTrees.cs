using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class TwoTrees : Form
    {

        public TwoTrees()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Create a new node with the text in the textbox in the selected TreeView node
            TreeNode newNode = new TreeNode(nodeNameTextBox.Text);
            newNode.Tag = nodeNameTextBox.Text;

            if (rightTreeView.SelectedNode != null)
            {
                rightTreeView.SelectedNode.Nodes.Add(newNode);
                rightTreeView.SelectedNode = newNode;
            }
            else if (leftTreeView.SelectedNode != null)
            {
                leftTreeView.SelectedNode.Nodes.Add(newNode);
                leftTreeView.SelectedNode = newNode;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Update the text of the selected node
            if (rightTreeView.SelectedNode != null)
            {
                rightTreeView.SelectedNode.Text = nodeNameTextBox.Text;
            }
            else if (leftTreeView.SelectedNode != null)
            {
                leftTreeView.SelectedNode.Text = nodeNameTextBox.Text;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Delete the selected node
            if (rightTreeView.SelectedNode != null)
            {
                rightTreeView.SelectedNode.Remove();
            }
            else if (leftTreeView.SelectedNode != null)
            {
                leftTreeView.SelectedNode.Remove();
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            if (leftTreeView.SelectedNode != null)
            {
                TreeNode nodeToMove = leftTreeView.SelectedNode;
                leftTreeView.Nodes.Remove(nodeToMove); // Remove from leftTreeView

                // If you want to add the node to a specific location in rightTreeView, modify this part
                rightTreeView.Nodes.Add(nodeToMove); // Add to rightTreeView
                rightTreeView.SelectedNode = nodeToMove; // Select the moved node
            }
        }
    }
}
