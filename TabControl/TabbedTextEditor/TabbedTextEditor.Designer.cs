namespace CodeChum
{
    partial class TabbedTextEditor
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
            this.EditorTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditorTabControl.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorTabControl
            // 
            this.EditorTabControl.Controls.Add(this.MainTabPage);
            this.EditorTabControl.Location = new System.Drawing.Point(3, 1);
            this.EditorTabControl.Name = "EditorTabControl";
            this.EditorTabControl.SelectedIndex = 0;
            this.EditorTabControl.Size = new System.Drawing.Size(708, 306);
            this.EditorTabControl.TabIndex = 0;
            this.EditorTabControl.SelectedIndexChanged += new System.EventHandler(this.EditorTabControl_SelectedIndexChanged);
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.MainRichTextBox);
            this.MainTabPage.Location = new System.Drawing.Point(4, 29);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(700, 273);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Main";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Location = new System.Drawing.Point(29, 38);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(641, 188);
            this.MainRichTextBox.TabIndex = 0;
            this.MainRichTextBox.Text = "";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(36, 312);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.PlaceholderText = "File Name";
            this.FileNameTextBox.Size = new System.Drawing.Size(221, 27);
            this.FileNameTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(261, 312);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 25);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Tab";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(350, 313);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 25);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete Tab";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TabbedTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 391);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.EditorTabControl);
            this.Name = "TabbedTextEditor";
            this.Text = "Tabbed Text Editor";
            this.EditorTabControl.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl EditorTabControl;
        private TabPage MainTabPage;
        private RichTextBox MainRichTextBox;
        private TextBox FileNameTextBox;
        private Button AddButton;
        private Button DeleteButton;
    }
}