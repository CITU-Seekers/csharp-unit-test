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
            this.bookListView = new System.Windows.Forms.ListView();
            this.ISBN = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Author = new System.Windows.Forms.ColumnHeader();
            this.Genre = new System.Windows.Forms.ColumnHeader();
            this.Rating = new System.Windows.Forms.ColumnHeader();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.genreGroupBox = new System.Windows.Forms.GroupBox();
            this.tragedyCheckBox = new System.Windows.Forms.CheckBox();
            this.sciFiCheckBox = new System.Windows.Forms.CheckBox();
            this.romanceCheckBox = new System.Windows.Forms.CheckBox();
            this.horrorCheckBox = new System.Windows.Forms.CheckBox();
            this.fantasyCheckBox = new System.Windows.Forms.CheckBox();
            this.adventureCheckBox = new System.Windows.Forms.CheckBox();
            this.actionCheckBox = new System.Windows.Forms.CheckBox();
            this.ratingNumericControl = new System.Windows.Forms.NumericUpDown();
            this.datePublishedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.genreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericControl)).BeginInit();
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.Genre,
            this.Rating});
            this.bookListView.FullRowSelect = true;
            this.bookListView.Location = new System.Drawing.Point(28, 26);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(516, 190);
            this.bookListView.TabIndex = 0;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            this.bookListView.ItemActivate += new System.EventHandler(this.BookListView_ItemActivate);
            this.bookListView.SelectedIndexChanged += new System.EventHandler(this.BookListView_SelectedIndexChanged);
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
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(28, 229);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.PlaceholderText = "Author";
            this.authorTextBox.Size = new System.Drawing.Size(516, 27);
            this.authorTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(28, 260);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PlaceholderText = "Title";
            this.titleTextBox.Size = new System.Drawing.Size(516, 27);
            this.titleTextBox.TabIndex = 2;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(28, 291);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.PlaceholderText = "ISBN";
            this.isbnTextBox.Size = new System.Drawing.Size(516, 27);
            this.isbnTextBox.TabIndex = 3;
            // 
            // genreGroupBox
            // 
            this.genreGroupBox.Controls.Add(this.tragedyCheckBox);
            this.genreGroupBox.Controls.Add(this.sciFiCheckBox);
            this.genreGroupBox.Controls.Add(this.romanceCheckBox);
            this.genreGroupBox.Controls.Add(this.horrorCheckBox);
            this.genreGroupBox.Controls.Add(this.fantasyCheckBox);
            this.genreGroupBox.Controls.Add(this.adventureCheckBox);
            this.genreGroupBox.Controls.Add(this.actionCheckBox);
            this.genreGroupBox.Location = new System.Drawing.Point(564, 26);
            this.genreGroupBox.Name = "genreGroupBox";
            this.genreGroupBox.Size = new System.Drawing.Size(261, 190);
            this.genreGroupBox.TabIndex = 4;
            this.genreGroupBox.TabStop = false;
            this.genreGroupBox.Text = "Genre";
            // 
            // tragedyCheckBox
            // 
            this.tragedyCheckBox.AutoSize = true;
            this.tragedyCheckBox.Location = new System.Drawing.Point(139, 54);
            this.tragedyCheckBox.Name = "tragedyCheckBox";
            this.tragedyCheckBox.Size = new System.Drawing.Size(84, 24);
            this.tragedyCheckBox.TabIndex = 6;
            this.tragedyCheckBox.Text = "Tragedy";
            this.tragedyCheckBox.UseVisualStyleBackColor = true;
            // 
            // sciFiCheckBox
            // 
            this.sciFiCheckBox.AutoSize = true;
            this.sciFiCheckBox.Location = new System.Drawing.Point(139, 25);
            this.sciFiCheckBox.Name = "sciFiCheckBox";
            this.sciFiCheckBox.Size = new System.Drawing.Size(65, 24);
            this.sciFiCheckBox.TabIndex = 5;
            this.sciFiCheckBox.Text = "Sci-fi";
            this.sciFiCheckBox.UseVisualStyleBackColor = true;
            // 
            // romanceCheckBox
            // 
            this.romanceCheckBox.AutoSize = true;
            this.romanceCheckBox.Location = new System.Drawing.Point(13, 140);
            this.romanceCheckBox.Name = "romanceCheckBox";
            this.romanceCheckBox.Size = new System.Drawing.Size(93, 24);
            this.romanceCheckBox.TabIndex = 4;
            this.romanceCheckBox.Text = "Romance";
            this.romanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // horrorCheckBox
            // 
            this.horrorCheckBox.AutoSize = true;
            this.horrorCheckBox.Location = new System.Drawing.Point(13, 111);
            this.horrorCheckBox.Name = "horrorCheckBox";
            this.horrorCheckBox.Size = new System.Drawing.Size(75, 24);
            this.horrorCheckBox.TabIndex = 3;
            this.horrorCheckBox.Text = "Horror";
            this.horrorCheckBox.UseVisualStyleBackColor = true;
            // 
            // fantasyCheckBox
            // 
            this.fantasyCheckBox.AutoSize = true;
            this.fantasyCheckBox.Location = new System.Drawing.Point(13, 83);
            this.fantasyCheckBox.Name = "fantasyCheckBox";
            this.fantasyCheckBox.Size = new System.Drawing.Size(79, 24);
            this.fantasyCheckBox.TabIndex = 2;
            this.fantasyCheckBox.Text = "Fantasy";
            this.fantasyCheckBox.UseVisualStyleBackColor = true;
            // 
            // adventureCheckBox
            // 
            this.adventureCheckBox.AutoSize = true;
            this.adventureCheckBox.Location = new System.Drawing.Point(13, 54);
            this.adventureCheckBox.Name = "adventureCheckBox";
            this.adventureCheckBox.Size = new System.Drawing.Size(99, 24);
            this.adventureCheckBox.TabIndex = 1;
            this.adventureCheckBox.Text = "Adventure";
            this.adventureCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionCheckBox
            // 
            this.actionCheckBox.AutoSize = true;
            this.actionCheckBox.Location = new System.Drawing.Point(13, 25);
            this.actionCheckBox.Name = "actionCheckBox";
            this.actionCheckBox.Size = new System.Drawing.Size(74, 24);
            this.actionCheckBox.TabIndex = 0;
            this.actionCheckBox.Text = "Action";
            this.actionCheckBox.UseVisualStyleBackColor = true;
            // 
            // ratingNumericControl
            // 
            this.ratingNumericControl.DecimalPlaces = 1;
            this.ratingNumericControl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ratingNumericControl.Location = new System.Drawing.Point(564, 229);
            this.ratingNumericControl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingNumericControl.Name = "ratingNumericControl";
            this.ratingNumericControl.Size = new System.Drawing.Size(261, 27);
            this.ratingNumericControl.TabIndex = 5;
            // 
            // datePublishedDateTimePicker
            // 
            this.datePublishedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePublishedDateTimePicker.Location = new System.Drawing.Point(564, 260);
            this.datePublishedDateTimePicker.Name = "datePublishedDateTimePicker";
            this.datePublishedDateTimePicker.Size = new System.Drawing.Size(262, 27);
            this.datePublishedDateTimePicker.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(564, 292);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 26);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(653, 292);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(84, 26);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(742, 292);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(84, 26);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // LibraryDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 342);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.datePublishedDateTimePicker);
            this.Controls.Add(this.ratingNumericControl);
            this.Controls.Add(this.genreGroupBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.bookListView);
            this.Name = "LibraryDatabase";
            this.Text = "Library Database";
            this.genreGroupBox.ResumeLayout(false);
            this.genreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView bookListView;
        private ColumnHeader ISBN;
        private ColumnHeader Title;
        private ColumnHeader Author;
        private ColumnHeader Genre;
        private ColumnHeader Rating;
        private TextBox authorTextBox;
        private TextBox titleTextBox;
        private TextBox isbnTextBox;
        private GroupBox genreGroupBox;
        private CheckBox tragedyCheckBox;
        private CheckBox sciFiCheckBox;
        private CheckBox romanceCheckBox;
        private CheckBox horrorCheckBox;
        private CheckBox fantasyCheckBox;
        private CheckBox adventureCheckBox;
        private CheckBox actionCheckBox;
        private NumericUpDown ratingNumericControl;
        private DateTimePicker datePublishedDateTimePicker;
        private Button addButton;
        private Button removeButton;
        private Button updateButton;
    }
}