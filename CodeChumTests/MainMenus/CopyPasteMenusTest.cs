using System.Drawing;

namespace CodeChum.Tests
{
    public class CopyPasteMenusTest
    {
        CopyPasteMenus? form;
        MenuStrip? mainMenuStrip;
        ToolStripMenuItem? editToolStripMenuItem;
        ToolStripMenuItem? copyToolStripMenuItem;
        ToolStripMenuItem? pasteToolStripMenuItem;
        ToolStripMenuItem? cutToolStripMenuItem;
        ToolStripMenuItem? formatToolStripMenuItem;
        ToolStripMenuItem? fontColorToolStripMenuItem;
        ToolStripMenuItem? fontStyleToolStripMenuItem;
        RichTextBox? richTextBox1;
        RichTextBox? richTextBox2;

        public CopyPasteMenusTest()
        {
            form = new CopyPasteMenus();
            form.Show();
            mainMenuStrip = (MenuStrip)TestUtils.GetControlNamed(form, "mainMenuStrip", true);
            richTextBox1 = (RichTextBox)TestUtils.GetControlNamed(form, "richTextBox1", true);
            richTextBox2 = (RichTextBox)TestUtils.GetControlNamed(form, "richTextBox2", true);
        }

        [Fact]
        // Description: Should have all controls `mainMenuStrip`, `richTextBox1`, and `richTextBox2`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainMenuStrip);
            Assert.NotNull(richTextBox1);
            Assert.NotNull(richTextBox2);
        }

        [Fact]
        // Description: Should have `editToolStripMenuItem` and its menu items `copyToolStripMenuItem`, `pasteToolStripMenuItem`, and `cutToolStripMenuItem`.
        public void ShouldHaveEditToolStripMenuAndItsMenuItems()
        {
            editToolStripMenuItem = mainMenuStrip.Items["editToolStripMenuItem"] as ToolStripMenuItem;
            copyToolStripMenuItem = editToolStripMenuItem?.DropDownItems["copyToolStripMenuItem"] as ToolStripMenuItem;
            pasteToolStripMenuItem = editToolStripMenuItem?.DropDownItems["pasteToolStripMenuItem"] as ToolStripMenuItem;
            cutToolStripMenuItem = editToolStripMenuItem?.DropDownItems["cutToolStripMenuItem"] as ToolStripMenuItem;
            Assert.NotNull(editToolStripMenuItem);
            Assert.NotNull(copyToolStripMenuItem);
            Assert.NotNull(pasteToolStripMenuItem);
            Assert.NotNull(cutToolStripMenuItem);
        }

        [Fact]
        // Description: Should have `formatToolStripMenuItem` and its menu items `fontColorToolStripMenuItem` and `fontStyleToolStripMenuItem`.
        public void ShouldHaveFormatToolStripMenuAndItsMenuItems()
        {
            formatToolStripMenuItem = mainMenuStrip.Items["formatToolStripMenuItem"] as ToolStripMenuItem;
            fontColorToolStripMenuItem = formatToolStripMenuItem?.DropDownItems["fontColorToolStripMenuItem"] as ToolStripMenuItem;
            fontStyleToolStripMenuItem = formatToolStripMenuItem?.DropDownItems["fontStyleToolStripMenuItem"] as ToolStripMenuItem;
            Assert.NotNull(formatToolStripMenuItem);
            Assert.NotNull(fontColorToolStripMenuItem);
            Assert.NotNull(fontStyleToolStripMenuItem);
        }

        [Fact]
        // Description: Should copy text from `richTextBox1` to `richTextBox2` when `copyToolStripMenuItem` is clicked and then `pasteToolStripMenuItem` is clicked.
        public void ShouldCopyTextFromrichTextBox1ToRichTextBox2()
        {
            editToolStripMenuItem = mainMenuStrip.Items["editToolStripMenuItem"] as ToolStripMenuItem;
            copyToolStripMenuItem = editToolStripMenuItem?.DropDownItems["copyToolStripMenuItem"] as ToolStripMenuItem;
            pasteToolStripMenuItem = editToolStripMenuItem?.DropDownItems["pasteToolStripMenuItem"] as ToolStripMenuItem;


            richTextBox1.Text = "Hello World!";

            // Act
            copyToolStripMenuItem.PerformClick();
            pasteToolStripMenuItem.PerformClick();

            // Assert
            Assert.Equal("Hello World!", richTextBox2.Text);
        }

        [Fact]
        // Description: Should cut text from `richTextBox1` to `richTextBox2` when `cutToolStripMenuItem` is clicked.
        public void ShouldCutTextFromrichTextBox1ToRichTextBox2()
        {
            editToolStripMenuItem = mainMenuStrip.Items["editToolStripMenuItem"] as ToolStripMenuItem;
            cutToolStripMenuItem = editToolStripMenuItem?.DropDownItems["cutToolStripMenuItem"] as ToolStripMenuItem;

            richTextBox1.Text = "Hello World";
            cutToolStripMenuItem.PerformClick();
            Assert.Equal("", richTextBox1.Text);
        }

        [Fact]
        // Description: Should change font color of `richTextBox1` and `richTextBox2` to red when `fontColorToolStripMenuItem` is clicked by using method `ChangeFontColor`.
        public void ShouldChangeFontColorOfRichTextBox1n2()
        {
            form.FormatColorDialog.Color = Color.Red;

            formatToolStripMenuItem = mainMenuStrip.Items["formatToolStripMenuItem"] as ToolStripMenuItem;
            fontColorToolStripMenuItem = formatToolStripMenuItem?.DropDownItems["fontColorToolStripMenuItem"] as ToolStripMenuItem;

            form.ChangeFontColor(Color.Red);

            Assert.Equal(Color.Red, richTextBox1.ForeColor);
            Assert.Equal(Color.Red, richTextBox2.ForeColor);
        }

        [Fact]
        // Description: Should change font of `richTextBox1` and `richTextBox2` to Arial 12 when `fontStyleToolStripMenuItem` is clicked by using method `ChangeFontStyle`.
        public void ShouldChangeFontOfRichTextBox1n2()
        {
            formatToolStripMenuItem = mainMenuStrip.Items["formatToolStripMenuItem"] as ToolStripMenuItem;
            fontStyleToolStripMenuItem = formatToolStripMenuItem?.DropDownItems["fontStyleToolStripMenuItem"] as ToolStripMenuItem;

            Font expectedFont = new Font("Arial", 12);
            form.FormatFontDialog.Font = expectedFont;
            
            form.ChangeFontStyle(expectedFont);

            Assert.Equal(expectedFont, richTextBox1.Font);
            Assert.Equal(expectedFont, richTextBox2.Font);
        }
    }
}
