namespace CodeChum.Tests
{
    public class PizzaPlannerTest
    {
        PizzaPlanner? form;
        CheckBox? PepperoniCheckBox;
        CheckBox? MushroomCheckBox;
        CheckBox? OnionCheckBox;
        CheckBox? BaconCheckBox;
        CheckBox? ExtraCheeseCheckBox;
        RadioButton? ThinCrustRadioButton;
        RadioButton? HandTossedRadioButton;
        RadioButton? DeepDishRadioButton;
        Button? btnOrder;
        Label? lblTotal;
        TextBox? PizzaNum;

        public PizzaPlannerTest()
        {
            form = new PizzaPlanner();
            form.Visible = true;
            PepperoniCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "PepperoniCheckBox", true);
            MushroomCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "MushroomCheckBox", true);
            OnionCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "OnionCheckBox", true);
            BaconCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "BaconCheckBox", true);
            ExtraCheeseCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "ExtraCheeseCheckBox", true);
            ThinCrustRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "ThinCrustRadioButton", true);
            HandTossedRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "HandTossedRadioButton", true);
            DeepDishRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "DeepDishRadioButton", true);
            PizzaNum = (TextBox)TestUtils.GetControlNamed(form, "PizzaNum", true);
            btnOrder = (Button)TestUtils.GetControlNamed(form, "btnOrder", true);
            lblTotal = (Label)TestUtils.GetControlNamed(form, "lblTotal", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(PepperoniCheckBox);
            Assert.NotNull(MushroomCheckBox);
            Assert.NotNull(OnionCheckBox);
            Assert.NotNull(BaconCheckBox);
            Assert.NotNull(ExtraCheeseCheckBox);
            Assert.NotNull(ThinCrustRadioButton);
            Assert.NotNull(HandTossedRadioButton);
            Assert.NotNull(DeepDishRadioButton);
            Assert.NotNull(btnOrder);
            Assert.NotNull(lblTotal);
            Assert.NotNull(PizzaNum);
        }

        [Fact]
        public void ShouldCalculateTotalPrice()
        {   
            PepperoniCheckBox.Checked = true;
            ExtraCheeseCheckBox.Checked = true;
            ThinCrustRadioButton.Checked = true;
            PizzaNum.Text = "3";
            btnOrder.PerformClick();

            double expectedTotalPrice = 675;

            Assert.Equal($"Total Cost: {expectedTotalPrice:C}", lblTotal.Text);
        }

        [Fact]
        public void ShouldCalculateTotalPriceWithNoToppings()
        {
            // Arrange
            double expectedTotalPrice = 0;

            // Act
            ThinCrustRadioButton.Checked = true;
            expectedTotalPrice += 100;
            PizzaNum.Text = "3";
            expectedTotalPrice *= 3;
            btnOrder.PerformClick();

            // Assert
            Assert.Equal($"Total Cost: {expectedTotalPrice:C}", lblTotal.Text);
        }

        [Fact]
        public void ShouldCalculateTotalPriceWithNoCrust()
        {
            // Arrange
            double expectedTotalPrice = 0;

            // Act
            PepperoniCheckBox.Checked = true;
            expectedTotalPrice += 100;
            MushroomCheckBox.Checked = true;
            expectedTotalPrice += 50;
            OnionCheckBox.Checked = true;
            expectedTotalPrice += 50;
            BaconCheckBox.Checked = true;
            expectedTotalPrice += 75;
            ExtraCheeseCheckBox.Checked = true;
            expectedTotalPrice += 25;
            PizzaNum.Text = "2";
            expectedTotalPrice *= 2;
            btnOrder.PerformClick();


            // Assert
            Assert.Equal($"Total Cost: {expectedTotalPrice:C}", lblTotal.Text);
        }

        [Fact]
        public void ShouldCalculateTotalPriceWithNoToppingsAndNoCrust()
        {
            // Arrange
            PizzaNum.Text = "2";
            double expectedTotalPrice = 0;

            // Act
            btnOrder.PerformClick();

            // Assert
            Assert.Equal($"Total Cost: {expectedTotalPrice:C}", lblTotal.Text);
        }
    }
}
