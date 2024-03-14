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
        // Description: Should have all the controls `displayLabel`, `inputTextBox` and `displayTextButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(displayLabel);
            Assert.NotNull(inputTextBox);
            Assert.NotNull(displayTextButton);
        }

        [Fact]
        // Description: Should have an empty default value in `displayLabel`.
        public void ShouldHaveEmptyDefaultValue()
        {
            Assert.Equal("", displayLabel.Text);
        }

        [Fact]
        // Description: Should display `inputTextBox` text to `displayLabel` on click of `displayTextButton`.
        public void ShouldDisplayTextBoxTextToLabelOnClickDisplayTextButton()
        {
            string expected = "Hello World!";

            inputTextBox.Text = expected;
            displayTextButton.PerformClick();

            Assert.Equal(expected, displayLabel.Text);
        }
    }
}