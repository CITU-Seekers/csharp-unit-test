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
            MainTabControl = new TabControl();
            tabPage1 = new TabPage();
            ViewButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            cboStatus = new System.Windows.Forms.ComboBox();
            PubDate = new System.Windows.Forms.DateTimePicker();
            txtGenre = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            BookList = new ListView();
            BookTitle = new ColumnHeader();
            BookAuthor = new ColumnHeader();
            BookGenre = new ColumnHeader();
            PubYear = new ColumnHeader();
            BookStatus = new ColumnHeader();
            MainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(tabPage1);
            MainTabControl.Location = new Point(34, 26);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(593, 307);
            MainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ViewButton);
            tabPage1.Controls.Add(DeleteButton);
            tabPage1.Controls.Add(UpdateButton);
            tabPage1.Controls.Add(AddButton);
            tabPage1.Controls.Add(cboStatus);
            tabPage1.Controls.Add(PubDate);
            tabPage1.Controls.Add(txtGenre);
            tabPage1.Controls.Add(txtAuthor);
            tabPage1.Controls.Add(txtTitle);
            tabPage1.Controls.Add(BookList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(585, 279);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ViewButton
            // 
            ViewButton.Location = new Point(505, 234);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(57, 23);
            ViewButton.TabIndex = 9;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(442, 234);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(57, 23);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(379, 234);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(57, 23);
            UpdateButton.TabIndex = 7;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(316, 234);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(57, 23);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Borrowed", "Out of Stock" });
            cboStatus.Location = new Point(316, 194);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 5;
            // 
            // PubDate
            // 
            PubDate.Location = new Point(316, 165);
            PubDate.Name = "PubDate";
            PubDate.Size = new Size(200, 23);
            PubDate.TabIndex = 4;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(30, 223);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(240, 23);
            txtGenre.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(30, 194);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(240, 23);
            txtAuthor.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(30, 165);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(240, 23);
            txtTitle.TabIndex = 1;
            // 
            // BookList
            // 
            BookList.Columns.AddRange(new ColumnHeader[] { BookTitle, BookAuthor, BookGenre, PubYear, BookStatus });
            BookList.Location = new Point(30, 18);
            BookList.Name = "BookList";
            BookList.Size = new Size(520, 124);
            BookList.TabIndex = 0;
            BookList.UseCompatibleStateImageBehavior = false;
            BookList.View = View.Details;
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
            Controls.Add(MainTabControl);
            Name = "BookLibrary";
            Text = "BookLibrary";
            MainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage tabPage1;
        private Button UpdateButton;
        private Button AddButton;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DateTimePicker PubDate;
        private TextBox txtGenre;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private ListView BookList;
        private ColumnHeader BookTitle;
        private ColumnHeader BookAuthor;
        private ColumnHeader BookGenre;
        private ColumnHeader PubYear;
        private ColumnHeader BookStatus;
        private Button DeleteButton;
        private Button ViewButton;
    }
}