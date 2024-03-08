namespace CodeChum.Tests
{
    public class SimpleWordAppTest
    {
        SimpleWordApp? form;
        RichTextBox? MainRichTextBox;
        ToolStrip? WordToolStrip;
        ToolStripComboBox? FontComboBox, ColorComboBox;
        ToolStripTextBox? FontSizeTextBox;
        ToolStripButton? NewButton, SaveButton, PrintButton;
        StatusStrip? StatusStrip;
        ToolStripStatusLabel? StatusLabel;

        public SimpleWordAppTest()
        {
            form = new SimpleWordApp();
            form.Show();
            MainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "MainRichTextBox", true);
            WordToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "WordToolStrip", true);
            StatusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "StatusStrip", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainRichTextBox);
            Assert.NotNull(WordToolStrip);
            Assert.NotNull(StatusStrip);
        }

        [Fact]
        public void ShouldHaveAllToolStripItems()
        {
            FontComboBox = WordToolStrip.Items["FontComboBox"] as ToolStripComboBox;
            ColorComboBox = WordToolStrip.Items["ColorComboBox"] as ToolStripComboBox;
            FontSizeTextBox = WordToolStrip.Items["FontSizeTextBox"] as ToolStripTextBox;
            NewButton = WordToolStrip.Items["NewButton"] as ToolStripButton;
            SaveButton = WordToolStrip.Items["SaveButton"] as ToolStripButton;
            PrintButton = WordToolStrip.Items["PrintButton"] as ToolStripButton;
            StatusLabel = StatusStrip.Items["StatusLabel"] as ToolStripStatusLabel;

            Assert.NotNull(FontComboBox);
            Assert.NotNull(ColorComboBox);
            Assert.NotNull(FontSizeTextBox);
            Assert.NotNull(NewButton);
            Assert.NotNull(SaveButton);
            Assert.NotNull(PrintButton);
            Assert.NotNull(StatusLabel);
        }

        [Fact]
        public void ShouldHaveStatusLabelMessageOnNewButtonClick()
        {
            NewButton = WordToolStrip.Items["NewButton"] as ToolStripButton;
            StatusLabel = StatusStrip.Items["StatusLabel"] as ToolStripStatusLabel;

            NewButton?.PerformClick();
            Assert.Equal("New File Created", StatusLabel?.Text);
        }

        [Fact]
        public void ShouldHaveStatusLabelMessageOnSaveButtonClick()
        {
            SaveButton = WordToolStrip.Items["SaveButton"] as ToolStripButton;
            StatusLabel = StatusStrip.Items["StatusLabel"] as ToolStripStatusLabel;

            SaveButton?.PerformClick();
            Assert.Equal("File Saved", StatusLabel?.Text);
        }

        [Fact]
        public void ShouldHaveStatusLabelMessageOnPrintButtonClick()
        {
            PrintButton = WordToolStrip.Items["PrintButton"] as ToolStripButton;
            StatusLabel = StatusStrip.Items["StatusLabel"] as ToolStripStatusLabel;

            PrintButton?.PerformClick();
            Assert.Equal("Printing...", StatusLabel?.Text);
        }

        [Fact]
        public void ShouldHaveWordCountOnRichTextBoxTextChange()
        {
            StatusLabel = StatusStrip.Items["StatusLabel"] as ToolStripStatusLabel;

            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
                Assert.Equal("Word Count: 2", StatusLabel?.Text);
            });

            MainRichTextBox.Text = "Hello World";
            registerTask.Wait();            
        }

        [Fact]
        public void ShouldChangeFontOnFontComboBoxSelectedIndexChanged()
        {
            FontComboBox = WordToolStrip.Items["FontComboBox"] as ToolStripComboBox;

            FontComboBox.SelectedIndex = 1;
            Task.Delay(TimeSpan.FromSeconds(5));
            Assert.Equal("Times New Roman", MainRichTextBox?.Font.FontFamily.Name);
        }

        [Fact]
        public void ShouldChangeColorOnColorComboBoxSelectedIndexChanged()
        {
            ColorComboBox = WordToolStrip.Items["ColorComboBox"] as ToolStripComboBox;

            ColorComboBox.SelectedIndex = 1;
            Task.Delay(TimeSpan.FromSeconds(5));
            Assert.Equal("Red", MainRichTextBox?.ForeColor.Name);
        }

        [Fact]
        public void ShouldChangeFontSizeOnFontSizeTextBoxTextChanged()
        {
            FontSizeTextBox = WordToolStrip.Items["FontSizeTextBox"] as ToolStripTextBox;

            FontSizeTextBox.Text = "14";
            Task.Delay(TimeSpan.FromSeconds(5));
            Assert.Equal(14, MainRichTextBox?.Font.Size);
        }
    }
}
