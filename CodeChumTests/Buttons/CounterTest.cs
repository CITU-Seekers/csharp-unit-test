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
        // Description: Should have all the controls `counterLabel` and `counterButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(counterLabel);
            Assert.NotNull(counterButton);
        }

        [Fact]
        // Description: Should have a default value of "0" in `counterLabel`.
        public void ShouldHaveCorrectDefaultValue()
        {
            Assert.Equal("0", counterLabel.Text);
        }

        [Fact]
        // Description: Should increment the value of `counterLabel` by 1 on click of `counterButton`.
        public void ShouldIncrementOnClickCounterButton()
        {
            counterLabel.Text = "5";
            string expected = "6";

            counterButton.PerformClick();

            Assert.Equal(expected, counterLabel.Text);
        }
    }
}