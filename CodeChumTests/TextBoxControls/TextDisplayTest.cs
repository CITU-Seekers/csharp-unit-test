namespace CodeChum.Tests
{
    public class TextDisplayTests
    {
        TextDisplay? form;
        Label? displayLabel;
        TextBox? inputTextBox;
        Button? displayTextButton;

        public TextDisplayTests()
        {
            form = new TextDisplay();
            form.Show();
            displayLabel = (Label)TestUtils.GetControlNamed(form, "displayLabel", true);
            inputTextBox = (TextBox)TestUtils.GetControlNamed(form, "inputTextBox", true);
            displayTextButton = (Button)TestUtils.GetControlNamed(form, "displayTextButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(displayLabel);
            Assert.NotNull(inputTextBox);
            Assert.NotNull(displayTextButton);
        }

        [Fact]
        public void ShouldHaveEmptyDefaultValue()
        {
            Assert.Equal("", displayLabel.Text);
        }

        [Fact]
        public void ShouldDisplayTextBoxTextToLabelOnClickDisplayTextButton()
        {
            string expected = "Hello World!";

            inputTextBox.Text = expected;
            displayTextButton.PerformClick();

            Assert.Equal(expected, displayLabel.Text);
        }
    }
}