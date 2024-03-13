namespace CodeChum
{
    partial class TwoTrees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("C:");
            TreeNode treeNode2 = new TreeNode("D:");
            TreeNode treeNode3 = new TreeNode("E:");
            TreeNode treeNode4 = new TreeNode("F:");
            leftTreeView = new TreeView();
            rightTreeView = new TreeView();
            nodeNameTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            moveButton = new Button();
            SuspendLayout();
            // 
            // leftTreeView
            // 
            leftTreeView.Location = new Point(76, 37);
            leftTreeView.Name = "leftTreeView";
            treeNode1.Name = "CDrive";
            treeNode1.Text = "C:";
            treeNode2.Name = "DDrive";
            treeNode2.Text = "D:";
            leftTreeView.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            leftTreeView.Size = new Size(252, 245);
            leftTreeView.TabIndex = 0;
            // 
            // rightTreeView
            // 
            rightTreeView.Location = new Point(393, 37);
            rightTreeView.Name = "rightTreeView";
            treeNode3.Name = "EDrive";
            treeNode3.Text = "E:";
            treeNode4.Name = "FDrive";
            treeNode4.Text = "F:";
            rightTreeView.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode4 });
            rightTreeView.Size = new Size(252, 245);
            rightTreeView.TabIndex = 1;
            // 
            // nodeNameTextBox
            // 
            nodeNameTextBox.Location = new Point(207, 308);
            nodeNameTextBox.Name = "nodeNameTextBox";
            nodeNameTextBox.Size = new Size(314, 23);
            nodeNameTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Location = new Point(207, 337);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add ";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(288, 337);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 4;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(446, 337);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // moveButton
            // 
            moveButton.Location = new Point(365, 337);
            moveButton.Name = "moveButton";
            moveButton.Size = new Size(75, 23);
            moveButton.TabIndex = 6;
            moveButton.Text = "Move";
            moveButton.UseVisualStyleBackColor = true;
            moveButton.Click += moveButton_Click;
            // 
            // DragDrop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moveButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(nodeNameTextBox);
            Controls.Add(rightTreeView);
            Controls.Add(leftTreeView);
            Name = "DragDrop";
            Text = "DragDrop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView leftTreeView;
        private TreeView rightTreeView;
        private TextBox nodeNameTextBox;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button moveButton;
    }
}