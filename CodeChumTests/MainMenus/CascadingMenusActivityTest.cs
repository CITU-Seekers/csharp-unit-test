using System.Drawing;

namespace CodeChum.Tests
{
    public class CascadeMenuActivityTests
    {
        CascadeMenuActivity? form;
        MenuStrip? mainMenuStrip;
        ToolStripMenuItem? fileMenuItem, newMenuItem, openMenuItem, saveMenuItem,
            exitMenuItem, formatMenuItem, fontColorMenuItem, redMenuItem, greenMenuItem,
            blueMenuItem;
        Label? statusLabel;

        public CascadeMenuActivityTests()
        {
            form = new CascadeMenuActivity();
            form.Show();

            mainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "mainMenuStrip", true);
            statusLabel = (Label)TestUtils.GetControlNamed(form, "statusLabel", true);
        }

        [Fact]
        public void ShouldHaveMainMenuStripAndLabel()
        {
            Assert.NotNull(mainMenuStrip);
            Assert.NotNull(statusLabel);
        }

        [Fact]
        public void ShouldHaveFileMenuItemAndItsMenuItems()
        {
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
        public void ShouldHaveFormatMenuItemAndItsMenuItems()
        {
            formatMenuItem = mainMenuStrip.Items["formatMenuItem"] as ToolStripMenuItem;
            fontColorMenuItem = formatMenuItem.DropDownItems["fontColorMenuItem"] as ToolStripMenuItem;
            redMenuItem = fontColorMenuItem.DropDownItems["redMenuItem"] as ToolStripMenuItem;
            greenMenuItem = fontColorMenuItem.DropDownItems["greenMenuItem"] as ToolStripMenuItem;
            blueMenuItem = fontColorMenuItem.DropDownItems["blueMenuItem"] as ToolStripMenuItem;

            Assert.NotNull(formatMenuItem);
            Assert.NotNull(fontColorMenuItem);
            Assert.NotNull(redMenuItem);
            Assert.NotNull(greenMenuItem);
            Assert.NotNull(blueMenuItem);
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

        [Fact]
        public void ShouldChangeColorOnRedMenuClick()
        {
            formatMenuItem = mainMenuStrip.Items["formatMenuItem"] as ToolStripMenuItem;
            fontColorMenuItem = formatMenuItem.DropDownItems["fontColorMenuItem"] as ToolStripMenuItem;
            redMenuItem = fontColorMenuItem.DropDownItems["redMenuItem"] as ToolStripMenuItem;

            redMenuItem.PerformClick();

            Assert.Equal(Color.Red, statusLabel.ForeColor);
        }

        [Fact]
        public void ShouldChangeColorOnGreenMenuClick()
        {
            formatMenuItem = mainMenuStrip.Items["formatMenuItem"] as ToolStripMenuItem;
            fontColorMenuItem = formatMenuItem.DropDownItems["fontColorMenuItem"] as ToolStripMenuItem;
            greenMenuItem = fontColorMenuItem.DropDownItems["greenMenuItem"] as ToolStripMenuItem;

            greenMenuItem.PerformClick();

            Assert.Equal(Color.Green, statusLabel.ForeColor);
        }

        [Fact]
        public void ShouldChangeColorOnBlueMenuClick()
        {
            formatMenuItem = mainMenuStrip.Items["formatMenuItem"] as ToolStripMenuItem;
            fontColorMenuItem = formatMenuItem.DropDownItems["fontColorMenuItem"] as ToolStripMenuItem;
            blueMenuItem = fontColorMenuItem.DropDownItems["blueMenuItem"] as ToolStripMenuItem;

            blueMenuItem.PerformClick();

            Assert.Equal(Color.Blue, statusLabel.ForeColor);
        }
    }
}