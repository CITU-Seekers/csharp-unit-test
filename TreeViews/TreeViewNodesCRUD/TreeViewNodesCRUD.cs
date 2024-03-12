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
    public partial class TreeViewNodesCRUD : Form
    {
        public TreeViewNodesCRUD()
        {
            InitializeComponent();
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            if (mainNodeCheckBox.Checked || mainTreeView.Nodes.Count == 0)
            {
                mainTreeView.Nodes.Insert(0, nameTextBox.Text);
            }
            else
            {
                try
                {
                    mainTreeView.SelectedNode.Nodes.Add(nameTextBox.Text);
                }
                catch (NullReferenceException ex)
                {
                    return;
                }
            }
        }

        private void RemoveNodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                mainTreeView.Nodes.Remove(mainTreeView.SelectedNode);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void UpdateNodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                mainTreeView.SelectedNode.Text = nameTextBox.Text;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pathLabel.Text = mainTreeView.SelectedNode.FullPath;
        }
    }
}
