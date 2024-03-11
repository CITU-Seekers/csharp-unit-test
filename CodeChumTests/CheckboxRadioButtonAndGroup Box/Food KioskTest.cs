namespace CodeChum.Tests
{
    public class FoodKioskTests
    {
        FoodKiosk? form;
        CheckBox? PizzaCheckBox, BurgerCheckBox, TeaCheckBox;
        RadioButton? NoneRadioButton, FiveRadioButton, TenRadioButton;
        Button? OrderButton;
        Label? TotalCostLabel;
        double pizzaPrice = 100, burgerPrice = 80, teaPrice = 50;
        public FoodKioskTests()
        {
            form = new FoodKiosk();
            form.Show();
            PizzaCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "PizzaCheckBox", true);
            BurgerCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "BurgerCheckBox", true);
            TeaCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "TeaCheckBox", true);
            NoneRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "NoneRadioButton", true);
            FiveRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "FiveRadioButton", true);
            TenRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "TenRadioButton", true);
            OrderButton = (Button)TestUtils.GetControlNamed(form, "OrderButton", true);
            TotalCostLabel = (Label)TestUtils.GetControlNamed(form, "TotalCostLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(PizzaCheckBox);
            Assert.NotNull(BurgerCheckBox);
            Assert.NotNull(TeaCheckBox);
            Assert.NotNull(NoneRadioButton);
            Assert.NotNull(FiveRadioButton);
            Assert.NotNull(TenRadioButton);
            Assert.NotNull(OrderButton);
            Assert.NotNull(TotalCostLabel);
        }

        [Fact]
        public void ShouldComputeCorrectTotalNoDiscount()
        {
            double total = pizzaPrice + burgerPrice + teaPrice;
            string expected = "Total: Php " + total.ToString("F");
            PizzaCheckBox.Checked = true;
            BurgerCheckBox.Checked = true;
            TeaCheckBox.Checked = true;
            NoneRadioButton.PerformClick();

            OrderButton.PerformClick();

            Assert.Equal(expected, TotalCostLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectTotalFiveDiscount()
        {
            double total = (pizzaPrice + burgerPrice) * 0.95;
            string expected = "Total: Php " + total.ToString("F");
            PizzaCheckBox.Checked = true;
            BurgerCheckBox.Checked = true;
            FiveRadioButton.PerformClick();

            OrderButton.PerformClick();

            Assert.Equal(expected, TotalCostLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectTotalTenDiscount()
        {
            double total = (pizzaPrice + teaPrice) * 0.9;
            string expected = "Total: Php " + total.ToString("F");
            PizzaCheckBox.Checked = true;
            TeaCheckBox.Checked = true;
            TenRadioButton.PerformClick();

            OrderButton.PerformClick();

            Assert.Equal(expected, TotalCostLabel.Text);
        }
    }
}