namespace CodeChum
{
    partial class BookLibrary
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
            mainTabControl = new TabControl();
            tabPage1 = new TabPage();
            viewButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            statusComboBox = new ComboBox();
            publishedDateDateTimePicker = new DateTimePicker();
            genreTextBox = new TextBox();
            authorTextBox = new TextBox();
            titleTextBox = new TextBox();
            bookListView = new ListView();
            BookTitle = new ColumnHeader();
            BookAuthor = new ColumnHeader();
            BookGenre = new ColumnHeader();
            PubYear = new ColumnHeader();
            BookStatus = new ColumnHeader();
            mainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Location = new Point(34, 26);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(593, 307);
            mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(viewButton);
            tabPage1.Controls.Add(deleteButton);
            tabPage1.Controls.Add(updateButton);
            tabPage1.Controls.Add(addButton);
            tabPage1.Controls.Add(statusComboBox);
            tabPage1.Controls.Add(publishedDateDateTimePicker);
            tabPage1.Controls.Add(genreTextBox);
            tabPage1.Controls.Add(authorTextBox);
            tabPage1.Controls.Add(titleTextBox);
            tabPage1.Controls.Add(bookListView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(585, 279);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(505, 234);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(57, 23);
            viewButton.TabIndex = 9;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += ViewButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(442, 234);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(57, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(379, 234);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(57, 23);
            updateButton.TabIndex = 7;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(316, 234);
            addButton.Name = "addButton";
            addButton.Size = new Size(57, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Available", "Borrowed", "Out of Stock" });
            statusComboBox.Location = new Point(316, 194);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(121, 23);
            statusComboBox.TabIndex = 5;
            // 
            // publishedDateDateTimePicker
            // 
            publishedDateDateTimePicker.Location = new Point(316, 165);
            publishedDateDateTimePicker.Name = "publishedDateDateTimePicker";
            publishedDateDateTimePicker.Size = new Size(200, 23);
            publishedDateDateTimePicker.TabIndex = 4;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(30, 223);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(240, 23);
            genreTextBox.TabIndex = 3;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(30, 194);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(240, 23);
            authorTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(30, 165);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(240, 23);
            titleTextBox.TabIndex = 1;
            // 
            // bookListView
            // 
            bookListView.Columns.AddRange(new ColumnHeader[] { BookTitle, BookAuthor, BookGenre, PubYear, BookStatus });
            bookListView.Location = new Point(30, 18);
            bookListView.Name = "bookListView";
            bookListView.Size = new Size(520, 124);
            bookListView.TabIndex = 0;
            bookListView.UseCompatibleStateImageBehavior = false;
            bookListView.View = View.Details;
            // 
            // BookTitle
            // 
            BookTitle.Text = "Title";
            BookTitle.Width = 150;
            // 
            // BookAuthor
            // 
            BookAuthor.Text = "Author";
            BookAuthor.Width = 120;
            // 
            // BookGenre
            // 
            BookGenre.Text = "Genre";
            BookGenre.Width = 80;
            // 
            // PubYear
            // 
            PubYear.Text = "Pub Year";
            PubYear.Width = 80;
            // 
            // BookStatus
            // 
            BookStatus.Text = "Status";
            BookStatus.Width = 80;
            // 
            // BookLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 363);
            Controls.Add(mainTabControl);
            Name = "BookLibrary";
            Text = "BookLibrary";
            mainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage tabPage1;
        private Button updateButton;
        private Button addButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker publishedDateDateTimePicker;
        private TextBox genreTextBox;
        private TextBox authorTextBox;
        private TextBox titleTextBox;
        private ListView bookListView;
        private ColumnHeader BookTitle;
        private ColumnHeader BookAuthor;
        private ColumnHeader BookGenre;
        private ColumnHeader PubYear;
        private ColumnHeader BookStatus;
        private Button deleteButton;
        private Button viewButton;
    }
}