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
            if (MainNodeCheckBox.Checked || MainTreeView.Nodes.Count == 0)
            {
                MainTreeView.Nodes.Insert(0, NameTextBox.Text);
            }
            else
            {
                try
                {
                    MainTreeView.SelectedNode.Nodes.Add(NameTextBox.Text);
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
                MainTreeView.Nodes.Remove(MainTreeView.SelectedNode);
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
                MainTreeView.SelectedNode.Text = NameTextBox.Text;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PathLabel.Text = MainTreeView.SelectedNode.FullPath;
        }
    }
}
