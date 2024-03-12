using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class TreeViewNodes : Form
    {
        public TreeViewNodes()
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
    }
}
