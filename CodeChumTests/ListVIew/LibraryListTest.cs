namespace CodeChum.Tests
{
    public class LibraryListTests
    {
        LibraryList? form;
        ListView? BookListView;
        TextBox? AuthorTextBox, TitleTextBox, IsbnTextBox;
        DateTimePicker? DatePublishedDateTimePicker;
        Button? AddButton, RemoveButton;

        public LibraryListTests()
        {
            form = new LibraryList();
            form.Show();
            BookListView = (ListView)TestUtils.GetControlNamed(form, "BookListView", true);
            AuthorTextBox = (TextBox)TestUtils.GetControlNamed(form, "AuthorTextBox", true);
            TitleTextBox = (TextBox)TestUtils.GetControlNamed(form, "TitleTextBox", true);
            IsbnTextBox = (TextBox)TestUtils.GetControlNamed(form, "IsbnTextBox", true);
            DatePublishedDateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "DatePublishedDateTimePicker", true);
            AddButton = (Button)TestUtils.GetControlNamed(form, "AddButton", true);
            RemoveButton = (Button)TestUtils.GetControlNamed(form, "RemoveButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(BookListView);
            Assert.NotNull(AuthorTextBox);
            Assert.NotNull(TitleTextBox);
            Assert.NotNull(IsbnTextBox);
            Assert.NotNull(DatePublishedDateTimePicker);
            Assert.NotNull(AddButton);
            Assert.NotNull(RemoveButton);
        }

        [Fact]
        public void ShouldBeAbleToAddEntry()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "TestISBN";
            DateTime date = DateTime.Now;
            AuthorTextBox.Text = author;
            TitleTextBox.Text = title;
            IsbnTextBox.Text = isbn;
            DatePublishedDateTimePicker.Value = date;

            List<string> expected = new List<string>() { isbn, title, author, date.ToString() };
            AddButton.PerformClick();
            List<string> output = new List<string>();
            var row = BookListView.Items[0];
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
            AuthorTextBox.Text = author;
            TitleTextBox.Text = title;
            IsbnTextBox.Text = isbn;
            DatePublishedDateTimePicker.Value = date;

            string[] row = { isbn, title, author, date.ToString() };
            BookListView.Items.Add(new ListViewItem(row));
            BookListView.Items[0].Selected = true;
            RemoveButton.PerformClick();

            Assert.Empty(BookListView.Items);
        }
    }
}