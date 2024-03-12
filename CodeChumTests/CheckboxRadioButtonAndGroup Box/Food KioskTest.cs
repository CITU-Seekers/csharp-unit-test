namespace CodeChum.Tests
{
    public class FoodKioskTests
    {
        FoodKiosk? form;
        CheckBox? pizzaCheckBox, burgerCheckBox, teaCheckBox;
        RadioButton? noneRadioButton, fiveRadioButton, tenRadioButton;
        Button? orderButton;
        Label? totalCostLabel;
        double pizzaPrice = 100, burgerPrice = 80, teaPrice = 50;
        public FoodKioskTests()
        {
            form = new FoodKiosk();
            form.Show();
            pizzaCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "pizzaCheckBox", true);
            burgerCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "burgerCheckBox", true);
            teaCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "teaCheckBox", true);
            noneRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "noneRadioButton", true);
            fiveRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "fiveRadioButton", true);
            tenRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "tenRadioButton", true);
            orderButton = (Button)TestUtils.GetControlNamed(form, "orderButton", true);
            totalCostLabel = (Label)TestUtils.GetControlNamed(form, "totalCostLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(pizzaCheckBox);
            Assert.NotNull(burgerCheckBox);
            Assert.NotNull(teaCheckBox);
            Assert.NotNull(noneRadioButton);
            Assert.NotNull(fiveRadioButton);
            Assert.NotNull(tenRadioButton);
            Assert.NotNull(orderButton);
            Assert.NotNull(totalCostLabel);
        }

        [Fact]
        public void ShouldComputeCorrectTotalNoDiscount()
        {
            double total = pizzaPrice + burgerPrice + teaPrice;
            string expected = "Total: Php " + total.ToString("F");
            pizzaCheckBox.Checked = true;
            burgerCheckBox.Checked = true;
            teaCheckBox.Checked = true;
            noneRadioButton.PerformClick();

            orderButton.PerformClick();

            Assert.Equal(expected, totalCostLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectTotalFiveDiscount()
        {
            double total = (pizzaPrice + burgerPrice) * 0.95;
            string expected = "Total: Php " + total.ToString("F");
            pizzaCheckBox.Checked = true;
            burgerCheckBox.Checked = true;
            fiveRadioButton.PerformClick();

            orderButton.PerformClick();

            Assert.Equal(expected, totalCostLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectTotalTenDiscount()
        {
            double total = (pizzaPrice + teaPrice) * 0.9;
            string expected = "Total: Php " + total.ToString("F");
            pizzaCheckBox.Checked = true;
            teaCheckBox.Checked = true;
            tenRadioButton.PerformClick();

            orderButton.PerformClick();

            Assert.Equal(expected, totalCostLabel.Text);
        }
    }
}