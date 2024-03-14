namespace CodeChum.Tests
{
    public class BookLibraryTest
    {
        BookLibrary? form;
        ListView? bookListView;
        TextBox? titleTextBox, authorTextBox, genreTextBox;
        DateTimePicker? publishedDateDateTimePicker;
        ComboBox? statusComboBox;
        Button? addButton, updateButton, deleteButton, viewButton;
        TabControl? mainTabControl;

        public BookLibraryTest()
        {
            form = new BookLibrary();
            form.Show();
            bookListView = (ListView)TestUtils.GetControlNamed(form, "bookListView", true);
            titleTextBox = (TextBox)TestUtils.GetControlNamed(form, "titleTextBox", true);
            authorTextBox = (TextBox)TestUtils.GetControlNamed(form, "authorTextBox", true);
            genreTextBox = (TextBox)TestUtils.GetControlNamed(form, "genreTextBox", true);
            publishedDateDateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "publishedDateDateTimePicker", true);
            statusComboBox = (ComboBox)TestUtils.GetControlNamed(form, "statusComboBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            updateButton = (Button)TestUtils.GetControlNamed(form, "updateButton", true);
            deleteButton = (Button)TestUtils.GetControlNamed(form, "deleteButton", true);
            viewButton = (Button)TestUtils.GetControlNamed(form, "viewButton", true);
            mainTabControl = (TabControl)TestUtils.GetControlNamed(form, "mainTabControl", true);
        }

        [Fact]
        // Description: Should have all the controls `bookListView`, `titleTextBox`, `authorTextBox`, `genreTextBox`, `publishedDateDateTimePicker`, `statusComboBox`, `addButton`, `updateButton`, `deleteButton`, `viewButton`, and `mainTabControl`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(bookListView);
            Assert.NotNull(titleTextBox);
            Assert.NotNull(authorTextBox);
            Assert.NotNull(genreTextBox);
            Assert.NotNull(publishedDateDateTimePicker);
            Assert.NotNull(statusComboBox);
            Assert.NotNull(addButton);
            Assert.NotNull(updateButton);
            Assert.NotNull(deleteButton);
            Assert.NotNull(viewButton);
            Assert.NotNull(mainTabControl);
        }

        [Fact]
        // Description: Should add a book to the `bookListView` when the `addButton` is clicked.
        public void ShouldAddBook()
        {
            titleTextBox.Text = "The Hobbit";
            authorTextBox.Text = "J.R.R. Tolkien";
            genreTextBox.Text = "Fantasy";
            publishedDateDateTimePicker.Value = new DateTime(1937, 9, 21);
            statusComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            Assert.Equal(1, bookListView.Items.Count);
            Assert.Equal("The Hobbit", bookListView.Items[0].SubItems[0].Text);
            Assert.Equal("J.R.R. Tolkien", bookListView.Items[0].SubItems[1].Text);
            Assert.Equal("Fantasy", bookListView.Items[0].SubItems[2].Text);
            Assert.Equal("1937", bookListView.Items[0].SubItems[3].Text);
            Assert.Equal("Available", bookListView.Items[0].SubItems[4].Text);
        }

        [Fact]
        // Description: Should update a book in the `bookListView` when the `updateButton` is clicked.
        public void ShouldUpdateBook()
        {
            titleTextBox.Text = "The Hobbit";
            authorTextBox.Text = "J.R.R. Tolkien";
            genreTextBox.Text = "Fantasy";
            publishedDateDateTimePicker.Value = new DateTime(1937, 9, 21);
            statusComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            bookListView.Items[0].Selected = true;
            titleTextBox.Text = "The Lord of the Rings";
            authorTextBox.Text = "J.R.R. Tolkien";
            genreTextBox.Text = "Fantasy";
            publishedDateDateTimePicker.Value = new DateTime(1954, 7, 29);
            statusComboBox.SelectedIndex = 0;
            updateButton.PerformClick();

            Assert.Equal(1, bookListView.Items.Count);
            Assert.Equal("The Lord of the Rings", bookListView.Items[0].SubItems[0].Text);
            Assert.Equal("J.R.R. Tolkien", bookListView.Items[0].SubItems[1].Text);
            Assert.Equal("Fantasy", bookListView.Items[0].SubItems[2].Text);
            Assert.Equal("1954", bookListView.Items[0].SubItems[3].Text);
            Assert.Equal("Available", bookListView.Items[0].SubItems[4].Text);
        }

        [Fact]
        // Description: Should delete a book from the `bookListView` when the `deleteButton` is clicked.
        public void ShouldDeleteBook()
        {
            titleTextBox.Text = "The Hobbit";
            authorTextBox.Text = "J.R.R. Tolkien";
            genreTextBox.Text = "Fantasy";
            publishedDateDateTimePicker.Value = new DateTime(1937, 9, 21);
            statusComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            bookListView.Items[0].Selected = true;
            deleteButton.PerformClick();

            Assert.Equal(0, bookListView.Items.Count);
        }

        [Fact]
        // Description: Should view a book in a new tab when the `viewButton` is clicked.
        public void ShouldViewBookOnNewTab()
        {
            titleTextBox.Text = "The Hobbit";
            authorTextBox.Text = "J.R.R. Tolkien";
            genreTextBox.Text = "Fantasy";
            publishedDateDateTimePicker.Value = new DateTime(1937, 9, 21);
            statusComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            bookListView.Items[0].Selected = true;
            viewButton.PerformClick();

            Assert.Equal(2, mainTabControl.TabPages.Count);
            Assert.Equal("The Hobbit", mainTabControl.TabPages[1].Text);
            Assert.Equal("Title: The Hobbit", mainTabControl.TabPages[1].Controls["lblTitle"].Text);
            Assert.Equal("Author: J.R.R. Tolkien", mainTabControl.TabPages[1].Controls["lblAuthor"].Text);
            Assert.Equal("Genre: Fantasy", mainTabControl.TabPages[1].Controls["lblGenre"].Text);
            Assert.Equal("Publication Date: Tuesday, September 21, 1937", mainTabControl.TabPages[1].Controls["lblPubDate"].Text);
            Assert.Equal("Status: Available", mainTabControl.TabPages[1].Controls["lblStatus"].Text);
        }

        [Fact]
        // Description: Should exit the tab when the `ExitButton` is clicked.
        public void ShouldExitTab()
        {
            titleTextBox.Text = "The Hobbit";
            authorTextBox.Text = "J.R.R. Tolkien";
            genreTextBox.Text = "Fantasy";
            publishedDateDateTimePicker.Value = new DateTime(1937, 9, 21);
            statusComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            bookListView.Items[0].Selected = true;
            viewButton.PerformClick();

            //Navigate to the new tab
            mainTabControl.SelectedIndex = 1;
            Button exitButton = (Button)TestUtils.GetControlNamed(mainTabControl.TabPages[1], "exitButton", true);
            exitButton.PerformClick();

            Assert.Equal(1, mainTabControl.TabPages.Count);
        }

    }
}
