namespace CodeChum.Tests
{
    public class CounterTests
    {
        Counter? form;
        Label? counterLabel;
        Button? counterButton;

        public CounterTests()
        {
            form = new Counter();
            form.Show();
            counterLabel = (Label)TestUtils.GetControlNamed(form, "counterLabel", true);
            counterButton = (Button)TestUtils.GetControlNamed(form, "counterButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(counterLabel);
            Assert.NotNull(counterButton);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultValue()
        {
            Assert.Equal("0", counterLabel.Text);
        }

        [Fact]
        public void ShouldIncrementOnClickCounterButton()
        {
            counterLabel.Text = "5";
            string expected = "6";

            counterButton.PerformClick();

            Assert.Equal(expected, counterLabel.Text);
        }
    }
}