namespace CodeChum.Tests
{
    public class BookInterfaceTest
    {
        BookInterface? form;
        Splitter? MainSplitter;
        ComboBox? cboBooks;
        ListBox? BookList;
        TextBox? ChapterBox;
        Panel? panel1;

        public BookInterfaceTest()
        {
            form = new BookInterface();
            form.Show();
            MainSplitter = (Splitter)TestUtils.GetControlNamed(form, "MainSplitter", true);
            cboBooks = (ComboBox)TestUtils.GetControlNamed(form, "cboBooks", true);
            BookList = (ListBox)TestUtils.GetControlNamed(form, "BookList", true);
            ChapterBox = (TextBox)TestUtils.GetControlNamed(form, "ChapterBox", true);
            panel1 = (Panel)TestUtils.GetControlNamed(form, "panel1", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainSplitter);
            Assert.NotNull(cboBooks);
            Assert.NotNull(BookList);
            Assert.NotNull(ChapterBox);
            Assert.NotNull(panel1);
        }

        [Fact]
        public void ShouldHaveProperDockingAndAnchor()
        {
            Assert.Equal(DockStyle.Left, MainSplitter.Dock);
            Assert.Equal(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right, ChapterBox.Anchor);
        }

        [Fact]
        public void ShouldChangeBookListWhenComboBoxChanges()
        {
            cboBooks.SelectedIndex = 2;
            int currentCount = BookList.Items.Count;

            cboBooks.SelectedIndex = 1;
            Assert.NotEqual(currentCount, BookList.Items.Count);
        }

        [Fact]
        public void ShouldChangeChapterBoxWhenBookListChanges()
        {
            cboBooks.SelectedIndex = 0;
            BookList.SelectedIndex = 0;
            var currentText = ChapterBox.Text;

            BookList.SelectedIndex = 1;
            Assert.NotEqual(currentText, ChapterBox.Text);
        }
    }
}
