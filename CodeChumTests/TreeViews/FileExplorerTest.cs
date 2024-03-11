namespace CodeChum.Tests
{
    public class FileExplorerTest
    {
        FileExplorer? form;
        TreeView? MainTreeView;
        Label? FilePathLabel, MessageLabel;
        TextBox? txtFileName;
        Button? RenameButton, SearchButton;
        MenuStrip? MainMenuStrip;
        ToolStripMenuItem? FileToolStrip, NewMenuItem, OpenMenuItem, ExitMenuItem;

        public FileExplorerTest()
        {
            form = new FileExplorer();
            form.Show();
            MainTreeView = (TreeView)TestUtils.GetControlNamed(form, "MainTreeView", true);
            FilePathLabel = (Label)TestUtils.GetControlNamed(form, "FilePathLabel", true);
            MessageLabel = (Label)TestUtils.GetControlNamed(form, "MessageLabel", true);
            txtFileName = (TextBox)TestUtils.GetControlNamed(form, "txtFileName", true);
            RenameButton = (Button)TestUtils.GetControlNamed(form, "RenameButton", true);
            SearchButton = (Button)TestUtils.GetControlNamed(form, "SearchButton", true);
            MainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "MainMenuStrip", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainTreeView);
            Assert.NotNull(FilePathLabel);
            Assert.NotNull(MessageLabel);
            Assert.NotNull(txtFileName);
            Assert.NotNull(RenameButton);
            Assert.NotNull(SearchButton);
            Assert.NotNull(MainMenuStrip);
        }

        [Fact]
        public void ShouldHaveAllMenuItems()
        {
            FileToolStrip = MainMenuStrip.Items["FileToolStrip"] as ToolStripMenuItem;
            NewMenuItem = FileToolStrip.DropDownItems["NewMenuItem"] as ToolStripMenuItem;
            OpenMenuItem = FileToolStrip.DropDownItems["OpenMenuItem"] as ToolStripMenuItem;
            ExitMenuItem = FileToolStrip.DropDownItems["ExitMenuItem"] as ToolStripMenuItem;

            Assert.NotNull(FileToolStrip);
            Assert.NotNull(NewMenuItem);
            Assert.NotNull(OpenMenuItem);
            Assert.NotNull(ExitMenuItem);
        }

        [Fact]
        public void ShouldMakeNewNode()
        {
            FileToolStrip = MainMenuStrip.Items["FileToolStrip"] as ToolStripMenuItem;
            NewMenuItem = FileToolStrip.DropDownItems["NewMenuItem"] as ToolStripMenuItem;

            NewMenuItem.PerformClick();

            Assert.Equal("C:\\New File", FilePathLabel.Text);
        }

        [Fact]
        public void ShouldOpenNode()
        {
            FileToolStrip = MainMenuStrip.Items["FileToolStrip"] as ToolStripMenuItem;
            OpenMenuItem = FileToolStrip.DropDownItems["OpenMenuItem"] as ToolStripMenuItem;

            MainTreeView.SelectedNode = MainTreeView.Nodes[0];
            OpenMenuItem.PerformClick();

            Assert.Equal("Opening C:", MessageLabel.Text);
        }

        [Fact]
        public void ShouldExit()
        {
            FileToolStrip = MainMenuStrip.Items["FileToolStrip"] as ToolStripMenuItem;
            ExitMenuItem = FileToolStrip.DropDownItems["ExitMenuItem"] as ToolStripMenuItem;

            ExitMenuItem.PerformClick();

            Assert.False(form.Visible);
        }

        [Fact]
        public void ShouldRenameNode()
        {
            txtFileName.Text = "Test";
            RenameButton.PerformClick();

            Assert.Equal("Test", MainTreeView.SelectedNode.Text);
        }

        [Fact]
        public void ShouldSearchNode()
        {
            FileToolStrip = MainMenuStrip.Items["FileToolStrip"] as ToolStripMenuItem;
            NewMenuItem = FileToolStrip.DropDownItems["NewMenuItem"] as ToolStripMenuItem;

            NewMenuItem.PerformClick();

            txtFileName.Text = "New File";
            SearchButton.PerformClick();

            Assert.Equal("C:\\New File", FilePathLabel.Text);
        }
    }
}
