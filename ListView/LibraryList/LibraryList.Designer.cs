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
            this.bookListView = new System.Windows.Forms.ListView();
            this.ISBN = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Author = new System.Windows.Forms.ColumnHeader();
            this.DatePublished = new System.Windows.Forms.ColumnHeader();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.datePublishedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.AutoArrange = false;
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.DatePublished});
            this.bookListView.FullRowSelect = true;
            this.bookListView.GridLines = true;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.bookListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.bookListView.Location = new System.Drawing.Point(27, 10);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(456, 308);
            this.bookListView.TabIndex = 0;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
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
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(27, 340);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.PlaceholderText = "Author";
            this.authorTextBox.Size = new System.Drawing.Size(456, 27);
            this.authorTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(27, 371);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PlaceholderText = "Title";
            this.titleTextBox.Size = new System.Drawing.Size(456, 27);
            this.titleTextBox.TabIndex = 2;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(27, 403);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.PlaceholderText = "ISBN";
            this.isbnTextBox.Size = new System.Drawing.Size(456, 27);
            this.isbnTextBox.TabIndex = 3;
            // 
            // datePublishedDateTimePicker
            // 
            this.datePublishedDateTimePicker.Location = new System.Drawing.Point(27, 434);
            this.datePublishedDateTimePicker.Name = "datePublishedDateTimePicker";
            this.datePublishedDateTimePicker.Size = new System.Drawing.Size(456, 27);
            this.datePublishedDateTimePicker.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(68, 481);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(152, 36);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(287, 481);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(144, 36);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // LibraryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 529);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.datePublishedDateTimePicker);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.bookListView);
            this.Name = "LibraryList";
            this.Text = "Library List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookListView;
        private ColumnHeader ISBN;
        private ColumnHeader Title;
        private ColumnHeader Author;
        private ColumnHeader DatePublished;
        private TextBox authorTextBox;
        private TextBox titleTextBox;
        private TextBox isbnTextBox;
        private DateTimePicker datePublishedDateTimePicker;
        private Button addButton;
        private Button removeButton;
    }
}