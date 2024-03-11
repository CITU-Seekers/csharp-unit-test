namespace CodeChum.Tests
{
    public class TabbedTextEditorTests
    {
        TabbedTextEditor? form;
        TabControl? EditorTabControl;
        TabPage? MainTabPage;
        RichTextBox? MainRichTextBox;
        TextBox? FileNameTextBox;
        Button? AddButton, DeleteButton;

        public TabbedTextEditorTests()
        {
            form = new TabbedTextEditor();
            form.Show();
            EditorTabControl = (TabControl)TestUtils.GetControlNamed(form, "EditorTabControl", true);
            MainTabPage = (TabPage)TestUtils.GetControlNamed(EditorTabControl, "MainTabPage", true);
            MainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(MainTabPage, "MainRichTextBox", true);
            FileNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "FileNameTextBox", true);
            AddButton = (Button)TestUtils.GetControlNamed(form, "AddButton", true);
            DeleteButton = (Button)TestUtils.GetControlNamed(form, "DeleteButton", true);
        }

        [Fact]
        public void ShouldHaveAllDefaultControls()
        {
            Assert.NotNull(EditorTabControl);
            Assert.NotNull(MainTabPage);
            Assert.NotNull(MainRichTextBox);
            Assert.NotNull(FileNameTextBox);
            Assert.NotNull(AddButton);
            Assert.NotNull(DeleteButton);
        }

        [Fact]
        public void ShouldAddTabPageOnAddButtonClick()
        {
            FileNameTextBox.Text = "Test";
            AddButton.PerformClick();

            TabPage newTabPage = (TabPage)TestUtils.GetControlNamed(EditorTabControl, "TestTabPage", true);

            Assert.NotNull(newTabPage);
            Assert.Equal("TestTabPage", newTabPage.Name);
        }

        [Fact]
        public void ShouldCreateRichTextBoxOnNewTabPage()
        {
            FileNameTextBox.Text = "Test";
            AddButton.PerformClick();

            TabPage newTabPage = (TabPage)TestUtils.GetControlNamed(EditorTabControl, "TestTabPage", true);

            Assert.NotNull(newTabPage);

            RichTextBox newRichTextBox = (RichTextBox)TestUtils.GetControlNamed(newTabPage, "TestRichTextBox", true);

            Assert.NotNull(newRichTextBox);
            Assert.Equal("TestRichTextBox", newRichTextBox.Name);
        }

        [Fact]
        public void ShouldDeleteTabAndMoveLeftOnDeleteButtonClick()
        {
            FileNameTextBox.Text = "Test0";
            AddButton.PerformClick();
            FileNameTextBox.Text = "Test1";
            AddButton.PerformClick();

            EditorTabControl.SelectedIndex = 2;
            DeleteButton.PerformClick();

            Assert.Equal(1, EditorTabControl.SelectedIndex);
            Assert.Equal("Test0TabPage", EditorTabControl.SelectedTab.Name);
        }
    }
}