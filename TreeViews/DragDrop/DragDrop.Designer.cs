namespace CodeChum
{
    partial class DragDrop
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
            TreeNode treeNode5 = new TreeNode("C:");
            TreeNode treeNode6 = new TreeNode("D:");
            TreeNode treeNode7 = new TreeNode("E:");
            TreeNode treeNode8 = new TreeNode("F:");
            TreeView1 = new TreeView();
            TreeView2 = new TreeView();
            txtNodeName = new TextBox();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // TreeView1
            // 
            TreeView1.Location = new Point(76, 37);
            TreeView1.Name = "TreeView1";
            treeNode5.Name = "CDrive";
            treeNode5.Text = "C:";
            treeNode6.Name = "DDrive";
            treeNode6.Text = "D:";
            TreeView1.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode6 });
            TreeView1.Size = new Size(252, 245);
            TreeView1.TabIndex = 0;
            //TreeView1.ItemDrag += TreeView1_ItemDrag;
            //TreeView1.DragEnter += TreeView_DragEnter;
            //TreeView1.DragDrop += TreeView_DragDrop;
            // 
            // TreeView2
            // 
            TreeView2.Location = new Point(393, 37);
            TreeView2.Name = "TreeView2";
            treeNode7.Name = "EDrive";
            treeNode7.Text = "E:";
            treeNode8.Name = "FDrive";
            treeNode8.Text = "F:";
            TreeView2.Nodes.AddRange(new TreeNode[] { treeNode7, treeNode8 });
            TreeView2.Size = new Size(252, 245);
            TreeView2.TabIndex = 1;
            //TreeView2.ItemDrag += TreeView2_ItemDrag;
            //TreeView2.DragEnter += TreeView_DragEnter;
            //TreeView2.DragDrop += TreeView_DragDrop;
            // 
            // txtNodeName
            // 
            txtNodeName.Location = new Point(207, 308);
            txtNodeName.Name = "txtNodeName";
            txtNodeName.Size = new Size(303, 23);
            txtNodeName.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(223, 337);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add ";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(324, 337);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(426, 337);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DragDrop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(txtNodeName);
            Controls.Add(TreeView2);
            Controls.Add(TreeView1);
            Name = "DragDrop";
            Text = "DragDrop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView TreeView1;
        private TreeView TreeView2;
        private TextBox txtNodeName;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}