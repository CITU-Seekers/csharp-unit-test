using System.Drawing;

namespace CodeChum.Tests
{
    public class CascadeMenuActivityTests
    {
        CascadeMenuActivity? form;
        MenuStrip? MainMenuStrip;
        ToolStripMenuItem? FileMenuItem, NewMenuItem, OpenMenuItem, SaveMenuItem,
            ExitMenuItem, FormatMenuItem, FontColorMenuItem, RedMenuItem, GreenMenuItem,
            BlueMenuItem;
        Label? StatusLabel;

        public CascadeMenuActivityTests()
        {
            form = new CascadeMenuActivity();
            form.Show();

            MainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "MainMenuStrip", true);
            StatusLabel = (Label)TestUtils.GetControlNamed(form, "StatusLabel", true);
        }

        [Fact]
        public void ShouldHaveMainMenuStripAndLabel()
        {
            Assert.NotNull(MainMenuStrip);
            Assert.NotNull(StatusLabel);
        }

        [Fact]
        public void ShouldHaveFileMenuItemAndItsMenuItems()
        {
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
        public void ShouldHaveFormatMenuItemAndItsMenuItems()
        {
            FormatMenuItem = MainMenuStrip.Items["FormatMenuItem"] as ToolStripMenuItem;
            FontColorMenuItem = FormatMenuItem.DropDownItems["FontColorMenuItem"] as ToolStripMenuItem;
            RedMenuItem = FontColorMenuItem.DropDownItems["RedMenuItem"] as ToolStripMenuItem;
            GreenMenuItem = FontColorMenuItem.DropDownItems["GreenMenuItem"] as ToolStripMenuItem;
            BlueMenuItem = FontColorMenuItem.DropDownItems["BlueMenuItem"] as ToolStripMenuItem;

            Assert.NotNull(FormatMenuItem);
            Assert.NotNull(FontColorMenuItem);
            Assert.NotNull(RedMenuItem);
            Assert.NotNull(GreenMenuItem);
            Assert.NotNull(BlueMenuItem);
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

        [Fact]
        public void ShouldChangeColorOnRedMenuClick()
        {
            FormatMenuItem = MainMenuStrip.Items["FormatMenuItem"] as ToolStripMenuItem;
            FontColorMenuItem = FormatMenuItem.DropDownItems["FontColorMenuItem"] as ToolStripMenuItem;
            RedMenuItem = FontColorMenuItem.DropDownItems["RedMenuItem"] as ToolStripMenuItem;

            RedMenuItem.PerformClick();

            Assert.Equal(Color.Red, StatusLabel.ForeColor);
        }

        [Fact]
        public void ShouldChangeColorOnGreenMenuClick()
        {
            FormatMenuItem = MainMenuStrip.Items["FormatMenuItem"] as ToolStripMenuItem;
            FontColorMenuItem = FormatMenuItem.DropDownItems["FontColorMenuItem"] as ToolStripMenuItem;
            GreenMenuItem = FontColorMenuItem.DropDownItems["GreenMenuItem"] as ToolStripMenuItem;

            GreenMenuItem.PerformClick();

            Assert.Equal(Color.Green, StatusLabel.ForeColor);
        }

        [Fact]
        public void ShouldChangeColorOnBlueMenuClick()
        {
            FormatMenuItem = MainMenuStrip.Items["FormatMenuItem"] as ToolStripMenuItem;
            FontColorMenuItem = FormatMenuItem.DropDownItems["FontColorMenuItem"] as ToolStripMenuItem;
            BlueMenuItem = FontColorMenuItem.DropDownItems["BlueMenuItem"] as ToolStripMenuItem;

            BlueMenuItem.PerformClick();

            Assert.Equal(Color.Blue, StatusLabel.ForeColor);
        }
    }
}