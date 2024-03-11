namespace CodeChum.Tests
{
    public class TicketCounterTest
    {
        TicketCounter? form;
        NumericUpDown? numericUpDownZoo;
        NumericUpDown? numericUpDownRollerCoaster;
        NumericUpDown? numericUpDownWaterSlide;
        Label? lblTotal;
        Button? btnCalculate;

        public TicketCounterTest()
        {
            form = new TicketCounter();
            form.Visible = true;
            numericUpDownZoo = (NumericUpDown)TestUtils.GetControlNamed(form, "numericUpDownZoo", true);
            numericUpDownRollerCoaster = (NumericUpDown)TestUtils.GetControlNamed(form, "numericUpDownRollerCoaster", true);
            numericUpDownWaterSlide = (NumericUpDown)TestUtils.GetControlNamed(form, "numericUpDownWaterSlide", true);
            lblTotal = (Label)TestUtils.GetControlNamed(form, "lblTotal", true);
            btnCalculate = (Button)TestUtils.GetControlNamed(form, "btnCalculate", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(numericUpDownZoo);
            Assert.NotNull(numericUpDownRollerCoaster);
            Assert.NotNull(numericUpDownWaterSlide);
            Assert.NotNull(lblTotal);
            Assert.NotNull(btnCalculate);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultValues()
        {
            Assert.Equal(0, numericUpDownZoo.Value);
            Assert.Equal(0, numericUpDownRollerCoaster.Value);
            Assert.Equal(0, numericUpDownWaterSlide.Value);
            Assert.Equal("Total Cost: $0.00", lblTotal.Text);
        }

        [Fact]
        public void ShouldCalculateTotalCost()
        {
            numericUpDownZoo.Value = 2;
            numericUpDownRollerCoaster.Value = 3;
            numericUpDownWaterSlide.Value = 1;

            btnCalculate.PerformClick();

            Assert.Equal("Total Cost: $97.50", lblTotal.Text);
        }

    }
}
