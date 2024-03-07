namespace CodeChum.Tests
{
    public class DarkModeTest
    {
        DarkMode? form;
        MenuStrip? MainMenuStrip;
        RichTextBox? TextBox;
        ToolStripMenuItem? ViewToolStripMenu;
        ToolStripMenuItem? DarkModeToolStripMenuItem;

        public DarkModeTest()
        {
            form = new DarkMode();
            form.Show();
            MainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "MainMenuStrip", true);
            TextBox = (RichTextBox)TestUtils.GetControlNamed(form, "TextBox", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainMenuStrip);
            Assert.NotNull(TextBox);
        }

        [Fact]
        public void ShouldToggleDarkMode()
        {
            ViewToolStripMenu = MainMenuStrip.Items["viewToolStripMenuItem"] as ToolStripMenuItem;
            DarkModeToolStripMenuItem = ViewToolStripMenu?.DropDownItems["toggleDarkModeToolStripMenuItem"] as ToolStripMenuItem;

            DarkModeToolStripMenuItem.PerformClick();

            Assert.NotEqual(System.Drawing.Color.Black, form.ForeColor);
            Assert.NotEqual(System.Drawing.Color.White, form.BackColor);
            Assert.NotEqual(System.Drawing.Color.White, TextBox.BackColor);
            Assert.NotEqual(System.Drawing.Color.Black, TextBox.ForeColor);
            Assert.NotEqual(System.Drawing.Color.White, MainMenuStrip.BackColor);
            Assert.NotEqual(System.Drawing.Color.Black, MainMenuStrip.ForeColor);
        }
    }
}
