namespace CodeChum.Tests
{
    public class LibraryDatabaseTests
    {
        LibraryDatabase? form;
        ListView? bookListView;
        TextBox? authorTextBox, titleTextBox, isbnTextBox;
        GroupBox? genreGroupBox;
        CheckBox? actionCheckBox, adventureCheckBox, fantasyCheckBox, horrorCheckBox, romanceCheckBox, sciFiCheckBox, tragedyCheckBox;
        NumericUpDown? ratingNumericControl;
        DateTimePicker? datePublishedDateTimePicker;
        Button? addButton, removeButton, updateButton;

        public LibraryDatabaseTests()
        {
            form = new LibraryDatabase();
            form.Show();
            bookListView = (ListView)TestUtils.GetControlNamed(form, "bookListView", true);
            authorTextBox = (TextBox)TestUtils.GetControlNamed(form, "authorTextBox", true);
            titleTextBox = (TextBox)TestUtils.GetControlNamed(form, "titleTextBox", true);
            isbnTextBox = (TextBox)TestUtils.GetControlNamed(form, "isbnTextBox", true);
            genreGroupBox = (GroupBox)TestUtils.GetControlNamed(form, "genreGroupBox", true);
            actionCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "actionCheckBox", true);
            adventureCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "adventureCheckBox", true);
            fantasyCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "fantasyCheckBox", true);
            horrorCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "horrorCheckBox", true);
            romanceCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "romanceCheckBox", true);
            sciFiCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "sciFiCheckBox", true);
            tragedyCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "tragedyCheckBox", true);
            ratingNumericControl = (NumericUpDown)TestUtils.GetControlNamed(form, "ratingNumericControl", true);
            datePublishedDateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "datePublishedDateTimePicker", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            removeButton = (Button)TestUtils.GetControlNamed(form, "removeButton", true);
            updateButton = (Button)TestUtils.GetControlNamed(form, "updateButton", true);
        }

        [Fact]
        // Description: Should have all the controls `bookListView`, `authorTextBox`, `titleTextBox`, `isbnTextBox`, `genreGroupBox`, `actionCheckBox`, `adventureCheckBox`, `fantasyCheckBox`, `horrorCheckBox`, `romanceCheckBox`, `sciFiCheckBox`, `tragedyCheckBox`, `ratingNumericControl`, `datePublishedDateTimePicker`, `addButton`, `removeButton`, and `updateButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(bookListView);
            Assert.NotNull(authorTextBox);
            Assert.NotNull(titleTextBox);
            Assert.NotNull(isbnTextBox);
            Assert.NotNull(genreGroupBox);
            Assert.NotNull(actionCheckBox);
            Assert.NotNull(adventureCheckBox);
            Assert.NotNull(fantasyCheckBox);
            Assert.NotNull(horrorCheckBox);
            Assert.NotNull(romanceCheckBox);
            Assert.NotNull(sciFiCheckBox);
            Assert.NotNull(tragedyCheckBox);
            Assert.NotNull(ratingNumericControl);
            Assert.NotNull(datePublishedDateTimePicker);
            Assert.NotNull(addButton);
            Assert.NotNull(removeButton);
            Assert.NotNull(updateButton);
        }

        [Fact]
        // Description: Should add entry to the `bookListView` on click of `addButton`.
        public void ShouldAddEntryOnClickAddButton()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "Test";
            string genre = "Action";
            decimal rating = (decimal)4.5F;
            DateTime createdDateTime = DateTime.Now;
            List<string> expected = new List<string>() { isbn, title, author, genre, rating.ToString(), createdDateTime.ToString() };

            authorTextBox.Text = author;
            titleTextBox.Text = title;
            isbnTextBox.Text = isbn;
            ratingNumericControl.Value = rating;
            datePublishedDateTimePicker.Value = createdDateTime;
            actionCheckBox.Checked = true;
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
        // Description: Should remove entry from the `bookListView` on click of `removeButton`.
        public void ShouldRemoveEntryOnClickRemoveButton()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "Test";
            string genre = "Action";
            decimal rating = (decimal)4.5F;
            DateTime createdDateTime = DateTime.Now;

            authorTextBox.Text = author;
            titleTextBox.Text = title;
            isbnTextBox.Text = isbn;
            ratingNumericControl.Value = rating;
            datePublishedDateTimePicker.Value = createdDateTime;
            actionCheckBox.Checked = true;
            addButton.PerformClick();
            bookListView.Items[0].Selected = true;
            removeButton.PerformClick();

            Assert.Empty(bookListView.Items);
        }

        [Fact]
        // Description: Should populate the appropriate controls with the values from the selected entry from the `bookListView`.
        public void ShouldShowValuesOnControlsOnEntrySelect()
        {
            string author = "TestAuthor";
            string title = "TestTitle";
            string isbn = "Test";
            string genre = "Action";
            decimal rating = (decimal)4.5F;
            DateTime createdDateTime = DateTime.Now;

            authorTextBox.Text = author;
            titleTextBox.Text = title;
            isbnTextBox.Text = isbn;
            ratingNumericControl.Value = rating;
            datePublishedDateTimePicker.Value = createdDateTime;
            actionCheckBox.Checked = true;

            addButton.PerformClick();

            authorTextBox.Text = "";
            titleTextBox.Text = "";
            isbnTextBox.Text = "";
            ratingNumericControl.Value = 0;
            datePublishedDateTimePicker.Value = DateTime.Now;
            actionCheckBox.Checked = false;
            bookListView.Items[0].Selected = true;

            Assert.Equal(author, authorTextBox.Text);
            Assert.Equal(title, titleTextBox.Text);
            Assert.Equal(isbn, isbnTextBox.Text);
            Assert.Equal(rating, ratingNumericControl.Value);
            Assert.True(actionCheckBox.Checked, "Should select genres of the selected book.");
        }

        [Fact]
        // Description: Should update entry in the `bookListView` on click of `updateButton`.
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

            authorTextBox.Text = author;
            titleTextBox.Text = title;
            isbnTextBox.Text = isbn;
            ratingNumericControl.Value = rating;
            datePublishedDateTimePicker.Value = createdDateTime;
            actionCheckBox.Checked = true;
            addButton.PerformClick();
            bookListView.Items[0].Selected = true;
            authorTextBox.Text = authorNew;
            updateButton.PerformClick();
            expected[2] = authorNew;
            List<string> output = new List<string>();
            var row = bookListView.Items[0];
            for (int i = 0; i < row.SubItems.Count; i++)
            {
                output.Add(row.SubItems[i].Text);
            }

            Assert.Equal(expected, output);
        }
    }
}