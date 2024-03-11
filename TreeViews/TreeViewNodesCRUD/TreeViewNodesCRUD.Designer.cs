namespace CodeChum
{
    partial class TreeViewNodesCRUD
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
            this.RemoveNodeButton = new System.Windows.Forms.Button();
            this.AddNodeButton = new System.Windows.Forms.Button();
            this.MainNodeCheckBox = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.UpdateNodeButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveNodeButton
            // 
            this.RemoveNodeButton.Location = new System.Drawing.Point(343, 144);
            this.RemoveNodeButton.Name = "RemoveNodeButton";
            this.RemoveNodeButton.Size = new System.Drawing.Size(184, 33);
            this.RemoveNodeButton.TabIndex = 9;
            this.RemoveNodeButton.Text = "Remove";
            this.RemoveNodeButton.UseVisualStyleBackColor = true;
            this.RemoveNodeButton.Click += new System.EventHandler(this.RemoveNodeButton_Click);
            // 
            // AddNodeButton
            // 
            this.AddNodeButton.Location = new System.Drawing.Point(343, 105);
            this.AddNodeButton.Name = "AddNodeButton";
            this.AddNodeButton.Size = new System.Drawing.Size(184, 33);
            this.AddNodeButton.TabIndex = 8;
            this.AddNodeButton.Text = "Add";
            this.AddNodeButton.UseVisualStyleBackColor = true;
            this.AddNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);
            // 
            // MainNodeCheckBox
            // 
            this.MainNodeCheckBox.Location = new System.Drawing.Point(343, 69);
            this.MainNodeCheckBox.Name = "MainNodeCheckBox";
            this.MainNodeCheckBox.Size = new System.Drawing.Size(184, 30);
            this.MainNodeCheckBox.TabIndex = 7;
            this.MainNodeCheckBox.Text = "Create Node at Top?";
            this.MainNodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(344, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Node Name";
            this.NameTextBox.Size = new System.Drawing.Size(184, 27);
            this.NameTextBox.TabIndex = 6;
            // 
            // MainTreeView
            // 
            this.MainTreeView.Location = new System.Drawing.Point(46, 27);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(262, 249);
            this.MainTreeView.TabIndex = 5;
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            // 
            // UpdateNodeButton
            // 
            this.UpdateNodeButton.Location = new System.Drawing.Point(343, 183);
            this.UpdateNodeButton.Name = "UpdateNodeButton";
            this.UpdateNodeButton.Size = new System.Drawing.Size(184, 33);
            this.UpdateNodeButton.TabIndex = 10;
            this.UpdateNodeButton.Text = "Update";
            this.UpdateNodeButton.UseVisualStyleBackColor = true;
            this.UpdateNodeButton.Click += new System.EventHandler(this.UpdateNodeButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.Location = new System.Drawing.Point(344, 251);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(183, 25);
            this.PathLabel.TabIndex = 11;
            // 
            // TreeViewNodesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 314);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.UpdateNodeButton);
            this.Controls.Add(this.RemoveNodeButton);
            this.Controls.Add(this.AddNodeButton);
            this.Controls.Add(this.MainNodeCheckBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.MainTreeView);
            this.Name = "TreeViewNodesCRUD";
            this.Text = "Tree View Nodes CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RemoveNodeButton;
        private Button AddNodeButton;
        private CheckBox MainNodeCheckBox;
        private TextBox NameTextBox;
        private TreeView MainTreeView;
        private Button UpdateNodeButton;
        private Label PathLabel;
    }
}