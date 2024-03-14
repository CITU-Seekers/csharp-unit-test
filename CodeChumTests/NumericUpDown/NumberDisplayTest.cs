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
        // Description: Should have all the controls `intervalNumericUpDown` and `incrementTextBox`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(intervalNumericUpDown);
            Assert.NotNull(incrementTextBox);
        }

        [Fact]
        // Description: Should change increment value of `intervalNumericUpDown` according to the number in the `incrementTextBox`.
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