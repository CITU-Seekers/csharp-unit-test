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
        // Description: Should have all the controls `editorToolStrip` and `mainRichTextBox`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(editorToolStrip);
            Assert.NotNull(mainRichTextBox);
        }

        [Fact]
        // Description: Should have all the controls `fontComboBox`, `fontSizeComboBox`, `underlineButton`, `boldButton`, and `italicButton` in `editorToolStrip`.
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
        // Description: Should change font family of `mainRichTextBox` when selected item in the `fontComboBox` changes.
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
        // Description: Should change font size of `mainRichTextBox` when selected item in the `fontSizeComboBox` changes.
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
        // Description: Should be able to toggle bold font style of `mainRichTextBox` on `boldButton` click.
        public void ShouldBeAbleToToggleBoldFontStyle()
        {
            boldButton = editorToolStrip.Items["boldButton"] as ToolStripButton;

            boldButton.PerformClick();
            Assert.Equal(FontStyle.Bold, mainRichTextBox.Font.Style);

            boldButton.PerformClick();
            Assert.Equal(FontStyle.Regular, mainRichTextBox.Font.Style);
        }

        [Fact]
        // Description: Should be able to toggle underline font style of `mainRichTextBox` on `underlineButton` click.
        public void ShouldBeAbleToToggleUnderlineFontStyle()
        {
            underlineButton = editorToolStrip.Items["underlineButton"] as ToolStripButton;

            underlineButton.PerformClick();
            Assert.Equal(FontStyle.Underline, mainRichTextBox.Font.Style);

            underlineButton.PerformClick();
            Assert.Equal(FontStyle.Regular, mainRichTextBox.Font.Style);
        }

        [Fact]
        // Description: Should be able to toggle italic font style of `mainRichTextBox` on `italicButton` click.
        public void ShouldBeAbleToToggleItalicFontStyle()
        {
            italicButton = editorToolStrip.Items["italicButton"] as ToolStripButton;

            italicButton.PerformClick();
            Assert.Equal(FontStyle.Italic, mainRichTextBox.Font.Style);

            italicButton.PerformClick();
            Assert.Equal(FontStyle.Regular, mainRichTextBox.Font.Style);
        }

        [Fact]
        // Description: Should be able to toggle multiple font styles of `mainRichTextBox` on `underlineButton`, `boldButton`, and `italicButton` click.
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