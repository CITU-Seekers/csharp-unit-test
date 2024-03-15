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
        // Description: Should have a MenuStrip named `mainMenuStrip` and Label named `statusLabel`.
        public void ShouldHaveMainMenuStripAndLabel()
        {
            Assert.NotNull(mainMenuStrip);
            Assert.NotNull(statusLabel);
        }

        [Fact]
        // Description: Should have a menu item of `mainMenuStrip` named `fileMenuItem` along with its sub items `newMenuItem`, `openMenuItem`, `saveMenuItem`, and `exitMenuItem`.
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
        // Description: Should have a menu item of `mainMenuStrip` named `formatMenuItem` along with its sub items `fontColorMenuItem`, `redMenuItem`, `greenMenuItem`, and `blueMenuItem`.
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

        [Fact]
        // Description: Should change fore color of `statusLabel` to red when `redMenuItem` is clicked.
        public void ShouldChangeColorOnRedMenuClick()
        {
            formatMenuItem = mainMenuStrip.Items["formatMenuItem"] as ToolStripMenuItem;
            fontColorMenuItem = formatMenuItem.DropDownItems["fontColorMenuItem"] as ToolStripMenuItem;
            redMenuItem = fontColorMenuItem.DropDownItems["redMenuItem"] as ToolStripMenuItem;

            redMenuItem.PerformClick();

            Assert.Equal(Color.Red, statusLabel.ForeColor);
        }

        [Fact]
        // Description: Should change fore color of `statusLabel` to green when `greenMenuItem` is clicked.
        public void ShouldChangeColorOnGreenMenuClick()
        {
            formatMenuItem = mainMenuStrip.Items["formatMenuItem"] as ToolStripMenuItem;
            fontColorMenuItem = formatMenuItem.DropDownItems["fontColorMenuItem"] as ToolStripMenuItem;
            greenMenuItem = fontColorMenuItem.DropDownItems["greenMenuItem"] as ToolStripMenuItem;

            greenMenuItem.PerformClick();

            Assert.Equal(Color.Green, statusLabel.ForeColor);
        }

        [Fact]
        // Description: Should change fore color of `statusLabel` to blue when `blueMenuItem` is clicked.
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