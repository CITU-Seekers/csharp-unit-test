namespace CodeChum.Tests
{
    public class CounterTests
    {
        Counter? form;
        Label? CounterLabel;
        Button? CounterButton;

        public CounterTests()
        {
            form = new Counter();
            form.Show();
            CounterLabel = (Label)TestUtils.GetControlNamed(form, "CounterLabel", true);
            CounterButton = (Button)TestUtils.GetControlNamed(form, "CounterButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(CounterLabel);
            Assert.NotNull(CounterButton);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultValue()
        {
            Assert.Equal("0", CounterLabel.Text);
        }

        [Fact]
        public void ShouldIncrementOnClickCounterButton()
        {
            CounterLabel.Text = "5";
            string expected = "6";

            CounterButton.PerformClick();

            Assert.Equal(expected, CounterLabel.Text);
        }
    }
}