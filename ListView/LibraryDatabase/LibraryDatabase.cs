using System.Diagnostics;

namespace CodeChum
{
    public partial class LibraryDatabase : Form
    {
        private BookList? bookList;
        CheckBox[] checkboxes;
        public LibraryDatabase()
        {
            bookList = new BookList();
            InitializeComponent();
            checkboxes = new CheckBox[] { ActionCheckBox, AdventureCheckBox, FantasyCheckBox, HorrorCheckBox, RomanceCheckBox, SciFiCheckBox, TragedyCheckBox };
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string author = AuthorTextBox.Text;
            string title = TitleTextBox.Text;
            string isbn = IsbnTextBox.Text;
            float rating = (float)RatingNumericControl.Value;
            string genre = "";

            foreach (var x in checkboxes)
            {
                if (x.Checked)
                {
                    genre += x.Text + ",";
                }
            }
            
            DateTime date = DatePublishedDateTimePicker.Value;
            Book book = new Book(isbn, title, author, genre, rating, date);
            bookList.AddBook(book);
            string[] row = { isbn, title, author, genre.Split(",")[0], rating.ToString("0.0"), date.ToString() };
            BookListView.Items.Add(new ListViewItem(row));
        }

        private void BookListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Book book = bookList.RetrieveBook(BookListView.SelectedItems[0].SubItems[0].Text);

            IsbnTextBox.Text = book.Isbn;
            AuthorTextBox.Text = book.Author;
            TitleTextBox.Text = book.Title;
            RatingNumericControl.Value = (decimal)book.Rating;
            DatePublishedDateTimePicker.Value = book.DatePublished;
        }

        private void BookListView_ItemActivate(object sender, EventArgs e)
        {
            Book book = bookList.RetrieveBook(BookListView.SelectedItems[0].SubItems[0].Text);

            IsbnTextBox.Text = book.Isbn;
            AuthorTextBox.Text = book.Author;
            TitleTextBox.Text = book.Title;
            RatingNumericControl.Value = (decimal)book.Rating;
            DatePublishedDateTimePicker.Value = book.DatePublished;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in BookListView.SelectedItems)
            {
                bookList.RemoveBook(item.SubItems[0].Text);
                BookListView.Items.Remove(item);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string author = AuthorTextBox.Text;
            string title = TitleTextBox.Text;
            string isbn = IsbnTextBox.Text;
            float rating = (float)RatingNumericControl.Value;
            string genre = "";

            foreach (var x in checkboxes)
            {
                if (x.Checked)
                {
                    genre += x.Text + ",";
                }
            }
            DateTime date = DatePublishedDateTimePicker.Value;
            Book book = new Book(isbn, title, author, genre, rating, date);

            bookList.UpdateBook(book);
            string[] row = { isbn, title, author, genre.Split(",")[0], rating.ToString("0.0"), date.ToString() };

            foreach (ListViewItem item in BookListView.Items)
            {
                if (item.SubItems[0].Text.Equals(isbn))
                {
                    BookListView.Items[item.Index] = new ListViewItem(row);
                }
            }
        }

        private void BookListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListView.SelectedIndices.Count <= 0)
            {
                return;
            }
            Book book = bookList.RetrieveBook(BookListView.SelectedItems[0].SubItems[0].Text);

            IsbnTextBox.Text = book.Isbn;
            AuthorTextBox.Text = book.Author;
            TitleTextBox.Text = book.Title;
            RatingNumericControl.Value = (decimal)book.Rating;
            DatePublishedDateTimePicker.Value = book.DatePublished;

            String[] genres = book.Genre.Split(",");

            foreach (CheckBox cb in checkboxes)
            {
                if (genres.Contains(cb.Text))
                {
                    cb.Checked = true;
                }
                else
                {
                    cb.Checked = false;
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
