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
    public partial class DragDrop : Form
    {

        public DragDrop()
        {
            InitializeComponent();
            TreeView1.AllowDrop = true;
            TreeView2.AllowDrop = true;

            //// Attach event handlers
            TreeView1.ItemDrag += TreeView1_ItemDrag;
            TreeView1.DragEnter += TreeView_DragEnter;
            TreeView1.DragDrop += TreeView_DragDrop;

            TreeView2.ItemDrag += TreeView2_ItemDrag;
            TreeView2.DragEnter += TreeView_DragEnter;
            TreeView2.DragDrop += TreeView_DragDrop;
        }

        private void TreeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Start the drag-and-drop operation for TreeView1
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void TreeView2_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Start the drag-and-drop operation for TreeView2
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void TreeView_DragEnter(object sender, DragEventArgs e)
        {
            // Allow dropping of nodes
            e.Effect = DragDropEffects.Move;
        }

        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            // Check if the data is a TreeNode
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                // Get the dropped node
                TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                // Get the point where the node was dropped
                Point targetPoint = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));

                // Get the node at the drop point
                TreeNode targetNode = ((TreeView)sender).GetNodeAt(targetPoint);

                // If there is no target node, it means the node was dropped at an empty space
                if (targetNode == null)
                {
                    // Add the dragged node to the root of the target TreeView
                    ((TreeView)sender).Nodes.Add((TreeNode)draggedNode.Clone());
                }
                else
                {
                    // Add the dragged node as a child of the target node
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
                    // Expand the target node to show the dropped node
                    targetNode.Expand();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Create a new node with the text in the textbox in the selected TreeView node
            TreeNode newNode = new TreeNode(txtNodeName.Text);
            newNode.Tag = txtNodeName.Text;

            if (TreeView2.SelectedNode != null)
            {
                TreeView2.SelectedNode.Nodes.Add(newNode);
                TreeView2.SelectedNode = newNode;
            }
            else if (TreeView1.SelectedNode != null)
            {
                TreeView1.SelectedNode.Nodes.Add(newNode);
                TreeView1.SelectedNode = newNode;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Update the text of the selected node
            if (TreeView2.SelectedNode != null)
            {
                TreeView2.SelectedNode.Text = txtNodeName.Text;
            }
            else if (TreeView1.SelectedNode != null)
            {
                TreeView1.SelectedNode.Text = txtNodeName.Text;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Delete the selected node
            if (TreeView2.SelectedNode != null)
            {
                TreeView2.SelectedNode.Remove();
            }
            else if (TreeView1.SelectedNode != null)
            {
                TreeView1.SelectedNode.Remove();
            }
        }
    }
}
