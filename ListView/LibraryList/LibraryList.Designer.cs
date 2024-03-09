namespace CodeChum
{
    partial class LibraryList
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.BookListView = new System.Windows.Forms.ListView();
            this.ISBN = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Author = new System.Windows.Forms.ColumnHeader();
            this.DatePublished = new System.Windows.Forms.ColumnHeader();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.DatePublishedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookListView
            // 
            this.BookListView.AutoArrange = false;
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.DatePublished});
            this.BookListView.FullRowSelect = true;
            this.BookListView.GridLines = true;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.BookListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.BookListView.Location = new System.Drawing.Point(27, 10);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(456, 308);
            this.BookListView.TabIndex = 0;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 100;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 100;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 100;
            // 
            // DatePublished
            // 
            this.DatePublished.Text = "Date Published";
            this.DatePublished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatePublished.Width = 150;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(27, 340);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.PlaceholderText = "Author";
            this.AuthorTextBox.Size = new System.Drawing.Size(456, 27);
            this.AuthorTextBox.TabIndex = 1;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(27, 371);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PlaceholderText = "Title";
            this.TitleTextBox.Size = new System.Drawing.Size(456, 27);
            this.TitleTextBox.TabIndex = 2;
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(27, 403);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.PlaceholderText = "ISBN";
            this.IsbnTextBox.Size = new System.Drawing.Size(456, 27);
            this.IsbnTextBox.TabIndex = 3;
            // 
            // DatePublishedDateTimePicker
            // 
            this.DatePublishedDateTimePicker.Location = new System.Drawing.Point(27, 434);
            this.DatePublishedDateTimePicker.Name = "DatePublishedDateTimePicker";
            this.DatePublishedDateTimePicker.Size = new System.Drawing.Size(456, 27);
            this.DatePublishedDateTimePicker.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(68, 481);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(152, 36);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(287, 481);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(144, 36);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // LibraryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 529);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DatePublishedDateTimePicker);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.BookListView);
            this.Name = "LibraryList";
            this.Text = "Library List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView BookListView;
        private ColumnHeader ISBN;
        private ColumnHeader Title;
        private ColumnHeader Author;
        private ColumnHeader DatePublished;
        private TextBox AuthorTextBox;
        private TextBox TitleTextBox;
        private TextBox IsbnTextBox;
        private DateTimePicker DatePublishedDateTimePicker;
        private Button AddButton;
        private Button RemoveButton;
    }
}