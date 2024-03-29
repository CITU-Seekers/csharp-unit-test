﻿using System;
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
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new node under the selected node
            TreeNode newNode = new TreeNode("New File");
            mainTreeView.SelectedNode.Nodes.Add(newNode);
            mainTreeView.SelectedNode = newNode;
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            //Get the name of the selected node
            string selectedNode = mainTreeView.SelectedNode.Text;
            messageLabel.Text = $"Opening {selectedNode}";
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            //Rename the selected node with the text in the textbox
            mainTreeView.SelectedNode.Text = fileNameTextBox.Text;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Clear the selected node and file path label
            mainTreeView.SelectedNode = null;
            filePathLabel.Text = "";

            // Search for the files containing the text in the textbox and highlight the first file found
            string searchText = fileNameTextBox.Text.ToLower(); // Convert to lowercase for case-insensitive search
            SearchNode(mainTreeView.Nodes, searchText);
        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            filePathLabel.Text = mainTreeView.SelectedNode.FullPath;
        }

        private bool SearchNode(TreeNodeCollection nodes, string searchText)
        {
            foreach (TreeNode node in nodes)
            {
                // Check if the node's text contains the search text
                if (node.Text.ToLower().Contains(searchText))
                {
                    // Highlight the node and set it as selected
                    mainTreeView.SelectedNode = node;
                    filePathLabel.Text = mainTreeView.SelectedNode.FullPath;
                    return true; // File found
                }

                // Recursively search in the node's sub-nodes
                if (SearchNode(node.Nodes, searchText))
                {
                    return true; // File found in sub-nodes
                }
            }

            return false; // File not found in this branch
        }
    }
}
