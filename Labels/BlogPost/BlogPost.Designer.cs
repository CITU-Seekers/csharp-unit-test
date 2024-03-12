namespace CodeChum
{
    partial class BlogPost
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
            titleLabel = new Label();
            authorLabel = new Label();
            contentLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(359, 137);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(29, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(359, 173);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(44, 15);
            authorLabel.TabIndex = 1;
            authorLabel.Text = "Author";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new Point(359, 212);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(50, 15);
            contentLabel.TabIndex = 2;
            contentLabel.Text = "Content";
            // 
            // BlogPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contentLabel);
            Controls.Add(authorLabel);
            Controls.Add(titleLabel);
            Name = "BlogPost";
            Text = "Form1";
            Load += Problem1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label authorLabel;
        private Label contentLabel;
    }
}