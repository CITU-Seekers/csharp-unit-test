namespace CodeChum
{
    partial class MusicList
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
            this.MusicListBox = new System.Windows.Forms.ListBox();
            this.MusicTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MusicListBox
            // 
            this.MusicListBox.FormattingEnabled = true;
            this.MusicListBox.ItemHeight = 20;
            this.MusicListBox.Location = new System.Drawing.Point(47, 78);
            this.MusicListBox.Name = "MusicListBox";
            this.MusicListBox.Size = new System.Drawing.Size(318, 224);
            this.MusicListBox.TabIndex = 0;
            // 
            // MusicTextBox
            // 
            this.MusicTextBox.Location = new System.Drawing.Point(47, 35);
            this.MusicTextBox.Name = "MusicTextBox";
            this.MusicTextBox.PlaceholderText = "Title";
            this.MusicTextBox.Size = new System.Drawing.Size(318, 27);
            this.MusicTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(47, 333);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(139, 31);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Music";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(232, 333);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(132, 31);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove Music";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 415);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MusicTextBox);
            this.Controls.Add(this.MusicListBox);
            this.Name = "MusicList";
            this.Text = "Music List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MusicListBox;
        private TextBox MusicTextBox;
        private Button AddButton;
        private Button RemoveButton;
    }
}