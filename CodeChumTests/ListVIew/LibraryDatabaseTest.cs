namespace CodeChum.Tests
{
    public class LibraryDatabaseTests
    {
        LibraryDatabase? form;
        ListView? BookListView;
        TextBox? AuthorTextBox, TitleTextBox, IsbnTextBox;
        GroupBox? GenreGroupBox;
        CheckBox? ActionCheckBox, AdventureCheckBox, FantasyCheckBox, HorrorCheckBox, RomanceCheckBox, SciFiCheckBox, TragedyCheckBox;
        NumericUpDown? RatingNumericControl;
        DateTimePicker? DatePublishedDateTimePicker;
        Button? AddButton, RemoveButton, UpdateButton;

        public LibraryDatabaseTests()
        {
            form = new LibraryDatabase();
            form.Show();
            BookListView = (ListView)TestUtils.GetControlNamed(form, "BookListView", true);
            AuthorTextBox = (TextBox)TestUtils.GetControlNamed(form, "AuthorTextBox", true);
            TitleTextBox = (TextBox)TestUtils.GetControlNamed(form, "TitleTextBox", true);
            IsbnTextBox = (TextBox)TestUtils.GetControlNamed(form, "IsbnTextBox", true);
            GenreGroupBox = (GroupBox)TestUtils.GetControlNamed(form, "GenreGroupBox", true);
            ActionCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "ActionCheckBox", true);
            AdventureCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "AdventureCheckBox", true);
            FantasyCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "FantasyCheckBox", true);
            HorrorCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "HorrorCheckBox", true);
            RomanceCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "RomanceCheckBox", true);
            SciFiCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "SciFiCheckBox", true);
            TragedyCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "TragedyCheckBox", true);
            RatingNumericControl = (NumericUpDown)TestUtils.GetControlNamed(form, "RatingNumericControl", true);
            DatePublishedDateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "DatePublishedDateTimePicker", true);
            AddButton = (Button)TestUtils.GetControlNamed(form, "AddButton", true);
            RemoveButton = (Button)TestUtils.GetControlNamed(form, "RemoveButton", true);
            UpdateButton = (Button)TestUtils.GetControlNamed(form, "UpdateButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(BookListView);
            Assert.NotNull(AuthorTextBox);
            Assert.NotNull(TitleTextBox);
            Assert.NotNull(IsbnTextBox);
            Assert.NotNull(GenreGroupBox);
            Assert.NotNull(ActionCheckBox);
            Assert.NotNull(AdventureCheckBox);
            Assert.NotNull(FantasyCheckBox);
            Assert.NotNull(HorrorCheckBox);
            Assert.NotNull(RomanceCheckBox);
            Assert.NotNull(SciFiCheckBox);
            Assert.NotNull(TragedyCheckBox);
            Assert.NotNull(RatingNumericControl);
            Assert.NotNull(DatePublishedDateTimePicker);
            Assert.NotNull(AddButton);
            Assert.NotNull(RemoveButton);
            Assert.NotNull(UpdateButton);
        }

        [Fact]
        public void ShouldAddEntryOnClickAddButton()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "Test";
            string genre = "Action";
            decimal rating = (decimal)4.5F;
            DateTime createdDateTime = DateTime.Now;
            List<string> expected = new List<string>() { isbn, title, author, genre, rating.ToString(), createdDateTime.ToString() };

            AuthorTextBox.Text = author;
            TitleTextBox.Text = title;
            IsbnTextBox.Text = isbn;
            RatingNumericControl.Value = rating;
            DatePublishedDateTimePicker.Value = createdDateTime;
            ActionCheckBox.Checked = true;
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
        public void ShouldRemoveEntryOnClickRemoveButton()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "Test";
            string genre = "Action";
            decimal rating = (decimal)4.5F;
            DateTime createdDateTime = DateTime.Now;

            AuthorTextBox.Text = author;
            TitleTextBox.Text = title;
            IsbnTextBox.Text = isbn;
            RatingNumericControl.Value = rating;
            DatePublishedDateTimePicker.Value = createdDateTime;
            ActionCheckBox.Checked = true;
            AddButton.PerformClick();
            BookListView.Items[0].Selected = true;
            RemoveButton.PerformClick();

            Assert.Empty(BookListView.Items);
        }

        [Fact]
        public void ShouldShowValuesOnControlsOnEntrySelect()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "Test";
            string genre = "Action";
            decimal rating = (decimal)4.5F;
            DateTime createdDateTime = DateTime.Now;

            AuthorTextBox.Text = author;
            TitleTextBox.Text = title;
            IsbnTextBox.Text = isbn;
            RatingNumericControl.Value = rating;
            DatePublishedDateTimePicker.Value = createdDateTime;
            ActionCheckBox.Checked = true;
            AddButton.PerformClick();
            AuthorTextBox.Text = "";
            TitleTextBox.Text = "";
            IsbnTextBox.Text = "";
            RatingNumericControl.Value = 0;
            DatePublishedDateTimePicker.Value = DateTime.Now;
            ActionCheckBox.Checked = false;
            BookListView.Items[0].Selected = true;

            Assert.Equal(author, AuthorTextBox.Text);
            Assert.Equal(title, TitleTextBox.Text);
            Assert.Equal(isbn, IsbnTextBox.Text);
            Assert.Equal(rating, RatingNumericControl.Value);
            Assert.True(ActionCheckBox.Checked, "Should select genres of the selected book.");
        }

        [Fact]
        public void ShouldUpdateEntryOnClickUpdateButton()
        {
            string author = "TestAuthor";
            string authorNew = "TestNewAuthor";
            string title = "TestTitle";
            string isbn = "Test";
            string genre = "Action";
            decimal rating = (decimal)4.5F;
            DateTime createdDateTime = DateTime.Now;
            List<string> expected = new List<string>() { isbn, title, author, genre, rating.ToString(), createdDateTime.ToString() };

            AuthorTextBox.Text = author;
            TitleTextBox.Text = title;
            IsbnTextBox.Text = isbn;
            RatingNumericControl.Value = rating;
            DatePublishedDateTimePicker.Value = createdDateTime;
            ActionCheckBox.Checked = true;
            AddButton.PerformClick();
            BookListView.Items[0].Selected = true;
            AuthorTextBox.Text = authorNew;
            UpdateButton.PerformClick();
            expected[2] = authorNew;
            List<string> output = new List<string>();
            var row = BookListView.Items[0];
            for (int i = 0; i < row.SubItems.Count; i++)
            {
                output.Add(row.SubItems[i].Text);
            }

            Assert.Equal(expected, output);
        }
    }
}