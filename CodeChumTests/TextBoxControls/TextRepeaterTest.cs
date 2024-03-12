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
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(inputTextBox);
            Assert.NotNull(numberTextBox);
            Assert.NotNull(resultTextBox);
            Assert.NotNull(displayTextButton);
        }

        [Fact]
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