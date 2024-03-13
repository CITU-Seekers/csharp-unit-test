namespace CodeChum.Tests
{
    public class BookInterfaceTest
    {
        BookInterface? form;
        Splitter? mainSplitter;
        ComboBox? booksComboBox;
        ListBox? bookListBox;
        TextBox? chapterTextBox;
        Panel? panel;

        public BookInterfaceTest()
        {
            form = new BookInterface();
            form.Show();
            mainSplitter = (Splitter)TestUtils.GetControlNamed(form, "mainSplitter", true);
            booksComboBox = (ComboBox)TestUtils.GetControlNamed(form, "booksComboBox", true);
            bookListBox = (ListBox)TestUtils.GetControlNamed(form, "bookListBox", true);
            chapterTextBox = (TextBox)TestUtils.GetControlNamed(form, "chapterTextBox", true);
            panel = (Panel)TestUtils.GetControlNamed(form, "panel", true);
        }

        [Fact]
        // Description: Should have all the controls `mainSplitter`, `comboBoxBooks`, `bookListBox`, `chapterTextBox`, and `panel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainSplitter);
            Assert.NotNull(booksComboBox);
            Assert.NotNull(bookListBox);
            Assert.NotNull(chapterTextBox);
            Assert.NotNull(panel);
        }

        [Fact]
        // Description: Should have dock style `DockStyle.Left` for `mainSplitter` and anchor style `AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right` for `chapterTextBox`.
        public void ShouldHaveProperDockingAndAnchor()
        {
            Assert.Equal(DockStyle.Left, mainSplitter.Dock);
            Assert.Equal(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right, chapterTextBox.Anchor);
        }

        [Fact]
        // Description: Should have unequal number of items in `comboBoxBooks` and `bookListBox` when selected index of `comboBoxBooks` is changed.
        public void ShouldChangeBookListWhenComboBoxChanges()
        {
            booksComboBox.SelectedIndex = 2;
            int currentCount = bookListBox.Items.Count;

            booksComboBox.SelectedIndex = 1;
            Assert.NotEqual(currentCount, bookListBox.Items.Count);
        }

        [Fact]
        // Description: Should have unequal text in `chapterTextBox` when selected index of `bookListBox` is changed.
        public void ShouldChangeChapterBoxWhenBookListChanges()
        {
            booksComboBox.SelectedIndex = 0;
            bookListBox.SelectedIndex = 0;
            var currentText = chapterTextBox.Text;

            bookListBox.SelectedIndex = 1;
            Assert.NotEqual(currentText, chapterTextBox.Text);
        }
    }
}
