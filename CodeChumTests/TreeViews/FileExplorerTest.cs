namespace CodeChum.Tests
{
    public class FileExplorerTest
    {
        FileExplorer? form;
        TreeView? mainTreeView;
        Label? filePathLabel, messageLabel;
        TextBox? fileNameTextBox;
        Button? renameButton, searchButton;
        MenuStrip? mainMenuStrip;
        ToolStripMenuItem? fileToolStripMenuItem, newToolStripMenuItem, openToolStripMenuItem, exitToolStripMenuItem;

        public FileExplorerTest()
        {
            form = new FileExplorer();
            form.Show();
            mainTreeView = (TreeView)TestUtils.GetControlNamed(form, "mainTreeView", true);
            filePathLabel = (Label)TestUtils.GetControlNamed(form, "filePathLabel", true);
            messageLabel = (Label)TestUtils.GetControlNamed(form, "messageLabel", true);
            fileNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "fileNameTextBox", true);
            renameButton = (Button)TestUtils.GetControlNamed(form, "renameButton", true);
            searchButton = (Button)TestUtils.GetControlNamed(form, "searchButton", true);
            mainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "mainMenuStrip", true);
        }

        [Fact]
        // Description: Should have all the controls `mainTreeView`, `filePathLabel`, `messageLabel`, `fileNameTextBox`, `renameButton`, `searchButton`, and `mainMenuStrip`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainTreeView);
            Assert.NotNull(filePathLabel);
            Assert.NotNull(messageLabel);
            Assert.NotNull(fileNameTextBox);
            Assert.NotNull(renameButton);
            Assert.NotNull(searchButton);
            Assert.NotNull(mainMenuStrip);
        }

        [Fact]
        // Description: Should have all the menu items `fileToolStripMenuItem`, `newToolStripMenuItem`, `openToolStripMenuItem`, and `exitToolStripMenuItem`.
        public void ShouldHaveAllMenuItems()
        {
            fileToolStripMenuItem = mainMenuStrip.Items["fileToolStripMenuItem"] as ToolStripMenuItem;
            newToolStripMenuItem = fileToolStripMenuItem.DropDownItems["newToolStripMenuItem"] as ToolStripMenuItem;
            openToolStripMenuItem = fileToolStripMenuItem.DropDownItems["openToolStripMenuItem"] as ToolStripMenuItem;
            exitToolStripMenuItem = fileToolStripMenuItem.DropDownItems["exitToolStripMenuItem"] as ToolStripMenuItem;

            Assert.NotNull(fileToolStripMenuItem);
            Assert.NotNull(newToolStripMenuItem);
            Assert.NotNull(openToolStripMenuItem);
            Assert.NotNull(exitToolStripMenuItem);
        }

        [Fact]
        // Description: Should make a new node when the `newToolStripMenuItem` is clicked.
        public void ShouldMakeNewNode()
        {
            fileToolStripMenuItem = mainMenuStrip.Items["fileToolStripMenuItem"] as ToolStripMenuItem;
            newToolStripMenuItem = fileToolStripMenuItem.DropDownItems["newToolStripMenuItem"] as ToolStripMenuItem;

            newToolStripMenuItem.PerformClick();

            Assert.Equal("C:\\New File", filePathLabel.Text);
        }

        [Fact]
        // Description: Should open node when the `openToolStripMenuItem` is clicked.
        public void ShouldOpenNode()
        {
            fileToolStripMenuItem = mainMenuStrip.Items["fileToolStripMenuItem"] as ToolStripMenuItem;
            openToolStripMenuItem = fileToolStripMenuItem.DropDownItems["openToolStripMenuItem"] as ToolStripMenuItem;

            mainTreeView.SelectedNode = mainTreeView.Nodes[0];
            openToolStripMenuItem.PerformClick();

            Assert.Equal("Opening C:", messageLabel.Text);
        }

        [Fact]
        // Description: Should exit the application when the `exitToolStripMenuItem` is clicked.
        public void ShouldExit()
        {
            fileToolStripMenuItem = mainMenuStrip.Items["fileToolStripMenuItem"] as ToolStripMenuItem;
            exitToolStripMenuItem = fileToolStripMenuItem.DropDownItems["exitToolStripMenuItem"] as ToolStripMenuItem;

            exitToolStripMenuItem.PerformClick();

            Assert.False(form.Visible);
        }

        [Fact]
        // Description: Should rename node when the `renameButton` is clicked.
        public void ShouldRenameNode()
        {
            fileNameTextBox.Text = "Test";
            renameButton.PerformClick();

            Assert.Equal("Test", mainTreeView.SelectedNode.Text);
        }

        [Fact]
        // Description: Should search node when the `searchButton` is clicked.
        public void ShouldSearchNode()
        {
            fileToolStripMenuItem = mainMenuStrip.Items["fileToolStripMenuItem"] as ToolStripMenuItem;
            newToolStripMenuItem = fileToolStripMenuItem.DropDownItems["newToolStripMenuItem"] as ToolStripMenuItem;

            newToolStripMenuItem.PerformClick();

            fileNameTextBox.Text = "New File";
            searchButton.PerformClick();

            Assert.Equal("C:\\New File", filePathLabel.Text);
        }
    }
}
