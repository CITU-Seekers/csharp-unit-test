namespace CodeChum.Tests
{
    public class MenuStripActivityTest
    {
        MenuStripActivity? form;
        MenuStrip? MainMenuStrip;
        ToolStripMenuItem? FileMenuItem, NewMenuItem, OpenMenuItem, SaveMenuItem, ExitMenuItem;
        Label? StatusLabel;

        public MenuStripActivityTest()
        {
            form = new MenuStripActivity();
            form.Show();

            MainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "MainMenuStrip", true);
            StatusLabel = (Label)TestUtils.GetControlNamed(form, "StatusLabel", true);
        }

        [Fact]
        public void ShouldHaveMainMenuStripAndItsMenuItems()
        {
            Assert.NotNull(MainMenuStrip);


            FileMenuItem = MainMenuStrip.Items["FileMenuItem"] as ToolStripMenuItem;
            NewMenuItem = FileMenuItem.DropDownItems["NewMenuItem"] as ToolStripMenuItem;
            OpenMenuItem = FileMenuItem.DropDownItems["OpenMenuItem"] as ToolStripMenuItem;
            SaveMenuItem = FileMenuItem.DropDownItems["SaveMenuItem"] as ToolStripMenuItem;
            ExitMenuItem = FileMenuItem.DropDownItems["ExitMenuItem"] as ToolStripMenuItem;

            Assert.NotNull(FileMenuItem);
            Assert.NotNull(NewMenuItem);
            Assert.NotNull(OpenMenuItem);
            Assert.NotNull(SaveMenuItem);
            Assert.NotNull(ExitMenuItem);
        }

        [Fact]
        public void ShouldHaveStatusLabel()
        {
            Assert.NotNull(StatusLabel);
        }

        [Fact]
        public void ShouldDisplayCorrectMessageOnNewMenuClick()
        {
            FileMenuItem = MainMenuStrip.Items["FileMenuItem"] as ToolStripMenuItem;
            NewMenuItem = FileMenuItem.DropDownItems["NewMenuItem"] as ToolStripMenuItem;

            NewMenuItem.PerformClick();

            Assert.Equal("Creating new file...", StatusLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectMessageOnOpenMenuClick()
        {
            FileMenuItem = MainMenuStrip.Items["FileMenuItem"] as ToolStripMenuItem;
            OpenMenuItem = FileMenuItem.DropDownItems["OpenMenuItem"] as ToolStripMenuItem;

            OpenMenuItem.PerformClick();

            Assert.Equal("Opening file...", StatusLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectMessageOnSaveMenuClick()
        {
            FileMenuItem = MainMenuStrip.Items["FileMenuItem"] as ToolStripMenuItem;
            SaveMenuItem = FileMenuItem.DropDownItems["SaveMenuItem"] as ToolStripMenuItem;

            SaveMenuItem.PerformClick();

            Assert.Equal("Saving file...", StatusLabel.Text);
        }

        [Fact]
        public void ShouldExitOnExitMenuClick()
        {
            FileMenuItem = MainMenuStrip.Items["FileMenuItem"] as ToolStripMenuItem;
            ExitMenuItem = FileMenuItem.DropDownItems["ExitMenuItem"] as ToolStripMenuItem;

            ExitMenuItem.PerformClick();

            Assert.False(form.Visible, "The form should close when 'Exit' is clicked.");
        }
    }
}