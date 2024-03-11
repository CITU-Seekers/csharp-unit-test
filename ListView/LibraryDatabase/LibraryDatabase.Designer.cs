namespace CodeChum
{
    partial class LibraryDatabase
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
            this.BookListView = new System.Windows.Forms.ListView();
            this.ISBN = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Author = new System.Windows.Forms.ColumnHeader();
            this.Genre = new System.Windows.Forms.ColumnHeader();
            this.Rating = new System.Windows.Forms.ColumnHeader();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.GenreGroupBox = new System.Windows.Forms.GroupBox();
            this.TragedyCheckBox = new System.Windows.Forms.CheckBox();
            this.SciFiCheckBox = new System.Windows.Forms.CheckBox();
            this.RomanceCheckBox = new System.Windows.Forms.CheckBox();
            this.HorrorCheckBox = new System.Windows.Forms.CheckBox();
            this.FantasyCheckBox = new System.Windows.Forms.CheckBox();
            this.AdventureCheckBox = new System.Windows.Forms.CheckBox();
            this.ActionCheckBox = new System.Windows.Forms.CheckBox();
            this.RatingNumericControl = new System.Windows.Forms.NumericUpDown();
            this.DatePublishedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.GenreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingNumericControl)).BeginInit();
            this.SuspendLayout();
            // 
            // BookListView
            // 
            this.BookListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.Genre,
            this.Rating});
            this.BookListView.FullRowSelect = true;
            this.BookListView.Location = new System.Drawing.Point(28, 26);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(516, 190);
            this.BookListView.TabIndex = 0;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
            this.BookListView.ItemActivate += new System.EventHandler(this.BookListView_ItemActivate);
            this.BookListView.SelectedIndexChanged += new System.EventHandler(this.BookListView_SelectedIndexChanged);
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
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 100;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            this.Rating.Width = 100;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(28, 229);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.PlaceholderText = "Author";
            this.AuthorTextBox.Size = new System.Drawing.Size(516, 27);
            this.AuthorTextBox.TabIndex = 1;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(28, 260);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PlaceholderText = "Title";
            this.TitleTextBox.Size = new System.Drawing.Size(516, 27);
            this.TitleTextBox.TabIndex = 2;
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(28, 291);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.PlaceholderText = "ISBN";
            this.IsbnTextBox.Size = new System.Drawing.Size(516, 27);
            this.IsbnTextBox.TabIndex = 3;
            // 
            // GenreGroupBox
            // 
            this.GenreGroupBox.Controls.Add(this.TragedyCheckBox);
            this.GenreGroupBox.Controls.Add(this.SciFiCheckBox);
            this.GenreGroupBox.Controls.Add(this.RomanceCheckBox);
            this.GenreGroupBox.Controls.Add(this.HorrorCheckBox);
            this.GenreGroupBox.Controls.Add(this.FantasyCheckBox);
            this.GenreGroupBox.Controls.Add(this.AdventureCheckBox);
            this.GenreGroupBox.Controls.Add(this.ActionCheckBox);
            this.GenreGroupBox.Location = new System.Drawing.Point(564, 26);
            this.GenreGroupBox.Name = "GenreGroupBox";
            this.GenreGroupBox.Size = new System.Drawing.Size(261, 190);
            this.GenreGroupBox.TabIndex = 4;
            this.GenreGroupBox.TabStop = false;
            this.GenreGroupBox.Text = "Genre";
            // 
            // TragedyCheckBox
            // 
            this.TragedyCheckBox.AutoSize = true;
            this.TragedyCheckBox.Location = new System.Drawing.Point(139, 54);
            this.TragedyCheckBox.Name = "TragedyCheckBox";
            this.TragedyCheckBox.Size = new System.Drawing.Size(84, 24);
            this.TragedyCheckBox.TabIndex = 6;
            this.TragedyCheckBox.Text = "Tragedy";
            this.TragedyCheckBox.UseVisualStyleBackColor = true;
            // 
            // SciFiCheckBox
            // 
            this.SciFiCheckBox.AutoSize = true;
            this.SciFiCheckBox.Location = new System.Drawing.Point(139, 25);
            this.SciFiCheckBox.Name = "SciFiCheckBox";
            this.SciFiCheckBox.Size = new System.Drawing.Size(65, 24);
            this.SciFiCheckBox.TabIndex = 5;
            this.SciFiCheckBox.Text = "Sci-fi";
            this.SciFiCheckBox.UseVisualStyleBackColor = true;
            // 
            // RomanceCheckBox
            // 
            this.RomanceCheckBox.AutoSize = true;
            this.RomanceCheckBox.Location = new System.Drawing.Point(13, 140);
            this.RomanceCheckBox.Name = "RomanceCheckBox";
            this.RomanceCheckBox.Size = new System.Drawing.Size(93, 24);
            this.RomanceCheckBox.TabIndex = 4;
            this.RomanceCheckBox.Text = "Romance";
            this.RomanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // HorrorCheckBox
            // 
            this.HorrorCheckBox.AutoSize = true;
            this.HorrorCheckBox.Location = new System.Drawing.Point(13, 111);
            this.HorrorCheckBox.Name = "HorrorCheckBox";
            this.HorrorCheckBox.Size = new System.Drawing.Size(75, 24);
            this.HorrorCheckBox.TabIndex = 3;
            this.HorrorCheckBox.Text = "Horror";
            this.HorrorCheckBox.UseVisualStyleBackColor = true;
            // 
            // FantasyCheckBox
            // 
            this.FantasyCheckBox.AutoSize = true;
            this.FantasyCheckBox.Location = new System.Drawing.Point(13, 83);
            this.FantasyCheckBox.Name = "FantasyCheckBox";
            this.FantasyCheckBox.Size = new System.Drawing.Size(79, 24);
            this.FantasyCheckBox.TabIndex = 2;
            this.FantasyCheckBox.Text = "Fantasy";
            this.FantasyCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdventureCheckBox
            // 
            this.AdventureCheckBox.AutoSize = true;
            this.AdventureCheckBox.Location = new System.Drawing.Point(13, 54);
            this.AdventureCheckBox.Name = "AdventureCheckBox";
            this.AdventureCheckBox.Size = new System.Drawing.Size(99, 24);
            this.AdventureCheckBox.TabIndex = 1;
            this.AdventureCheckBox.Text = "Adventure";
            this.AdventureCheckBox.UseVisualStyleBackColor = true;
            // 
            // ActionCheckBox
            // 
            this.ActionCheckBox.AutoSize = true;
            this.ActionCheckBox.Location = new System.Drawing.Point(13, 25);
            this.ActionCheckBox.Name = "ActionCheckBox";
            this.ActionCheckBox.Size = new System.Drawing.Size(74, 24);
            this.ActionCheckBox.TabIndex = 0;
            this.ActionCheckBox.Text = "Action";
            this.ActionCheckBox.UseVisualStyleBackColor = true;
            // 
            // RatingNumericControl
            // 
            this.RatingNumericControl.DecimalPlaces = 1;
            this.RatingNumericControl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RatingNumericControl.Location = new System.Drawing.Point(564, 229);
            this.RatingNumericControl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RatingNumericControl.Name = "RatingNumericControl";
            this.RatingNumericControl.Size = new System.Drawing.Size(261, 27);
            this.RatingNumericControl.TabIndex = 5;
            // 
            // DatePublishedDateTimePicker
            // 
            this.DatePublishedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePublishedDateTimePicker.Location = new System.Drawing.Point(564, 260);
            this.DatePublishedDateTimePicker.Name = "DatePublishedDateTimePicker";
            this.DatePublishedDateTimePicker.Size = new System.Drawing.Size(262, 27);
            this.DatePublishedDateTimePicker.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(564, 292);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 26);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(653, 292);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(84, 26);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(742, 292);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(84, 26);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // LibraryDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 342);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DatePublishedDateTimePicker);
            this.Controls.Add(this.RatingNumericControl);
            this.Controls.Add(this.GenreGroupBox);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.BookListView);
            this.Name = "LibraryDatabase";
            this.Text = "Library Database";
            this.GenreGroupBox.ResumeLayout(false);
            this.GenreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingNumericControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView BookListView;
        private ColumnHeader ISBN;
        private ColumnHeader Title;
        private ColumnHeader Author;
        private ColumnHeader Genre;
        private ColumnHeader Rating;
        private TextBox AuthorTextBox;
        private TextBox TitleTextBox;
        private TextBox IsbnTextBox;
        private GroupBox GenreGroupBox;
        private CheckBox TragedyCheckBox;
        private CheckBox SciFiCheckBox;
        private CheckBox RomanceCheckBox;
        private CheckBox HorrorCheckBox;
        private CheckBox FantasyCheckBox;
        private CheckBox AdventureCheckBox;
        private CheckBox ActionCheckBox;
        private NumericUpDown RatingNumericControl;
        private DateTimePicker DatePublishedDateTimePicker;
        private Button AddButton;
        private Button RemoveButton;
        private Button UpdateButton;
    }
}