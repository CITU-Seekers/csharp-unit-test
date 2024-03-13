namespace CodeChum.Tests
{
    public class TicketCounterTest
    {
        TicketCounter? form;
        NumericUpDown? zooNumericUpDown;
        NumericUpDown? rollerCoasterNumericUpDown;
        NumericUpDown? waterSlideNumericUpDown;
        Label? totalLabel;
        Button? calculateButton;

        public TicketCounterTest()
        {
            form = new TicketCounter();
            form.Visible = true;
            zooNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "zooNumericUpDown", true);
            rollerCoasterNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "rollerCoasterNumericUpDown", true);
            waterSlideNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "waterSlideNumericUpDown", true);
            totalLabel = (Label)TestUtils.GetControlNamed(form, "totalLabel", true);
            calculateButton = (Button)TestUtils.GetControlNamed(form, "calculateButton", true);
        }

        [Fact]
        // Description: Should have all the controls `zooNumericUpDown`, `rollerCoasterNumericUpDown`, `waterSlideNumericUpDown`, `totalLabel`, and `calculateButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(zooNumericUpDown);
            Assert.NotNull(rollerCoasterNumericUpDown);
            Assert.NotNull(waterSlideNumericUpDown);
            Assert.NotNull(totalLabel);
            Assert.NotNull(calculateButton);
        }

        [Fact]
        // Description: Should have text "Total Cost: $0.00" in `totalLabel` when the form is loaded and `0` is set to `zooNumericUpDown`, `rollerCoasterNumericUpDown`, and `waterSlideNumericUpDown`.
        public void ShouldHaveCorrectDefaultValues()
        {
            Assert.Equal(0, zooNumericUpDown.Value);
            Assert.Equal(0, rollerCoasterNumericUpDown.Value);
            Assert.Equal(0, waterSlideNumericUpDown.Value);
            Assert.Equal("Total Cost: $0.00", totalLabel.Text);
        }

        [Fact]
        // Description: Should have text "Total Cost: $97.50" in `totalLabel` when `2` is set to `zooNumericUpDown`, `3` is set to `rollerCoasterNumericUpDown`, and `1` is set to `waterSlideNumericUpDown`.
        public void ShouldCalculateTotalCost()
        {
            zooNumericUpDown.Value = 2;
            rollerCoasterNumericUpDown.Value = 3;
            waterSlideNumericUpDown.Value = 1;

            calculateButton.PerformClick();

            Assert.Equal("Total Cost: $97.50", totalLabel.Text);
        }

    }
}
