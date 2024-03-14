using System.Drawing;

namespace CodeChum.Tests
{
    public class ColorAndFontEditorTests
    {
        ColorFontEditor form;
        RichTextBox mainRichTextBox;
        Button colorButton, fontButton;

        public ColorAndFontEditorTests()
        {
            form = new ColorFontEditor();
            form.Show();
            mainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "mainRichTextBox", true);
            colorButton = (Button)TestUtils.GetControlNamed(form, "colorButton", true);
            fontButton = (Button)TestUtils.GetControlNamed(form, "fontButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainRichTextBox);
            Assert.NotNull(colorButton);
            Assert.NotNull(fontButton);
        }

        [Fact]
        public void ShouldChangeTextColorOnColorButtonClickAndColorDialogSelect()
        {
            form.EditorColorDialog.Color = Color.Red;
            colorButton.PerformClick();

            Assert.Equal(Color.Red, mainRichTextBox.ForeColor);
        }

        [Fact]
        public void ShouldChangeFontOnFontButtonClickAndFontDialogSelect()
        {
            Font expectedFont = new Font(new FontFamily("Arial"), 34, FontStyle.Bold);

            form.EditorFontDialog.Font = expectedFont;
            fontButton.PerformClick();

            Assert.Equal(expectedFont, mainRichTextBox.Font);
        }
    }
}