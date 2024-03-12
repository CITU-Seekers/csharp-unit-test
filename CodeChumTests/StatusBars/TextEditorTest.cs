namespace CodeChum.Tests
{
    public class TextEditorTests
    {
        TextEditor? form;
        RichTextBox? mainRichTextBox;
        Button? toStartButton, toEndButton;
        StatusStrip? editorStatusStrip;
        ToolStripProgressBar? textLengthProgressBar;
        ToolStripStatusLabel? caretPositionStatusLabel;

        public TextEditorTests()
        {
            form = new TextEditor();
            form.Show();
            mainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "mainRichTextBox", true);
            toStartButton = (Button)TestUtils.GetControlNamed(form, "toStartButton", true);
            toEndButton = (Button)TestUtils.GetControlNamed(form, "toEndButton", true);
            editorStatusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "editorStatusStrip", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainRichTextBox);
            Assert.NotNull(toStartButton);
            Assert.NotNull(toEndButton);
        }

        [Fact]
        public void ShouldHaveStatusStripAndAllStatusStripItems()
        {
            Assert.NotNull(editorStatusStrip);

            textLengthProgressBar = editorStatusStrip.Items["textLengthProgressBar"] as ToolStripProgressBar;
            Assert.NotNull(textLengthProgressBar);

            caretPositionStatusLabel = editorStatusStrip.Items["caretPositionStatusLabel"] as ToolStripStatusLabel;
            Assert.NotNull(caretPositionStatusLabel);
        }

        [Fact]
        public void ShouldHaveCorrectStartingValuesForStatusStrip()
        {
            Assert.NotNull(editorStatusStrip);

            caretPositionStatusLabel = editorStatusStrip.Items["caretPositionStatusLabel"] as ToolStripStatusLabel;
            Assert.Equal("Ln: 1, Col: 1", caretPositionStatusLabel.Text);

            textLengthProgressBar = editorStatusStrip.Items["textLengthProgressBar"] as ToolStripProgressBar;
            Assert.Equal(0, textLengthProgressBar.Value);
        }

        [Fact]
        public void ShouldUpdateCaretPositionAsSelectionChanges()
        {
            Assert.NotNull(editorStatusStrip);
            caretPositionStatusLabel = editorStatusStrip.Items["caretPositionStatusLabel"] as ToolStripStatusLabel;

            mainRichTextBox.Text = "Lorem Ipsum";
            mainRichTextBox.SelectionStart = mainRichTextBox.Text.Length;
            Assert.Equal("Ln: 1, Col: 12", caretPositionStatusLabel.Text);

            mainRichTextBox.Text = "Lorem ipsum dolor sit \namet, consectetur adipiscing \nelit.";
            mainRichTextBox.SelectionStart = mainRichTextBox.Text.Length;

            Assert.Equal("Ln: 3, Col: 6", caretPositionStatusLabel.Text);
        }

        [Fact]
        public void ShouldBeAbleToSetCaretBackToTheStartAndUpdateStatus()
        {
            Assert.NotNull(editorStatusStrip);
            caretPositionStatusLabel = editorStatusStrip.Items["caretPositionStatusLabel"] as ToolStripStatusLabel;

            mainRichTextBox.Text = "Lorem ipsum dolor sit \namet, consectetur adipiscing \nelit.";
            toStartButton.PerformClick();

            Assert.Equal("Ln: 1, Col: 1", caretPositionStatusLabel.Text);
        }

        [Fact]
        public void ShouldBeAbleToSetCaretToTheEndAndUpdateStatus()
        {
            Assert.NotNull(editorStatusStrip);
            caretPositionStatusLabel = editorStatusStrip.Items["caretPositionStatusLabel"] as ToolStripStatusLabel;

            mainRichTextBox.Text = "Lorem ipsum dolor sit \namet, consectetur adipiscing";
            toEndButton.PerformClick();

            Assert.Equal("Ln: 2, Col: 29", caretPositionStatusLabel.Text);
        }

        [Fact]
        public void ShouldUpdateProgressBarAsUserTypes()
        {
            Assert.NotNull(editorStatusStrip);
            textLengthProgressBar = editorStatusStrip.Items["textLengthProgressBar"] as ToolStripProgressBar;

            mainRichTextBox.Text = "Lorem ipsum dolor sit \namet";
            Assert.Equal(mainRichTextBox.Text.Length, textLengthProgressBar.Value);

            mainRichTextBox.Text = "Lorem ipsum dolor sit \namet, consectetur adipiscing";
            Assert.Equal(mainRichTextBox.Text.Length, textLengthProgressBar.Value);
        }
    }
}