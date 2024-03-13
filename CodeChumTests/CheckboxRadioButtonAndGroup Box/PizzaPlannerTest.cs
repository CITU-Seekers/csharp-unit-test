namespace CodeChum.Tests
{
    public class PizzaPlannerTest
    {
        PizzaPlanner? form;
        CheckBox? pepperoniCheckBox;
        CheckBox? mushroomCheckBox;
        CheckBox? onionCheckBox;
        CheckBox? baconCheckBox;
        CheckBox? extraCheeseCheckBox;
        RadioButton? thinCrustRadioButton;
        RadioButton? handTossedRadioButton;
        RadioButton? deepDishRadioButton;
        Button? orderButton;
        Label? totalLabel;
        TextBox? pizzaTextBox;

        public PizzaPlannerTest()
        {
            form = new PizzaPlanner();
            form.Show();
            pepperoniCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "pepperoniCheckBox", true);
            mushroomCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "mushroomCheckBox", true);
            onionCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "onionCheckBox", true);
            baconCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "baconCheckBox", true);
            extraCheeseCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "extraCheeseCheckBox", true);
            thinCrustRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "thinCrustRadioButton", true);
            handTossedRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "handTossedRadioButton", true);
            deepDishRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "deepDishRadioButton", true);
            pizzaTextBox = (TextBox)TestUtils.GetControlNamed(form, "pizzaTextBox", true);
            orderButton = (Button)TestUtils.GetControlNamed(form, "orderButton", true);
            totalLabel = (Label)TestUtils.GetControlNamed(form, "totalLabel", true);
        }

        [Fact]
        // Description: Should have all controls `pepperoniCheckBox`, `mushroomCheckBox`, `onionCheckBox`, `baconCheckBox`, `extraCheeseCheckBox`, `thinCrustRadioButton`, `handTossedRadioButton`, `deepDishRadioButton`, `orderButton`, `totalLabel`, and `pizzaTextBox`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(pepperoniCheckBox);
            Assert.NotNull(mushroomCheckBox);
            Assert.NotNull(onionCheckBox);
            Assert.NotNull(baconCheckBox);
            Assert.NotNull(extraCheeseCheckBox);
            Assert.NotNull(thinCrustRadioButton);
            Assert.NotNull(handTossedRadioButton);
            Assert.NotNull(deepDishRadioButton);
            Assert.NotNull(orderButton);
            Assert.NotNull(totalLabel);
            Assert.NotNull(pizzaTextBox);
        }

        [Fact]
        // Description: Should show "Total Cost: $675.00" when `pepperoniCheckBox`, `extraCheeseCheckBox`, `thinCrustRadioButton`, and `pizzaTextBox` are checked and `orderButton` is clicked.
        public void ShouldCalculateTotalPrice()
        {
            double expectedTotalPrice = 675;

            pepperoniCheckBox.Checked = true;
            extraCheeseCheckBox.Checked = true;
            thinCrustRadioButton.Checked = true;
            pizzaTextBox.Text = "3";
            orderButton.PerformClick();

            Assert.Equal($"Total Cost: {expectedTotalPrice:C}", totalLabel.Text);
        }

        [Fact]
        // Description: Should show "Total Cost: $300.00" when `thinCrustRadioButton` is checked, `pizzaTextBox` is set to 3 and `orderButton` is clicked.
        public void ShouldCalculateTotalPriceWithNoToppings()
        {
            double expectedTotalPrice = 300;

            thinCrustRadioButton.Checked = true;
            pizzaTextBox.Text = "3";
            orderButton.PerformClick();

            Assert.Equal($"Total Cost: {expectedTotalPrice:C}", totalLabel.Text);
        }

        [Fact]
        // Description: Should show "Total Cost: $600.00" when `pepperoniCheckBox`, `mushroomCheckBox`, `onionCheckBox`, `baconCheckBox`, `extraCheeseCheckBox` are checked and `pizzaTextBox` is set to 2 and `orderButton` is clicked.
        public void ShouldCalculateTotalPriceWithNoCrust()
        {
            double expectedTotalPrice = 600;

            pepperoniCheckBox.Checked = true;
            mushroomCheckBox.Checked = true;
            onionCheckBox.Checked = true;
            baconCheckBox.Checked = true;
            extraCheeseCheckBox.Checked = true;
            pizzaTextBox.Text = "2";
            orderButton.PerformClick();

            Assert.Equal($"Total Cost: {expectedTotalPrice:C}", totalLabel.Text);
        }

        [Fact]
        // Description: Should show "Total Cost: $0.00" when `pizzaTextBox` is set to 2 and `orderButton` is clicked.
        public void ShouldCalculateTotalPriceWithNoToppingsAndNoCrust()
        {
            double expectedTotalPrice = 0;
            
            pizzaTextBox.Text = "2";
            orderButton.PerformClick();

            Assert.Equal($"Total Cost: {expectedTotalPrice:C}", totalLabel.Text);
        }
    }
}
