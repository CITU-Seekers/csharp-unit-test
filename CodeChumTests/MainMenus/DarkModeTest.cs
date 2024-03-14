namespace CodeChum.Tests
{
    public class DarkModeTest
    {
        DarkMode? form;
        MenuStrip? mainMenuStrip;
        RichTextBox? richTextBox;
        ToolStripMenuItem? viewToolStripMenu;
        ToolStripMenuItem? darkModeToolStripMenuItem;

        public DarkModeTest()
        {
            form = new DarkMode();
            form.Show();
            mainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "mainMenuStrip", true);
            richTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "richTextBox", true);
        }

        [Fact]
        // Description: Should have all controls `mainMenuStrip` and `richTextBox`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainMenuStrip);
            Assert.NotNull(richTextBox);
        }

        [Fact]
        // Description: Should have `viewToolStripMenu` and its menu item `darkModeToolStripMenuItem`.
        public void ShouldHaveViewToolStripMenuAndItsMenuItem()
        {
            viewToolStripMenu = mainMenuStrip.Items["viewToolStripMenuItem"] as ToolStripMenuItem;
            darkModeToolStripMenuItem = viewToolStripMenu?.DropDownItems["toggleDarkModeToolStripMenuItem"] as ToolStripMenuItem;
            Assert.NotNull(viewToolStripMenu);
            Assert.NotNull(darkModeToolStripMenuItem);
        }

        [Fact]
        // Description: Should change the forecolor to black and backcolor to white of all controls when `darkModeToolStripMenuItem` is clicked using method `ToggleDarkMode`.
        public void ShouldToggleDarkMode()
        {
            form.ToggleDarkMode();

            Assert.NotEqual(System.Drawing.Color.Black, form.ForeColor);
            Assert.NotEqual(System.Drawing.Color.White, form.BackColor);
            Assert.NotEqual(System.Drawing.Color.White, richTextBox.BackColor);
            Assert.NotEqual(System.Drawing.Color.Black, richTextBox.ForeColor);
            Assert.NotEqual(System.Drawing.Color.White, mainMenuStrip.BackColor);
            Assert.NotEqual(System.Drawing.Color.Black, mainMenuStrip.ForeColor);
        }
    }
}
