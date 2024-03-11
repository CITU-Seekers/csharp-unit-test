using System.Drawing;

namespace CodeChum.Tests
{
    public class ToolStripTextEditorTests
    {
        ToolStripTextEditor? form;
        RichTextBox? MainRichTextBox;
        ToolStrip? EditorToolStrip;
        ToolStripComboBox? FontComboBox, FontSizeComboBox;
        ToolStripButton? UnderlineButton, BoldButton, ItalicButton;

        public ToolStripTextEditorTests()
        {
            form = new ToolStripTextEditor();
            form.Show();

            EditorToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "EditorToolStrip", true);
            MainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "MainRichTextBox", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(EditorToolStrip);
            Assert.NotNull(MainRichTextBox);
        }

        [Fact]
        public void ShouldHaveAllToolStripControls()
        {
            FontComboBox = EditorToolStrip.Items["FontComboBox"] as ToolStripComboBox;
            FontSizeComboBox = EditorToolStrip.Items["FontSizeComboBox"] as ToolStripComboBox;
            UnderlineButton = EditorToolStrip.Items["UnderlineButton"] as ToolStripButton;
            BoldButton = EditorToolStrip.Items["BoldButton"] as ToolStripButton;
            ItalicButton = EditorToolStrip.Items["ItalicButton"] as ToolStripButton;

            Assert.NotNull(FontComboBox);
            Assert.NotNull(FontSizeComboBox);
            Assert.NotNull(UnderlineButton);
            Assert.NotNull(BoldButton);
            Assert.NotNull(ItalicButton);
        }

        [Fact]
        public void ShouldBeAbleToChangeFontFamily()
        {
            FontComboBox = EditorToolStrip.Items["FontComboBox"] as ToolStripComboBox;
            String[] fontFamilies = {
                "Arial",
                "Cascadia Code",
                "Segoe UI",
                "Tahoma",
                "Verdana",
            };

            foreach (string fontFamily in fontFamilies)
            {
                FontComboBox.SelectedIndex = FontComboBox.Items.IndexOf(fontFamily);
                Assert.Equal(fontFamily, MainRichTextBox.Font.FontFamily.Name);
            }
        }

        [Fact]
        public void ShouldBeAbleToChangeFontSize()
        {
            FontSizeComboBox = EditorToolStrip.Items["FontSizeComboBox"] as ToolStripComboBox;
            String[] fontSizes = {
                "8",
                "10",
                "12",
                "14",
                "16",
            };

            foreach (string fontSize in fontSizes)
            {
                FontSizeComboBox.SelectedIndex = FontSizeComboBox.Items.IndexOf(fontSize);
                Assert.Equal(int.Parse(fontSize), MainRichTextBox.Font.Size);
            }
        }

        [Fact]
        public void ShouldBeAbleToToggleBoldFontStyle()
        {
            BoldButton = EditorToolStrip.Items["BoldButton"] as ToolStripButton;

            BoldButton.PerformClick();
            Assert.Equal(FontStyle.Bold, MainRichTextBox.Font.Style);

            BoldButton.PerformClick();
            Assert.Equal(FontStyle.Regular, MainRichTextBox.Font.Style);
        }

        [Fact]
        public void ShouldBeAbleToToggleUnderlineFontStyle()
        {
            UnderlineButton = EditorToolStrip.Items["UnderlineButton"] as ToolStripButton;

            UnderlineButton.PerformClick();
            Assert.Equal(FontStyle.Underline, MainRichTextBox.Font.Style);

            UnderlineButton.PerformClick();
            Assert.Equal(FontStyle.Regular, MainRichTextBox.Font.Style);
        }

        [Fact]
        public void ShouldBeAbleToToggleItalicFontStyle()
        {
            ItalicButton = EditorToolStrip.Items["ItalicButton"] as ToolStripButton;

            ItalicButton.PerformClick();
            Assert.Equal(FontStyle.Italic, MainRichTextBox.Font.Style);

            ItalicButton.PerformClick();
            Assert.Equal(FontStyle.Regular, MainRichTextBox.Font.Style);
        }

        [Fact]
        public void ShouldBeAbleToToggleMultipleFontStyles()
        {
            UnderlineButton = EditorToolStrip.Items["UnderlineButton"] as ToolStripButton;
            BoldButton = EditorToolStrip.Items["BoldButton"] as ToolStripButton;
            ItalicButton = EditorToolStrip.Items["ItalicButton"] as ToolStripButton;

            FontStyle expectedFontStyle = FontStyle.Italic | FontStyle.Bold | FontStyle.Underline;

            UnderlineButton.PerformClick();
            BoldButton.PerformClick();
            ItalicButton.PerformClick();

            Assert.Equal(expectedFontStyle, MainRichTextBox.Font.Style);
        }
    }
}