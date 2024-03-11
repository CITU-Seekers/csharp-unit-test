using System.Drawing;

namespace CodeChum.Tests
{
    public class CopyPasteMenusTest
    {
        CopyPasteMenus? form;
        MenuStrip? MainMenuStrip;
        ToolStripMenuItem? EditToolStripMenuItem;
        ToolStripMenuItem? CopyToolStripMenuItem;
        ToolStripMenuItem? PasteToolStripMenuItem;
        ToolStripMenuItem? CutToolStripMenuItem;
        ToolStripMenuItem? FormatToolStripMenuItem;
        ToolStripMenuItem? FontColorToolStripMenuItem;
        ToolStripMenuItem? FontStyleToolStripMenuItem;
        RichTextBox? RichTextBox1;
        RichTextBox? RichTextBox2;

        public CopyPasteMenusTest()
        {
            form = new CopyPasteMenus();
            form.Show();
            MainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "MainMenuStrip", true);
            RichTextBox1 = (RichTextBox)TestUtils.GetControlNamed(form, "richTextBox1", true);
            RichTextBox2 = (RichTextBox)TestUtils.GetControlNamed(form, "richTextBox2", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainMenuStrip);
            Assert.NotNull(RichTextBox1);
            Assert.NotNull(RichTextBox2);
        }

        [Fact]
        public void ShouldHaveEditToolStripMenuAndItsMenuItems()
        {
            EditToolStripMenuItem = MainMenuStrip.Items["editToolStripMenuItem"] as ToolStripMenuItem;
            CopyToolStripMenuItem = EditToolStripMenuItem?.DropDownItems["copyToolStripMenuItem"] as ToolStripMenuItem;
            PasteToolStripMenuItem = EditToolStripMenuItem?.DropDownItems["pasteToolStripMenuItem"] as ToolStripMenuItem;
            CutToolStripMenuItem = EditToolStripMenuItem?.DropDownItems["cutToolStripMenuItem"] as ToolStripMenuItem;
            Assert.NotNull(EditToolStripMenuItem);
            Assert.NotNull(CopyToolStripMenuItem);
            Assert.NotNull(PasteToolStripMenuItem);
            Assert.NotNull(CutToolStripMenuItem);
        }

        [Fact]
        public void ShouldHaveFormatToolStripMenuAndItsMenuItems()
        {
            FormatToolStripMenuItem = MainMenuStrip.Items["formatToolStripMenuItem"] as ToolStripMenuItem;
            FontColorToolStripMenuItem = FormatToolStripMenuItem?.DropDownItems["fontColorToolStripMenuItem"] as ToolStripMenuItem;
            FontStyleToolStripMenuItem = FormatToolStripMenuItem?.DropDownItems["fontStyleToolStripMenuItem"] as ToolStripMenuItem;
            Assert.NotNull(FormatToolStripMenuItem);
            Assert.NotNull(FontColorToolStripMenuItem);
            Assert.NotNull(FontStyleToolStripMenuItem);
        }

        [Fact]
        public void ShouldCopyTextFromRichTextBox1ToRichTextBox2()
        {
            EditToolStripMenuItem = MainMenuStrip.Items["editToolStripMenuItem"] as ToolStripMenuItem;
            CopyToolStripMenuItem = EditToolStripMenuItem?.DropDownItems["copyToolStripMenuItem"] as ToolStripMenuItem;
            PasteToolStripMenuItem = EditToolStripMenuItem?.DropDownItems["pasteToolStripMenuItem"] as ToolStripMenuItem;


            RichTextBox1.Text = "Hello World!";

            // Act
            CopyToolStripMenuItem.PerformClick();
            PasteToolStripMenuItem.PerformClick();

            // Assert
            Assert.Equal("Hello World!", RichTextBox2.Text);
        }

        [Fact]
        public void ShouldCutTextFromRichTextBox1ToRichTextBox2()
        {
            EditToolStripMenuItem = MainMenuStrip.Items["editToolStripMenuItem"] as ToolStripMenuItem;
            CutToolStripMenuItem = EditToolStripMenuItem?.DropDownItems["cutToolStripMenuItem"] as ToolStripMenuItem;

            RichTextBox1.Text = "Hello World";
            CutToolStripMenuItem.PerformClick();
            Assert.Equal("", RichTextBox1.Text);
        }

        [Fact]
        public void ShouldChangeFontColorOfRichTextBox1()
        {
            form.FormatColorDialog.Color = Color.Red;

            FormatToolStripMenuItem = MainMenuStrip.Items["formatToolStripMenuItem"] as ToolStripMenuItem;
            FontColorToolStripMenuItem = FormatToolStripMenuItem?.DropDownItems["fontColorToolStripMenuItem"] as ToolStripMenuItem;


            FontColorToolStripMenuItem?.PerformClick();

            Assert.Equal(Color.Red, RichTextBox1.ForeColor);
        }

        [Fact]
        public void ShouldChangeFontOfRichTextBox1()
        {
            FormatToolStripMenuItem = MainMenuStrip.Items["formatToolStripMenuItem"] as ToolStripMenuItem;
            FontStyleToolStripMenuItem = FormatToolStripMenuItem?.DropDownItems["fontStyleToolStripMenuItem"] as ToolStripMenuItem;

            Font expectedFont = new System.Drawing.Font("Arial", 12);
            form.FormatFontDialog.Font = expectedFont;
            FontStyleToolStripMenuItem?.PerformClick();

            Assert.Equal(expectedFont, RichTextBox1.Font);
        }
    }
}
