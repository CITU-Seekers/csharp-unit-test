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
            this.removeNodeButton = new System.Windows.Forms.Button();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.mainNodeCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.updateNodeButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeNodeButton
            // 
            this.removeNodeButton.Location = new System.Drawing.Point(343, 144);
            this.removeNodeButton.Name = "removeNodeButton";
            this.removeNodeButton.Size = new System.Drawing.Size(184, 33);
            this.removeNodeButton.TabIndex = 9;
            this.removeNodeButton.Text = "Remove";
            this.removeNodeButton.UseVisualStyleBackColor = true;
            this.removeNodeButton.Click += new System.EventHandler(this.RemoveNodeButton_Click);
            // 
            // addNodeButton
            // 
            this.addNodeButton.Location = new System.Drawing.Point(343, 105);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(184, 33);
            this.addNodeButton.TabIndex = 8;
            this.addNodeButton.Text = "Add";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);
            // 
            // mainNodeCheckBox
            // 
            this.mainNodeCheckBox.Location = new System.Drawing.Point(343, 69);
            this.mainNodeCheckBox.Name = "mainNodeCheckBox";
            this.mainNodeCheckBox.Size = new System.Drawing.Size(184, 30);
            this.mainNodeCheckBox.TabIndex = 7;
            this.mainNodeCheckBox.Text = "Create Node at Top?";
            this.mainNodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(344, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Node Name";
            this.nameTextBox.Size = new System.Drawing.Size(184, 27);
            this.nameTextBox.TabIndex = 6;
            // 
            // mainTreeView
            // 
            this.mainTreeView.Location = new System.Drawing.Point(46, 27);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.Size = new System.Drawing.Size(262, 249);
            this.mainTreeView.TabIndex = 5;
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            // 
            // updateNodeButton
            // 
            this.updateNodeButton.Location = new System.Drawing.Point(343, 183);
            this.updateNodeButton.Name = "updateNodeButton";
            this.updateNodeButton.Size = new System.Drawing.Size(184, 33);
            this.updateNodeButton.TabIndex = 10;
            this.updateNodeButton.Text = "Update";
            this.updateNodeButton.UseVisualStyleBackColor = true;
            this.updateNodeButton.Click += new System.EventHandler(this.UpdateNodeButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.Location = new System.Drawing.Point(344, 251);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(183, 25);
            this.pathLabel.TabIndex = 11;
            // 
            // TreeViewNodesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 314);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.updateNodeButton);
            this.Controls.Add(this.removeNodeButton);
            this.Controls.Add(this.addNodeButton);
            this.Controls.Add(this.mainNodeCheckBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.mainTreeView);
            this.Name = "TreeViewNodesCRUD";
            this.Text = "Tree View Nodes CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button removeNodeButton;
        private Button addNodeButton;
        private CheckBox mainNodeCheckBox;
        private TextBox nameTextBox;
        private TreeView mainTreeView;
        private Button updateNodeButton;
        private Label pathLabel;
    }
}