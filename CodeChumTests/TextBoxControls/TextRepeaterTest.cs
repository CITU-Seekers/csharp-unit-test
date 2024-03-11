namespace CodeChum.Tests
{
    public class TextRepeaterTests
    {
        TextRepeater? form;
        TextBox? InputTextBox, NumberTextBox, ResultTextBox;
        Button? DisplayTextButton;

        public TextRepeaterTests()
        {
            form = new TextRepeater();
            form.Show();
            InputTextBox = (TextBox)TestUtils.GetControlNamed(form, "InputTextBox", true);
            NumberTextBox = (TextBox)TestUtils.GetControlNamed(form, "NumberTextBox", true);
            ResultTextBox = (TextBox)TestUtils.GetControlNamed(form, "ResultTextBox", true);
            DisplayTextButton = (Button)TestUtils.GetControlNamed(form, "DisplayTextButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(InputTextBox);
            Assert.NotNull(NumberTextBox);
            Assert.NotNull(ResultTextBox);
            Assert.NotNull(DisplayTextButton);
        }

        [Fact]
        public void ShouldRepeatTextCorrectOnClickDisplayTextButton()
        {
            string expected = "CodeChum CodeChum CodeChum";
            string codechum = "CodeChum";
            int count = 3;

            InputTextBox.Text = codechum;
            NumberTextBox.Text = count.ToString();
            DisplayTextButton.PerformClick();

            Assert.Equal(ResultTextBox.Text, expected);
        }
    }
}