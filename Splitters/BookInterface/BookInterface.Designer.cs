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
            MainSplitter = new Splitter();
            cboBooks = new System.Windows.Forms.ComboBox();
            ChapterBox = new TextBox();
            BookList = new System.Windows.Forms.ListBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitter
            // 
            MainSplitter.BackColor = Color.Gray;
            MainSplitter.Location = new Point(0, 0);
            MainSplitter.Name = "MainSplitter";
            MainSplitter.Size = new Size(402, 450);
            MainSplitter.TabIndex = 0;
            MainSplitter.TabStop = false;
            // 
            // cboBooks
            // 
            cboBooks.FormattingEnabled = true;
            cboBooks.Items.AddRange(new object[] { "Harry Potter", "Magnus Chase", "Percy Jackson", "The Maze Runner", "The Hunger Games" });
            cboBooks.Location = new Point(94, 39);
            cboBooks.Name = "cboBooks";
            cboBooks.Size = new Size(177, 23);
            cboBooks.TabIndex = 1;
            cboBooks.SelectedIndexChanged += cboBooks_SelectedIndexChanged;
            // 
            // ChapterBox
            // 
            ChapterBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChapterBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ChapterBox.Location = new Point(54, 37);
            ChapterBox.Multiline = true;
            ChapterBox.Name = "ChapterBox";
            ChapterBox.ScrollBars = ScrollBars.Vertical;
            ChapterBox.Size = new Size(319, 362);
            ChapterBox.TabIndex = 2;
            // 
            // BookList
            // 
            BookList.FormattingEnabled = true;
            BookList.ItemHeight = 15;
            BookList.Location = new Point(58, 104);
            BookList.Name = "BookList";
            BookList.Size = new Size(260, 244);
            BookList.TabIndex = 3;
            BookList.SelectedIndexChanged += BookList_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(ChapterBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(402, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 450);
            panel1.TabIndex = 4;
            // 
            // BookInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BookList);
            Controls.Add(cboBooks);
            Controls.Add(MainSplitter);
            Name = "BookInterface";
            Text = "BookInterface";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Splitter MainSplitter;
        private System.Windows.Forms.ComboBox cboBooks;
        private TextBox ChapterBox;
        private System.Windows.Forms.ListBox BookList;
        private Panel panel1;
    }
}