namespace CodeChum
{
    partial class TreeViewNodes
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
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mainNodeCheckBox = new System.Windows.Forms.CheckBox();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.removeNodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.Location = new System.Drawing.Point(26, 30);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.Size = new System.Drawing.Size(262, 249);
            this.mainTreeView.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(323, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Node Name";
            this.nameTextBox.Size = new System.Drawing.Size(185, 27);
            this.nameTextBox.TabIndex = 1;
            // 
            // mainNodeCheckBox
            // 
            this.mainNodeCheckBox.Location = new System.Drawing.Point(323, 138);
            this.mainNodeCheckBox.Name = "mainNodeCheckBox";
            this.mainNodeCheckBox.Size = new System.Drawing.Size(184, 30);
            this.mainNodeCheckBox.TabIndex = 2;
            this.mainNodeCheckBox.Text = "Create Node at Top?";
            this.mainNodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addNodeButton
            // 
            this.addNodeButton.Location = new System.Drawing.Point(323, 183);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(84, 37);
            this.addNodeButton.TabIndex = 3;
            this.addNodeButton.Text = "Add";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);
            // 
            // removeNodeButton
            // 
            this.removeNodeButton.Location = new System.Drawing.Point(423, 183);
            this.removeNodeButton.Name = "removeNodeButton";
            this.removeNodeButton.Size = new System.Drawing.Size(84, 37);
            this.removeNodeButton.TabIndex = 4;
            this.removeNodeButton.Text = "Remove";
            this.removeNodeButton.UseVisualStyleBackColor = true;
            this.removeNodeButton.Click += new System.EventHandler(this.RemoveNodeButton_Click);
            // 
            // TreeViewNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 302);
            this.Controls.Add(this.removeNodeButton);
            this.Controls.Add(this.addNodeButton);
            this.Controls.Add(this.mainNodeCheckBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.mainTreeView);
            this.Name = "TreeViewNodes";
            this.Text = "Tree View Nodes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView mainTreeView;
        private TextBox nameTextBox;
        private CheckBox mainNodeCheckBox;
        private Button addNodeButton;
        private Button removeNodeButton;
    }
}