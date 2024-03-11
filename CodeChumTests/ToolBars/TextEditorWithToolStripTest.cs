using System.Drawing;

namespace CodeChum.Tests
{
    public class ToolStripTextEditor2Tests
    {
        ToolStripTextEditor? form;
        RichTextBox? MainRichTextBox;
        ToolStrip? EditorToolStrip, ColorToolStrip;
        ToolStripComboBox? FontComboBox, FontSizeComboBox;
        ToolStripButton? ReplaceAllButton, OpenColorsToolStripButton;
        ToolStripTextBox? ReplaceAllTextBox, FindTextBox;

        public ToolStripTextEditor2Tests()
        {
            form = new ToolStripTextEditor();
            form.Show();

            EditorToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "EditorToolStrip", true);
            ColorToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "ColorToolStrip", true);
            MainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "MainRichTextBox", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
           Assert.NotNull(EditorToolStrip);
           Assert.NotNull(ColorToolStrip);
           Assert.NotNull(MainRichTextBox);
        }

        [Fact]
        public void ShouldHaveAllToolStripControlsForEditorToolStrip()
        {
            FontComboBox = EditorToolStrip.Items["FontComboBox"] as ToolStripComboBox;
            FontSizeComboBox = EditorToolStrip.Items["FontSizeComboBox"] as ToolStripComboBox;
            FindTextBox = EditorToolStrip.Items["FindTextBox"] as ToolStripTextBox;
            ReplaceAllTextBox = EditorToolStrip.Items["ReplaceAllTextBox"] as ToolStripTextBox;
            ReplaceAllButton = EditorToolStrip.Items["ReplaceAllButton"] as ToolStripButton;
            OpenColorsToolStripButton = EditorToolStrip.Items["OpenColorsToolStripButton"] as ToolStripButton;

           Assert.NotNull(FontComboBox);
           Assert.NotNull(FontSizeComboBox);
           Assert.NotNull(FindTextBox);
           Assert.NotNull(ReplaceAllTextBox);
           Assert.NotNull(ReplaceAllButton);
           Assert.NotNull(OpenColorsToolStripButton);
        }

        [Fact]
        public void ShouldNotShowColorToolStripByDefault()
        {
            Assert.False(ColorToolStrip.Visible, "The ColorToolStrip should not be visible by default.");
        }

        [Fact]
        public void ShouldHaveAllToolStripControlsForColorToolStrip()
        {
            String[] colorButtons = {
                "BlackButton",
                "BlueButton",
                "GreenButton",
                "RedButton",
                "YellowButton",
            };

            foreach (string colorButton in colorButtons)
            {
                ToolStripButton button = ColorToolStrip.Items[colorButton] as ToolStripButton;

               Assert.NotNull(button);
            }
        }

        [Fact]
        public void ShouldOpenOrCloseColorToolStripOnColorButtonClick()
        {
            OpenColorsToolStripButton = EditorToolStrip.Items["OpenColorsToolStripButton"] as ToolStripButton;

            Assert.False(ColorToolStrip.Visible, "The ColorToolStrip should not be visible by default.");

            OpenColorsToolStripButton.PerformClick();
            Assert.True(ColorToolStrip.Visible, "The ColorToolStrip should show on button click when it is not visible.");

            OpenColorsToolStripButton.PerformClick();
            Assert.False(ColorToolStrip.Visible, "The ColorToolStrip should close on button click when it is visible.");
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
        public void ShouldBeAbleToReplaceAllTextInTextBox()
        {
            FindTextBox = EditorToolStrip.Items["FindTextBox"] as ToolStripTextBox;
            ReplaceAllTextBox = EditorToolStrip.Items["ReplaceAllTextBox"] as ToolStripTextBox;
            ReplaceAllButton = EditorToolStrip.Items["ReplaceAllButton"] as ToolStripButton;

            String expectedText = "Hello world, goodbye world, goodbye world\ngoodbye world, Hello world";
            MainRichTextBox.Text = "Hello world, hello world, hello world\nhello world, Hello world";
            FindTextBox.Text = "hello";
            ReplaceAllTextBox.Text = "goodbye";

            ReplaceAllButton.PerformClick();

            Assert.Equal(expectedText, MainRichTextBox.Text);
        }

        [Fact]
        public void ShouldBeAbleToChangeForeColorOfTextBox()
        {
            String[] colorButtons = {
                "BlackButton",
                "BlueButton",
                "GreenButton",
                "RedButton",
                "YellowButton",
            };

            Color[] colors = {
                Color.Black,
                Color.Blue,
                Color.Green,
                Color.Red,
                Color.Yellow,
            };

            for (int i = 0; i < colorButtons.Length; i++)
            {
                ToolStripButton button = ColorToolStrip.Items[colorButtons[i]] as ToolStripButton;

                button.PerformClick();

                Assert.Equal(colors[i], MainRichTextBox.ForeColor);
            }
        }
    }
}