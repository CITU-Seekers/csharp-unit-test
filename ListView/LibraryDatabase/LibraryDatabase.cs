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
            checkboxes = new CheckBox[] { actionCheckBox, adventureCheckBox, fantasyCheckBox, horrorCheckBox, romanceCheckBox, sciFiCheckBox, tragedyCheckBox };
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string title = titleTextBox.Text;
            string isbn = isbnTextBox.Text;
            float rating = (float)ratingNumericControl.Value;
            string genre = "";

            foreach (var x in checkboxes)
            {
                if (x.Checked)
                {
                    genre += x.Text + ",";
                }
            }
            
            DateTime date = datePublishedDateTimePicker.Value;
            Book book = new Book(isbn, title, author, genre, rating, date);
            bookList.AddBook(book);
            string[] row = { isbn, title, author, genre.Split(",")[0], rating.ToString("0.0"), date.ToString() };
            bookListView.Items.Add(new ListViewItem(row));
        }

        private void BookListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Book book = bookList.RetrieveBook(bookListView.SelectedItems[0].SubItems[0].Text);

            isbnTextBox.Text = book.Isbn;
            authorTextBox.Text = book.Author;
            titleTextBox.Text = book.Title;
            ratingNumericControl.Value = (decimal)book.Rating;
            datePublishedDateTimePicker.Value = book.DatePublished;
        }

        private void BookListView_ItemActivate(object sender, EventArgs e)
        {
            Book book = bookList.RetrieveBook(bookListView.SelectedItems[0].SubItems[0].Text);

            isbnTextBox.Text = book.Isbn;
            authorTextBox.Text = book.Author;
            titleTextBox.Text = book.Title;
            ratingNumericControl.Value = (decimal)book.Rating;
            datePublishedDateTimePicker.Value = book.DatePublished;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in bookListView.SelectedItems)
            {
                bookList.RemoveBook(item.SubItems[0].Text);
                bookListView.Items.Remove(item);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string title = titleTextBox.Text;
            string isbn = isbnTextBox.Text;
            float rating = (float)ratingNumericControl.Value;
            string genre = "";

            foreach (var x in checkboxes)
            {
                if (x.Checked)
                {
                    genre += x.Text + ",";
                }
            }
            DateTime date = datePublishedDateTimePicker.Value;
            Book book = new Book(isbn, title, author, genre, rating, date);

            bookList.UpdateBook(book);
            string[] row = { isbn, title, author, genre.Split(",")[0], rating.ToString("0.0"), date.ToString() };

            foreach (ListViewItem item in bookListView.Items)
            {
                if (item.SubItems[0].Text.Equals(isbn))
                {
                    bookListView.Items[item.Index] = new ListViewItem(row);
                }
            }
        }

        private void BookListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookListView.SelectedIndices.Count <= 0)
            {
                return;
            }
            Book book = bookList.RetrieveBook(bookListView.SelectedItems[0].SubItems[0].Text);

            isbnTextBox.Text = book.Isbn;
            authorTextBox.Text = book.Author;
            titleTextBox.Text = book.Title;
            ratingNumericControl.Value = (decimal)book.Rating;
            datePublishedDateTimePicker.Value = book.DatePublished;

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
