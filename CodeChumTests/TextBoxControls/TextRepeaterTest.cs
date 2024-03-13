namespace CodeChum.Tests
{
    public class TextRepeaterTests
    {
        TextRepeater? form;
        TextBox? inputTextBox, numberTextBox, resultTextBox;
        Button? displayTextButton;

        public TextRepeaterTests()
        {
            form = new TextRepeater();
            form.Show();
            inputTextBox = (TextBox)TestUtils.GetControlNamed(form, "inputTextBox", true);
            numberTextBox = (TextBox)TestUtils.GetControlNamed(form, "numberTextBox", true);
            resultTextBox = (TextBox)TestUtils.GetControlNamed(form, "resultTextBox", true);
            displayTextButton = (Button)TestUtils.GetControlNamed(form, "displayTextButton", true);
        }

        [Fact]
        // Description: Should have all the controls `inputTextBox`, `numberTextBox`, `resultTextBox` and `displayTextButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(inputTextBox);
            Assert.NotNull(numberTextBox);
            Assert.NotNull(resultTextBox);
            Assert.NotNull(displayTextButton);
        }

        [Fact]
        // Description: Should display the text in `inputTextBox` n times entered in `numberTextBox` in `resultTextBox` on clicking `displayTextButton`.
        public void ShouldRepeatTextCorrectOnClickDisplayTextButton()
        {
            string expected = "CodeChum CodeChum CodeChum";
            string codechum = "CodeChum";
            int count = 3;

            inputTextBox.Text = codechum;
            numberTextBox.Text = count.ToString();
            displayTextButton.PerformClick();

            Assert.Equal(resultTextBox.Text, expected);
        }
    }
}