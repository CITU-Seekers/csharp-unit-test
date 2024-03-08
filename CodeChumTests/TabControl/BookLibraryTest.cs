namespace CodeChum.Tests
{
    public class BookLibraryTest
    {
        BookLibrary? form;
        ListView? BookList;
        TextBox? txtTitle, txtAuthor, txtGenre;
        DateTimePicker? PubDate;
        ComboBox? cboStatus;
        Button? AddButton, UpdateButton, DeleteButton, ViewButton;
        TabControl? MainTabControl;

        public BookLibraryTest()
        {
            form = new BookLibrary();
            form.Show();
            BookList = (ListView)TestUtils.GetControlNamed(form, "BookList", true);
            txtTitle = (TextBox)TestUtils.GetControlNamed(form, "txtTitle", true);
            txtAuthor = (TextBox)TestUtils.GetControlNamed(form, "txtAuthor", true);
            txtGenre = (TextBox)TestUtils.GetControlNamed(form, "txtGenre", true);
            PubDate = (DateTimePicker)TestUtils.GetControlNamed(form, "PubDate", true);
            cboStatus = (ComboBox)TestUtils.GetControlNamed(form, "cboStatus", true);
            AddButton = (Button)TestUtils.GetControlNamed(form, "AddButton", true);
            UpdateButton = (Button)TestUtils.GetControlNamed(form, "UpdateButton", true);
            DeleteButton = (Button)TestUtils.GetControlNamed(form, "DeleteButton", true);
            ViewButton = (Button)TestUtils.GetControlNamed(form, "ViewButton", true);
            MainTabControl = (TabControl)TestUtils.GetControlNamed(form, "MainTabControl", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(BookList);
            Assert.NotNull(txtTitle);
            Assert.NotNull(txtAuthor);
            Assert.NotNull(txtGenre);
            Assert.NotNull(PubDate);
            Assert.NotNull(cboStatus);
            Assert.NotNull(AddButton);
            Assert.NotNull(UpdateButton);
            Assert.NotNull(DeleteButton);
            Assert.NotNull(ViewButton);
            Assert.NotNull(MainTabControl);
        }

        [Fact]
        public void ShouldAddBook()
        {
            txtTitle.Text = "The Hobbit";
            txtAuthor.Text = "J.R.R. Tolkien";
            txtGenre.Text = "Fantasy";
            PubDate.Value = new DateTime(1937, 9, 21);
            cboStatus.SelectedIndex = 0;
            AddButton.PerformClick();

            Assert.Equal(1, BookList.Items.Count);
            Assert.Equal("The Hobbit", BookList.Items[0].SubItems[0].Text);
            Assert.Equal("J.R.R. Tolkien", BookList.Items[0].SubItems[1].Text);
            Assert.Equal("Fantasy", BookList.Items[0].SubItems[2].Text);
            Assert.Equal("1937", BookList.Items[0].SubItems[3].Text);
            Assert.Equal("Available", BookList.Items[0].SubItems[4].Text);
        }

        [Fact]
        public void ShouldUpdateBook()
        {
            txtTitle.Text = "The Hobbit";
            txtAuthor.Text = "J.R.R. Tolkien";
            txtGenre.Text = "Fantasy";
            PubDate.Value = new DateTime(1937, 9, 21);
            cboStatus.SelectedIndex = 0;
            AddButton.PerformClick();

            BookList.Items[0].Selected = true;
            txtTitle.Text = "The Lord of the Rings";
            txtAuthor.Text = "J.R.R. Tolkien";
            txtGenre.Text = "Fantasy";
            PubDate.Value = new DateTime(1954, 7, 29);
            cboStatus.SelectedIndex = 0;
            UpdateButton.PerformClick();

            Assert.Equal(1, BookList.Items.Count);
            Assert.Equal("The Lord of the Rings", BookList.Items[0].SubItems[0].Text);
            Assert.Equal("J.R.R. Tolkien", BookList.Items[0].SubItems[1].Text);
            Assert.Equal("Fantasy", BookList.Items[0].SubItems[2].Text);
            Assert.Equal("1954", BookList.Items[0].SubItems[3].Text);
            Assert.Equal("Available", BookList.Items[0].SubItems[4].Text);
        }

        [Fact]
        public void ShouldDeleteBook()
        {
            txtTitle.Text = "The Hobbit";
            txtAuthor.Text = "J.R.R. Tolkien";
            txtGenre.Text = "Fantasy";
            PubDate.Value = new DateTime(1937, 9, 21);
            cboStatus.SelectedIndex = 0;
            AddButton.PerformClick();

            BookList.Items[0].Selected = true;
            DeleteButton.PerformClick();

            Assert.Equal(0, BookList.Items.Count);
        }

        [Fact]
        public void ShouldViewBookOnNewTab()
        {
            txtTitle.Text = "The Hobbit";
            txtAuthor.Text = "J.R.R. Tolkien";
            txtGenre.Text = "Fantasy";
            PubDate.Value = new DateTime(1937, 9, 21);
            cboStatus.SelectedIndex = 0;
            AddButton.PerformClick();

            BookList.Items[0].Selected = true;
            ViewButton.PerformClick();

            Assert.Equal(2, MainTabControl.TabPages.Count);
            Assert.Equal("The Hobbit", MainTabControl.TabPages[1].Text);
            Assert.Equal("Title: The Hobbit", MainTabControl.TabPages[1].Controls["lblTitle"].Text);
            Assert.Equal("Author: J.R.R. Tolkien", MainTabControl.TabPages[1].Controls["lblAuthor"].Text);
            Assert.Equal("Genre: Fantasy", MainTabControl.TabPages[1].Controls["lblGenre"].Text);
            Assert.Equal("Publication Date: Tuesday, 21 September 1937", MainTabControl.TabPages[1].Controls["lblPubDate"].Text);
            Assert.Equal("Status: Available", MainTabControl.TabPages[1].Controls["lblStatus"].Text);
        }

        [Fact]
        public void ShouldExitTab()
        {
            txtTitle.Text = "The Hobbit";
            txtAuthor.Text = "J.R.R. Tolkien";
            txtGenre.Text = "Fantasy";
            PubDate.Value = new DateTime(1937, 9, 21);
            cboStatus.SelectedIndex = 0;
            AddButton.PerformClick();

            BookList.Items[0].Selected = true;
            ViewButton.PerformClick();

            //Navigate to the new tab
            MainTabControl.SelectedIndex = 1;
            Button ExitButton = (Button)TestUtils.GetControlNamed(MainTabControl.TabPages[1], "ExitButton", true);
            ExitButton.PerformClick();

            Assert.Equal(1, MainTabControl.TabPages.Count);
        }

    }
}
