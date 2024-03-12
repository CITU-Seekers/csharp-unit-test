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
            this.editorTabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editorTabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorTabControl
            // 
            this.editorTabControl.Controls.Add(this.mainTabPage);
            this.editorTabControl.Location = new System.Drawing.Point(3, 1);
            this.editorTabControl.Name = "editorTabControl";
            this.editorTabControl.SelectedIndex = 0;
            this.editorTabControl.Size = new System.Drawing.Size(708, 306);
            this.editorTabControl.TabIndex = 0;
            this.editorTabControl.SelectedIndexChanged += new System.EventHandler(this.EditorTabControl_SelectedIndexChanged);
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.mainRichTextBox);
            this.mainTabPage.Location = new System.Drawing.Point(4, 29);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(700, 273);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Location = new System.Drawing.Point(29, 38);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(641, 188);
            this.mainRichTextBox.TabIndex = 0;
            this.mainRichTextBox.Text = "";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(36, 312);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.PlaceholderText = "File Name";
            this.fileNameTextBox.Size = new System.Drawing.Size(221, 27);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(261, 312);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 25);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Tab";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(350, 313);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 25);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Tab";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TabbedTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 391);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.editorTabControl);
            this.Name = "TabbedTextEditor";
            this.Text = "Tabbed Text Editor";
            this.editorTabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl editorTabControl;
        private TabPage mainTabPage;
        private RichTextBox mainRichTextBox;
        private TextBox fileNameTextBox;
        private Button addButton;
        private Button deleteButton;
    }
}