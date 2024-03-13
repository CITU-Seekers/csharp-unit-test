namespace CodeChum
{
    partial class BookInterface
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
            mainSplitter = new Splitter();
            booksComboBox = new ComboBox();
            chapterTextBox = new TextBox();
            bookListBox = new ListBox();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // mainSplitter
            // 
            mainSplitter.BackColor = Color.Gray;
            mainSplitter.Location = new Point(0, 0);
            mainSplitter.Name = "mainSplitter";
            mainSplitter.Size = new Size(402, 450);
            mainSplitter.TabIndex = 0;
            mainSplitter.TabStop = false;
            // 
            // booksComboBox
            // 
            booksComboBox.FormattingEnabled = true;
            booksComboBox.Items.AddRange(new object[] { "Harry Potter", "Magnus Chase", "Percy Jackson", "The Maze Runner", "The Hunger Games" });
            booksComboBox.Location = new Point(94, 39);
            booksComboBox.Name = "booksComboBox";
            booksComboBox.Size = new Size(177, 23);
            booksComboBox.TabIndex = 1;
            booksComboBox.SelectedIndexChanged += cboBooks_SelectedIndexChanged;
            // 
            // chapterTextBox
            // 
            chapterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chapterTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chapterTextBox.Location = new Point(54, 37);
            chapterTextBox.Multiline = true;
            chapterTextBox.Name = "chapterTextBox";
            chapterTextBox.ScrollBars = ScrollBars.Vertical;
            chapterTextBox.Size = new Size(319, 362);
            chapterTextBox.TabIndex = 2;
            // 
            // bookListBox
            // 
            bookListBox.FormattingEnabled = true;
            bookListBox.ItemHeight = 15;
            bookListBox.Location = new Point(58, 104);
            bookListBox.Name = "bookListBox";
            bookListBox.Size = new Size(260, 244);
            bookListBox.TabIndex = 3;
            bookListBox.SelectedIndexChanged += BookList_SelectedIndexChanged;
            // 
            // panel
            // 
            panel.BackColor = Color.Brown;
            panel.Controls.Add(chapterTextBox);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(402, 0);
            panel.Name = "panel";
            panel.Size = new Size(398, 450);
            panel.TabIndex = 4;
            // 
            // BookInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(bookListBox);
            Controls.Add(booksComboBox);
            Controls.Add(mainSplitter);
            Name = "BookInterface";
            Text = "BookInterface";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Splitter mainSplitter;
        private System.Windows.Forms.ComboBox booksComboBox;
        private TextBox chapterTextBox;
        private System.Windows.Forms.ListBox bookListBox;
        private Panel panel;
    }
}