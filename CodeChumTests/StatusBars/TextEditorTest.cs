namespace CodeChum.Tests
{
    public class TextEditorTests
    {
        TextEditor? form;
        RichTextBox? MainRichTextBox;
        Button? ToStartButton, ToEndButton;
        StatusStrip? EditorStatusStrip;
        ToolStripProgressBar? TextLengthProgressBar;
        ToolStripStatusLabel? CaretPositionStatusLabel;

        public TextEditorTests()
        {
            form = new TextEditor();
            form.Show();
            MainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "MainRichTextBox", true);
            ToStartButton = (Button)TestUtils.GetControlNamed(form, "ToStartButton", true);
            ToEndButton = (Button)TestUtils.GetControlNamed(form, "ToEndButton", true);
            EditorStatusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "EditorStatusStrip", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainRichTextBox);
            Assert.NotNull(ToStartButton);
            Assert.NotNull(ToEndButton);
        }

        [Fact]
        public void ShouldHaveStatusStripAndAllStatusStripItems()
        {
            Assert.NotNull(EditorStatusStrip);

            TextLengthProgressBar = EditorStatusStrip.Items["TextLengthProgressBar"] as ToolStripProgressBar;
            Assert.NotNull(TextLengthProgressBar);

            CaretPositionStatusLabel = EditorStatusStrip.Items["CaretPositionStatusLabel"] as ToolStripStatusLabel;
            Assert.NotNull(CaretPositionStatusLabel);
        }

        [Fact]
        public void ShouldHaveCorrectStartingValuesForStatusStrip()
        {
            Assert.NotNull(EditorStatusStrip);

            CaretPositionStatusLabel = EditorStatusStrip.Items["CaretPositionStatusLabel"] as ToolStripStatusLabel;
            Assert.Equal("Ln: 1, Col: 1", CaretPositionStatusLabel.Text);

            TextLengthProgressBar = EditorStatusStrip.Items["TextLengthProgressBar"] as ToolStripProgressBar;
            Assert.Equal(0, TextLengthProgressBar.Value);
        }

        [Fact]
        public void ShouldUpdateCaretPositionAsSelectionChanges()
        {
            Assert.NotNull(EditorStatusStrip);
            CaretPositionStatusLabel = EditorStatusStrip.Items["CaretPositionStatusLabel"] as ToolStripStatusLabel;

            MainRichTextBox.Text = "Lorem Ipsum";
            MainRichTextBox.SelectionStart = MainRichTextBox.Text.Length;
            Assert.Equal("Ln: 1, Col: 12", CaretPositionStatusLabel.Text);

            MainRichTextBox.Text = "Lorem ipsum dolor sit \namet, consectetur adipiscing \nelit.";
            MainRichTextBox.SelectionStart = MainRichTextBox.Text.Length;

            Assert.Equal("Ln: 3, Col: 6", CaretPositionStatusLabel.Text);
        }

        [Fact]
        public void ShouldBeAbleToSetCaretBackToTheStartAndUpdateStatus()
        {
            Assert.NotNull(EditorStatusStrip);
            CaretPositionStatusLabel = EditorStatusStrip.Items["CaretPositionStatusLabel"] as ToolStripStatusLabel;

            MainRichTextBox.Text = "Lorem ipsum dolor sit \namet, consectetur adipiscing \nelit.";
            ToStartButton.PerformClick();

            Assert.Equal("Ln: 1, Col: 1", CaretPositionStatusLabel.Text);
        }

        [Fact]
        public void ShouldBeAbleToSetCaretToTheEndAndUpdateStatus()
        {
            Assert.NotNull(EditorStatusStrip);
            CaretPositionStatusLabel = EditorStatusStrip.Items["CaretPositionStatusLabel"] as ToolStripStatusLabel;

            MainRichTextBox.Text = "Lorem ipsum dolor sit \namet, consectetur adipiscing";
            ToEndButton.PerformClick();

            Assert.Equal("Ln: 2, Col: 29", CaretPositionStatusLabel.Text);
        }

        [Fact]
        public void ShouldUpdateProgressBarAsUserTypes()
        {
            Assert.NotNull(EditorStatusStrip);
            TextLengthProgressBar = EditorStatusStrip.Items["TextLengthProgressBar"] as ToolStripProgressBar;

            MainRichTextBox.Text = "Lorem ipsum dolor sit \namet";
            Assert.Equal(MainRichTextBox.Text.Length, TextLengthProgressBar.Value);

            MainRichTextBox.Text = "Lorem ipsum dolor sit \namet, consectetur adipiscing";
            Assert.Equal(MainRichTextBox.Text.Length, TextLengthProgressBar.Value);
        }
    }
}