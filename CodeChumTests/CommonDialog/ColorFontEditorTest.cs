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
        // Description: Should have all the controls `mainRichTextBox`, `colorButton`, and `fontButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainRichTextBox);
            Assert.NotNull(colorButton);
            Assert.NotNull(fontButton);
        }

        [Fact]
        // Description: Should change the fore color of the `mainRichTextBox` when a color is selected from the color dialog
        public void ShouldChangeTextColorOnColorButtonClickAndColorDialogSelect()
        {
            form.editorColorDialog.Color = Color.Red;
            colorButton.PerformClick();

            Assert.Equal(Color.Red, mainRichTextBox.ForeColor);
        }

        [Fact]
        // Description: Should change the font of the `mainRichTextBox` when a font is selected from the font dialog
        public void ShouldChangeFontOnFontButtonClickAndFontDialogSelect()
        {
            Font expectedFont = new Font(new FontFamily("Arial"), 34, FontStyle.Bold);

            form.editorFontDialog.Font = expectedFont;
            fontButton.PerformClick();

            Assert.Equal(expectedFont, mainRichTextBox.Font);
        }
    }
}