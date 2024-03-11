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
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MainNodeCheckBox = new System.Windows.Forms.CheckBox();
            this.AddNodeButton = new System.Windows.Forms.Button();
            this.RemoveNodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTreeView
            // 
            this.MainTreeView.Location = new System.Drawing.Point(26, 30);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(262, 249);
            this.MainTreeView.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(323, 91);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Node Name";
            this.NameTextBox.Size = new System.Drawing.Size(185, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // MainNodeCheckBox
            // 
            this.MainNodeCheckBox.Location = new System.Drawing.Point(323, 138);
            this.MainNodeCheckBox.Name = "MainNodeCheckBox";
            this.MainNodeCheckBox.Size = new System.Drawing.Size(184, 30);
            this.MainNodeCheckBox.TabIndex = 2;
            this.MainNodeCheckBox.Text = "Create Node at Top?";
            this.MainNodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddNodeButton
            // 
            this.AddNodeButton.Location = new System.Drawing.Point(323, 183);
            this.AddNodeButton.Name = "AddNodeButton";
            this.AddNodeButton.Size = new System.Drawing.Size(84, 37);
            this.AddNodeButton.TabIndex = 3;
            this.AddNodeButton.Text = "Add";
            this.AddNodeButton.UseVisualStyleBackColor = true;
            this.AddNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);
            // 
            // RemoveNodeButton
            // 
            this.RemoveNodeButton.Location = new System.Drawing.Point(423, 183);
            this.RemoveNodeButton.Name = "RemoveNodeButton";
            this.RemoveNodeButton.Size = new System.Drawing.Size(84, 37);
            this.RemoveNodeButton.TabIndex = 4;
            this.RemoveNodeButton.Text = "Remove";
            this.RemoveNodeButton.UseVisualStyleBackColor = true;
            this.RemoveNodeButton.Click += new System.EventHandler(this.RemoveNodeButton_Click);
            // 
            // TreeViewNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 302);
            this.Controls.Add(this.RemoveNodeButton);
            this.Controls.Add(this.AddNodeButton);
            this.Controls.Add(this.MainNodeCheckBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.MainTreeView);
            this.Name = "TreeViewNodes";
            this.Text = "Tree View Nodes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView MainTreeView;
        private TextBox NameTextBox;
        private CheckBox MainNodeCheckBox;
        private Button AddNodeButton;
        private Button RemoveNodeButton;
    }
}