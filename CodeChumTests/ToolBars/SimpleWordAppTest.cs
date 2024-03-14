namespace CodeChum.Tests
{
    public class SimpleWordAppTest
    {
        SimpleWordApp? form;
        RichTextBox? mainRichTextBox;
        ToolStrip? wordToolStrip;
        ToolStripComboBox? fontToolStripComboBox, colorToolStripComboBox;
        ToolStripTextBox? fontSizeToolStripTextBox;
        ToolStripButton? newToolStripButton, saveToolStripButton, printToolStripButton;
        StatusStrip? statusStrip;
        ToolStripStatusLabel? toolStripStatusLabel;

        public SimpleWordAppTest()
        {
            form = new SimpleWordApp();
            form.Show();
            mainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "mainRichTextBox", true);
            wordToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "wordToolStrip", true);
            statusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "statusStrip", true);
        }

        [Fact]
        // Description: Should have all the controls `mainRichTextBox`, `wordToolStrip`, and `statusStrip`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainRichTextBox);
            Assert.NotNull(wordToolStrip);
            Assert.NotNull(statusStrip);
        }

        [Fact]
        // Description: Should have all the ToolStripItems `fontToolStripComboBox`, `colorToolStripComboBox`, `fontSizeToolStripTextBox`, `newToolStripButton`, `saveToolStripButton`, `printToolStripButton`, and `toolStripStatusLabel`.
        public void ShouldHaveAllToolStripItems()
        {
            fontToolStripComboBox = wordToolStrip.Items["fontToolStripComboBox"] as ToolStripComboBox;
            colorToolStripComboBox = wordToolStrip.Items["colorToolStripComboBox"] as ToolStripComboBox;
            fontSizeToolStripTextBox = wordToolStrip.Items["fontSizeToolStripTextBox"] as ToolStripTextBox;
            newToolStripButton = wordToolStrip.Items["newToolStripButton"] as ToolStripButton;
            saveToolStripButton = wordToolStrip.Items["saveToolStripButton"] as ToolStripButton;
            printToolStripButton = wordToolStrip.Items["printToolStripButton"] as ToolStripButton;
            toolStripStatusLabel = statusStrip.Items["toolStripStatusLabel"] as ToolStripStatusLabel;

            Assert.NotNull(fontToolStripComboBox);
            Assert.NotNull(colorToolStripComboBox);
            Assert.NotNull(fontSizeToolStripTextBox);
            Assert.NotNull(newToolStripButton);
            Assert.NotNull(saveToolStripButton);
            Assert.NotNull(printToolStripButton);
            Assert.NotNull(toolStripStatusLabel);
        }

        [Fact]
        // Description: Should have text "New File Created" in `toolStripStatusLabel` when the `newToolStripButton` is clicked.
        public void ShouldHavetoolStripStatusLabelMessageOnnewToolStripButtonClick()
        {
            newToolStripButton = wordToolStrip.Items["newToolStripButton"] as ToolStripButton;
            toolStripStatusLabel = statusStrip.Items["toolStripStatusLabel"] as ToolStripStatusLabel;

            newToolStripButton?.PerformClick();
            Assert.Equal("New File Created", toolStripStatusLabel?.Text);
        }

        [Fact]
        // Description: Should have text "File Saved" in `toolStripStatusLabel` when the `saveToolStripButton` is clicked.
        public void ShouldHavetoolStripStatusLabelMessageOnsaveToolStripButtonClick()
        {
            saveToolStripButton = wordToolStrip.Items["saveToolStripButton"] as ToolStripButton;
            toolStripStatusLabel = statusStrip.Items["toolStripStatusLabel"] as ToolStripStatusLabel;

            saveToolStripButton?.PerformClick();
            Assert.Equal("File Saved", toolStripStatusLabel?.Text);
        }

        [Fact]
        // Description: Should have text "Printing..." in `toolStripStatusLabel` when the `printToolStripButton` is clicked.
        public void ShouldHavetoolStripStatusLabelMessageOnprintToolStripButtonClick()
        {
            printToolStripButton = wordToolStrip.Items["printToolStripButton"] as ToolStripButton;
            toolStripStatusLabel = statusStrip.Items["toolStripStatusLabel"] as ToolStripStatusLabel;

            printToolStripButton?.PerformClick();
            Assert.Equal("Printing...", toolStripStatusLabel?.Text);
        }

        [Fact]
        // Description: Should have text "Word Count: 2" in `toolStripStatusLabel` when the `mainRichTextBox` text is changed.
        public void ShouldHaveWordCountOnRichTextBoxTextChange()
        {
            toolStripStatusLabel = statusStrip.Items["toolStripStatusLabel"] as ToolStripStatusLabel;

            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
                Assert.Equal("Word Count: 2", toolStripStatusLabel?.Text);
            });

            mainRichTextBox.Text = "Hello World";
            registerTask.Wait();            
        }

        [Fact]
        // Description: Should have font "Times New Roman" in `mainRichTextBox` when the `fontToolStripComboBox` is changed.
        public void ShouldChangeFontOnfontToolStripComboBoxSelectedIndexChanged()
        {
            fontToolStripComboBox = wordToolStrip.Items["fontToolStripComboBox"] as ToolStripComboBox;

            fontToolStripComboBox.SelectedIndex = 1;
            Task.Delay(TimeSpan.FromSeconds(5));
            Assert.Equal("Times New Roman", mainRichTextBox?.Font.FontFamily.Name);
        }

        [Fact]
        // Description: Should have color "Red" in `mainRichTextBox` when the `colorToolStripComboBox` is changed.
        public void ShouldChangeColorOncolorToolStripComboBoxSelectedIndexChanged()
        {
            colorToolStripComboBox = wordToolStrip.Items["colorToolStripComboBox"] as ToolStripComboBox;

            colorToolStripComboBox.SelectedIndex = 1;
            Task.Delay(TimeSpan.FromSeconds(5));
            Assert.Equal("Red", mainRichTextBox?.ForeColor.Name);
        }

        [Fact]
        // Description: Should have font size "14" in `mainRichTextBox` when the `fontSizeToolStripTextBox` is changed.
        public void ShouldChangeFontSizeOnfontSizeToolStripTextBoxTextChanged()
        {
            fontSizeToolStripTextBox = wordToolStrip.Items["fontSizeToolStripTextBox"] as ToolStripTextBox;

            fontSizeToolStripTextBox.Text = "14";
            Task.Delay(TimeSpan.FromSeconds(5));
            Assert.Equal(14, mainRichTextBox?.Font.Size);
        }
    }
}
