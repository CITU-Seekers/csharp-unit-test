namespace CodeChum.Tests
{
    public class NumberDisplayTests
    {
        NumberDisplay? form;
        NumericUpDown? intervalNumericUpDown;
        TextBox? incrementTextBox;

        public NumberDisplayTests()
        {
            form = new NumberDisplay();
            intervalNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "intervalNumericUpDown", true);
            incrementTextBox = (TextBox)TestUtils.GetControlNamed(form, "incrementTextBox", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(intervalNumericUpDown);
            Assert.NotNull(incrementTextBox);
        }

        [Fact]
        public void ShouldChangeIncrementOnTextChange()
        {
            string number = "20";
            incrementTextBox.Text = number;
            intervalNumericUpDown.Value = 0;

            intervalNumericUpDown.UpButton();

            Assert.Equal(Convert.ToInt32(number), (int)(intervalNumericUpDown.Value));
        }

    }
}