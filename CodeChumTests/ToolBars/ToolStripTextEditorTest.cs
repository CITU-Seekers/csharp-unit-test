using System.Drawing;

namespace CodeChum.Tests
{
    public class ToolStripTextEditorTests
    {
        ToolStripTextEditor? form;
        RichTextBox? mainRichTextBox;
        ToolStrip? editorToolStrip;
        ToolStripComboBox? fontComboBox, fontSizeComboBox;
        ToolStripButton? underlineButton, boldButton, italicButton;

        public ToolStripTextEditorTests()
        {
            form = new ToolStripTextEditor();
            form.Show();

            editorToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "editorToolStrip", true);
            mainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "mainRichTextBox", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(editorToolStrip);
            Assert.NotNull(mainRichTextBox);
        }

        [Fact]
        public void ShouldHaveAllToolStripControls()
        {
            fontComboBox = editorToolStrip.Items["fontComboBox"] as ToolStripComboBox;
            fontSizeComboBox = editorToolStrip.Items["fontSizeComboBox"] as ToolStripComboBox;
            underlineButton = editorToolStrip.Items["underlineButton"] as ToolStripButton;
            boldButton = editorToolStrip.Items["boldButton"] as ToolStripButton;
            italicButton = editorToolStrip.Items["italicButton"] as ToolStripButton;

            Assert.NotNull(fontComboBox);
            Assert.NotNull(fontSizeComboBox);
            Assert.NotNull(underlineButton);
            Assert.NotNull(boldButton);
            Assert.NotNull(italicButton);
        }

        [Fact]
        public void ShouldBeAbleToChangeFontFamily()
        {
            fontComboBox = editorToolStrip.Items["fontComboBox"] as ToolStripComboBox;
            String[] fontFamilies = {
                "Arial",
                "Cascadia Code",
                "Segoe UI",
                "Tahoma",
                "Verdana",
            };

            foreach (string fontFamily in fontFamilies)
            {
                fontComboBox.SelectedIndex = fontComboBox.Items.IndexOf(fontFamily);
                Assert.Equal(fontFamily, mainRichTextBox.Font.FontFamily.Name);
            }
        }

        [Fact]
        public void ShouldBeAbleToChangeFontSize()
        {
            fontSizeComboBox = editorToolStrip.Items["fontSizeComboBox"] as ToolStripComboBox;
            String[] fontSizes = {
                "8",
                "10",
                "12",
                "14",
                "16",
            };

            foreach (string fontSize in fontSizes)
            {
                fontSizeComboBox.SelectedIndex = fontSizeComboBox.Items.IndexOf(fontSize);
                Assert.Equal(int.Parse(fontSize), mainRichTextBox.Font.Size);
            }
        }

        [Fact]
        public void ShouldBeAbleToToggleBoldFontStyle()
        {
            boldButton = editorToolStrip.Items["boldButton"] as ToolStripButton;

            boldButton.PerformClick();
            Assert.Equal(FontStyle.Bold, mainRichTextBox.Font.Style);

            boldButton.PerformClick();
            Assert.Equal(FontStyle.Regular, mainRichTextBox.Font.Style);
        }

        [Fact]
        public void ShouldBeAbleToToggleUnderlineFontStyle()
        {
            underlineButton = editorToolStrip.Items["underlineButton"] as ToolStripButton;

            underlineButton.PerformClick();
            Assert.Equal(FontStyle.Underline, mainRichTextBox.Font.Style);

            underlineButton.PerformClick();
            Assert.Equal(FontStyle.Regular, mainRichTextBox.Font.Style);
        }

        [Fact]
        public void ShouldBeAbleToToggleItalicFontStyle()
        {
            italicButton = editorToolStrip.Items["italicButton"] as ToolStripButton;

            italicButton.PerformClick();
            Assert.Equal(FontStyle.Italic, mainRichTextBox.Font.Style);

            italicButton.PerformClick();
            Assert.Equal(FontStyle.Regular, mainRichTextBox.Font.Style);
        }

        [Fact]
        public void ShouldBeAbleToToggleMultipleFontStyles()
        {
            underlineButton = editorToolStrip.Items["underlineButton"] as ToolStripButton;
            boldButton = editorToolStrip.Items["boldButton"] as ToolStripButton;
            italicButton = editorToolStrip.Items["italicButton"] as ToolStripButton;

            FontStyle expectedFontStyle = FontStyle.Italic | FontStyle.Bold | FontStyle.Underline;

            underlineButton.PerformClick();
            boldButton.PerformClick();
            italicButton.PerformClick();

            Assert.Equal(expectedFontStyle, mainRichTextBox.Font.Style);
        }
    }
}