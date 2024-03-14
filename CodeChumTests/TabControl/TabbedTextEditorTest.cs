namespace CodeChum.Tests
{
    public class TabbedTextEditorTests
    {
        TabbedTextEditor? form;
        TabControl? editorTabControl;
        TabPage? mainTabPage;
        RichTextBox? mainRichTextBox;
        TextBox? fileNameTextBox;
        Button? addButton, deleteButton;

        public TabbedTextEditorTests()
        {
            form = new TabbedTextEditor();
            form.Show();
            editorTabControl = (TabControl)TestUtils.GetControlNamed(form, "editorTabControl", true);
            mainTabPage = (TabPage)TestUtils.GetControlNamed(editorTabControl, "mainTabPage", true);
            mainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(mainTabPage, "mainRichTextBox", true);
            fileNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "fileNameTextBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            deleteButton = (Button)TestUtils.GetControlNamed(form, "deleteButton", true);
        }

        [Fact]
        // Description: Should have all the default controls `editorTabControl`, `mainTabPage`, `mainRichTextBox`, `fileNameTextBox`, `addButton`, and `deleteButton`.
        public void ShouldHaveAllDefaultControls()
        {
            Assert.NotNull(editorTabControl);
            Assert.NotNull(mainTabPage);
            Assert.NotNull(mainRichTextBox);
            Assert.NotNull(fileNameTextBox);
            Assert.NotNull(addButton);
            Assert.NotNull(deleteButton);
        }

        [Fact]
        // Description: Should add a new `TabPage` with correct text and name that is cascaded in the `editorTabControl` on click of `addButton`.
        public void ShouldAddTabPageOnAddButtonClick()
        {
            fileNameTextBox.Text = "Test";
            addButton.PerformClick();

            TabPage newTabPage = (TabPage)TestUtils.GetControlNamed(editorTabControl, "TestTabPage", true);

            Assert.NotNull(newTabPage);
            Assert.Equal("TestTabPage", newTabPage.Name);
        }

        [Fact]
        // Description: Should create a new `RichTextBox` with a correct name on a new tab page on click of `addButton`.
        public void ShouldCreateRichTextBoxOnNewTabPage()
        {
            fileNameTextBox.Text = "Test";
            addButton.PerformClick();

            TabPage newTabPage = (TabPage)TestUtils.GetControlNamed(editorTabControl, "TestTabPage", true);

            Assert.NotNull(newTabPage);

            RichTextBox newRichTextBox = (RichTextBox)TestUtils.GetControlNamed(newTabPage, "TestRichTextBox", true);

            Assert.NotNull(newRichTextBox);
            Assert.Equal("TestRichTextBox", newRichTextBox.Name);
        }

        [Fact]
        // Description: Should delete a tab page and then set the current selected index and tab to the left of the deleted tab page on click of `deleteButton`.
        public void ShouldDeleteTabAndMoveLeftOnDeleteButtonClick()
        {
            fileNameTextBox.Text = "Test0";
            addButton.PerformClick();
            fileNameTextBox.Text = "Test1";
            addButton.PerformClick();

            editorTabControl.SelectedIndex = 2;
            deleteButton.PerformClick();

            Assert.Equal(1, editorTabControl.SelectedIndex);
            Assert.Equal("Test0TabPage", editorTabControl.SelectedTab.Name);
        }
    }
}