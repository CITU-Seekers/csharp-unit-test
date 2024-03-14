namespace CodeChum.Tests
{
    public class LibraryListTests
    {
        LibraryList? form;
        ListView? bookListView;
        TextBox? authorTextBox, titleTextBox, isbnTextBox;
        DateTimePicker? datePublishedDateTimePicker;
        Button? addButton, removeButton;

        public LibraryListTests()
        {
            form = new LibraryList();
            form.Show();
            bookListView = (ListView)TestUtils.GetControlNamed(form, "bookListView", true);
            authorTextBox = (TextBox)TestUtils.GetControlNamed(form, "authorTextBox", true);
            titleTextBox = (TextBox)TestUtils.GetControlNamed(form, "titleTextBox", true);
            isbnTextBox = (TextBox)TestUtils.GetControlNamed(form, "isbnTextBox", true);
            datePublishedDateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "datePublishedDateTimePicker", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            removeButton = (Button)TestUtils.GetControlNamed(form, "removeButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(bookListView);
            Assert.NotNull(authorTextBox);
            Assert.NotNull(titleTextBox);
            Assert.NotNull(isbnTextBox);
            Assert.NotNull(datePublishedDateTimePicker);
            Assert.NotNull(addButton);
            Assert.NotNull(removeButton);
        }

        [Fact]
        public void ShouldBeAbleToAddEntry()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "TestISBN";
            DateTime date = DateTime.Now;
            authorTextBox.Text = author;
            titleTextBox.Text = title;
            isbnTextBox.Text = isbn;
            datePublishedDateTimePicker.Value = date;

            List<string> expected = new List<string>() { isbn, title, author, date.ToString() };
            addButton.PerformClick();
            List<string> output = new List<string>();
            var row = bookListView.Items[0];
            for (int i = 0; i < row.SubItems.Count; i++)
            {
                output.Add(row.SubItems[i].Text);
            }

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ShouldBeAbleToRemoveEntry()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "TestISBN";
            DateTime date = DateTime.Now;
            authorTextBox.Text = author;
            titleTextBox.Text = title;
            isbnTextBox.Text = isbn;
            datePublishedDateTimePicker.Value = date;

            string[] row = { isbn, title, author, date.ToString() };
            bookListView.Items.Add(new ListViewItem(row));
            bookListView.Items[0].Selected = true;
            removeButton.PerformClick();

            Assert.Empty(bookListView.Items);
        }
    }
}