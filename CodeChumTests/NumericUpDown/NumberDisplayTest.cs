namespace CodeChum.Tests
{
    public class NumberDisplayTests
    {
        NumberDisplay? form;
        NumericUpDown? NumericUpDown;
        TextBox? IncrementTextBox;

        public NumberDisplayTests()
        {
            form = new NumberDisplay();
            NumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "NumericControl", true);
            IncrementTextBox = (TextBox)TestUtils.GetControlNamed(form, "IncrementTextBox", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(NumericUpDown);
            Assert.NotNull(IncrementTextBox);
        }

        [Fact]
        public void ShouldChangeIncrementOnTextChange()
        {
            string number = "20";
            IncrementTextBox.Text = number;
            NumericUpDown.Value = 0;

            NumericUpDown.UpButton();

            Assert.Equal(Convert.ToInt32(number), (int)(NumericUpDown.Value));
        }

    }
}