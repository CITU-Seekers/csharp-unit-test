namespace CodeChum.Tests
{
    public class MenuStripActivityTest
    {
        MenuStripActivity? form;
        MenuStrip? mainMenuStrip;
        ToolStripMenuItem? fileMenuItem, newMenuItem, openMenuItem, saveMenuItem, exitMenuItem;
        Label? statusLabel;

        public MenuStripActivityTest()
        {
            form = new MenuStripActivity();
            form.Show();

            mainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "mainMenuStrip", true);
            statusLabel = (Label)TestUtils.GetControlNamed(form, "statusLabel", true);
        }

        [Fact]
        public void ShouldHaveMainMenuStripAndItsMenuItems()
        {
            Assert.NotNull(mainMenuStrip);


            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            newMenuItem = fileMenuItem.DropDownItems["newMenuItem"] as ToolStripMenuItem;
            openMenuItem = fileMenuItem.DropDownItems["openMenuItem"] as ToolStripMenuItem;
            saveMenuItem = fileMenuItem.DropDownItems["saveMenuItem"] as ToolStripMenuItem;
            exitMenuItem = fileMenuItem.DropDownItems["exitMenuItem"] as ToolStripMenuItem;

            Assert.NotNull(fileMenuItem);
            Assert.NotNull(newMenuItem);
            Assert.NotNull(openMenuItem);
            Assert.NotNull(saveMenuItem);
            Assert.NotNull(exitMenuItem);
        }

        [Fact]
        public void ShouldHaveStatusLabel()
        {
            Assert.NotNull(statusLabel);
        }

        [Fact]
        public void ShouldDisplayCorrectMessageOnNewMenuClick()
        {
            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            newMenuItem = fileMenuItem.DropDownItems["newMenuItem"] as ToolStripMenuItem;

            newMenuItem.PerformClick();

            Assert.Equal("Creating new file...", statusLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectMessageOnOpenMenuClick()
        {
            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            openMenuItem = fileMenuItem.DropDownItems["openMenuItem"] as ToolStripMenuItem;

            openMenuItem.PerformClick();

            Assert.Equal("Opening file...", statusLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectMessageOnSaveMenuClick()
        {
            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            saveMenuItem = fileMenuItem.DropDownItems["saveMenuItem"] as ToolStripMenuItem;

            saveMenuItem.PerformClick();

            Assert.Equal("Saving file...", statusLabel.Text);
        }

        [Fact]
        public void ShouldExitOnExitMenuClick()
        {
            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            exitMenuItem = fileMenuItem.DropDownItems["exitMenuItem"] as ToolStripMenuItem;

            exitMenuItem.PerformClick();

            Assert.False(form.Visible, "The form should close when 'Exit' is clicked.");
        }
    }
}