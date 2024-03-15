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
        // Description: Should have a MenuStrip named `mainMenuStrip` along with its items `fileMenuItem`, `newMenuItem`, `openMenuItem`, `saveMenuItem`, and `exitMenuItem`.
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
        // Description: Should have a Label named `statusLabel`.
        public void ShouldHaveStatusLabel()
        {
            Assert.NotNull(statusLabel);
        }

        [Fact]
        // Description: Should display "Creating new file..." in `statusLabel` when `newMenuItem` is clicked.
        public void ShouldDisplayCorrectMessageOnNewMenuClick()
        {
            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            newMenuItem = fileMenuItem.DropDownItems["newMenuItem"] as ToolStripMenuItem;

            newMenuItem.PerformClick();

            Assert.Equal("Creating new file...", statusLabel.Text);
        }

        [Fact]
        // Description: Should display "Opening file..." in `statusLabel` when `openMenuItem` is clicked.
        public void ShouldDisplayCorrectMessageOnOpenMenuClick()
        {
            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            openMenuItem = fileMenuItem.DropDownItems["openMenuItem"] as ToolStripMenuItem;

            openMenuItem.PerformClick();

            Assert.Equal("Opening file...", statusLabel.Text);
        }

        [Fact]
        // Description: Should display "Saving file..." in `statusLabel` when `saveMenuItem` is clicked.
        public void ShouldDisplayCorrectMessageOnSaveMenuClick()
        {
            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            saveMenuItem = fileMenuItem.DropDownItems["saveMenuItem"] as ToolStripMenuItem;

            saveMenuItem.PerformClick();

            Assert.Equal("Saving file...", statusLabel.Text);
        }

        [Fact]
        // Description: Should close the form when `exitMenuItem` is clicked.
        public void ShouldExitOnExitMenuClick()
        {
            fileMenuItem = mainMenuStrip.Items["fileMenuItem"] as ToolStripMenuItem;
            exitMenuItem = fileMenuItem.DropDownItems["exitMenuItem"] as ToolStripMenuItem;

            exitMenuItem.PerformClick();

            Assert.False(form.Visible, "The form should close when 'Exit' is clicked.");
        }
    }
}