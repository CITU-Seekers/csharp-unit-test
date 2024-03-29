﻿namespace CodeChum
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
            this.musicListBox = new System.Windows.Forms.ListBox();
            this.musicTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musicListBox
            // 
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.ItemHeight = 20;
            this.musicListBox.Location = new System.Drawing.Point(47, 78);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(318, 224);
            this.musicListBox.TabIndex = 0;
            // 
            // musicTextBox
            // 
            this.musicTextBox.Location = new System.Drawing.Point(47, 35);
            this.musicTextBox.Name = "musicTextBox";
            this.musicTextBox.PlaceholderText = "Title";
            this.musicTextBox.Size = new System.Drawing.Size(318, 27);
            this.musicTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(47, 333);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 31);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Music";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(232, 333);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(132, 31);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove Music";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 415);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.musicTextBox);
            this.Controls.Add(this.musicListBox);
            this.Name = "MusicList";
            this.Text = "Music List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox musicListBox;
        private TextBox musicTextBox;
        private Button addButton;
        private Button removeButton;
    }
}