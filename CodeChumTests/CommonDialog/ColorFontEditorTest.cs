using System.Drawing;

namespace CodeChum.Tests
{
    public class ColorAndFontEditorTests
    {
        ColorFontEditor? form;
        RichTextBox? MainRichTextBox;
        Button? ColorButton, FontButton;

        public ColorAndFontEditorTests()
        {
            form = new ColorFontEditor();
            form.Show();
            MainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "MainRichTextBox", true);
            ColorButton = (Button)TestUtils.GetControlNamed(form, "ColorButton", true);
            FontButton = (Button)TestUtils.GetControlNamed(form, "FontButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainRichTextBox);
            Assert.NotNull(ColorButton);
            Assert.NotNull(FontButton);
        }

        [Fact]
        public void ShouldChangeTextColorOnColorButtonClickAndColorDialogSelect()
        {
            form.EditorColorDialog.Color = Color.Red;
            ColorButton.PerformClick();

            Assert.Equal(Color.Red, MainRichTextBox.ForeColor);
        }

        [Fact]
        public void ShouldChangeFontOnFontButtonClickAndFontDialogSelect()
        {
            Font expectedFont = new Font(new FontFamily("Arial"), 34, FontStyle.Bold);

            form.EditorFontDialog.Font = expectedFont;
            FontButton.PerformClick();

            Assert.Equal(expectedFont, MainRichTextBox.Font);
        }
    }
}