namespace CodeChum.Tests
{
    public class VendingMachineAppTest
    {
        VendingMachineApp? form;
        Panel? panel1, panel2, cashPanel3, cardPanel3, panel4;
        Button? toPanel2Button, cashToPanel4Button, cardToPanel4Button, toPanel3Button, exitButton;
        Button? backToPanel1Button, cashBackToPanel2Button, cardBackToPanel2Button;
        RadioButton? foodRadioButton, beverageRadioButton, cashRadioButton, cardRadioButton;
        ListBox? itemListBox;
        NumericUpDown? quantityNumericUpDown;
        Label? totalLabel, errorLabel;
        TextBox? cashTextBox, cardNumberTextBox, expiryDateTextBox, cvcTextBox;

        public VendingMachineAppTest()
        {
            form = new VendingMachineApp();
            form.Show();
            panel1 = (Panel)TestUtils.GetControlNamed(form, "panel1", true);
            panel2 = (Panel)TestUtils.GetControlNamed(form, "panel2", true);
            cashPanel3 = (Panel)TestUtils.GetControlNamed(form, "cashPanel3", true);
            cardPanel3 = (Panel)TestUtils.GetControlNamed(form, "cardPanel3", true);
            panel4 = (Panel)TestUtils.GetControlNamed(form, "panel4", true);
            toPanel2Button = (Button)TestUtils.GetControlNamed(form, "toPanel2Button", true);
            cashToPanel4Button = (Button)TestUtils.GetControlNamed(form, "cashToPanel4Button", true);
            cardToPanel4Button = (Button)TestUtils.GetControlNamed(form, "cardToPanel4Button", true);
            toPanel3Button = (Button)TestUtils.GetControlNamed(form, "toPanel3Button", true);
            exitButton = (Button)TestUtils.GetControlNamed(form, "exitButton", true);
            backToPanel1Button = (Button)TestUtils.GetControlNamed(form, "backToPanel1Button", true);
            cashBackToPanel2Button = (Button)TestUtils.GetControlNamed(form, "cashBackToPanel2Button", true);
            cardBackToPanel2Button = (Button)TestUtils.GetControlNamed(form, "cardBackToPanel2Button", true);
            foodRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "foodRadioButton", true);
            beverageRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "beverageRadioButton", true);
            cashRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "cashRadioButton", true);
            cardRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "cardRadioButton", true);
            itemListBox = (ListBox)TestUtils.GetControlNamed(form, "itemListBox", true);
            quantityNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "quantityNumericUpDown", true);
            totalLabel = (Label)TestUtils.GetControlNamed(form, "totalLabel", true);
            errorLabel = (Label)TestUtils.GetControlNamed(form, "errorLabel", true);
            cashTextBox = (TextBox)TestUtils.GetControlNamed(form, "cashTextBox", true);
            cardNumberTextBox = (TextBox)TestUtils.GetControlNamed(form, "cardNumberTextBox", true);
            expiryDateTextBox = (TextBox)TestUtils.GetControlNamed(form, "expiryDateTextBox", true);
            cvcTextBox = (TextBox)TestUtils.GetControlNamed(form, "cvcTextBox", true);
        }

        [Fact]
        // Description: Should have proper starting visibility of `panel1`, `panel2`, `cashPanel3`, `cardPanel3`, and `panel4`.
        public void ShouldHaveProperStartingVisibility()
        {
            Assert.True(panel1.Visible);
            Assert.False(panel2.Visible);
            Assert.False(cashPanel3.Visible);
            Assert.False(cardPanel3.Visible);
            Assert.False(panel4.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of `panel1`, `toPanel2Button`, `foodRadioButton`, `beverageRadioButton`, `itemListBox`, `quantityNumericUpDown`, and `totalLabel` when the form is loaded.
        public void ShouldHaveProperVisibilityOfControlsStarting()
        {
            Assert.True(panel1.Visible);
            Assert.True(toPanel2Button.Visible);
            Assert.True(foodRadioButton.Visible);
            Assert.True(beverageRadioButton.Visible);
            Assert.True(itemListBox.Visible);
            Assert.True(quantityNumericUpDown.Visible);
            Assert.True(totalLabel.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel1`, `panel2`, `toPanel3Button`, `backToPanel1Button`, `cashRadioButton`, and `cardRadioButton` when `toPanel2Button` is clicked.
        public void ShouldHaveProperVisibilityOfControlsToPanel2ButtonClick()
        {
            toPanel2Button.PerformClick();

            Assert.False(panel1.Visible);
            Assert.True(panel2.Visible);
            Assert.True(toPanel3Button.Visible);
            Assert.True(backToPanel1Button.Visible);
            Assert.True(cashRadioButton.Visible);
            Assert.True(cardRadioButton.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel2`, `cashPanel3`, `cashToPanel4Button`, `cashBackToPanel2Button`, and `CashTextBox` when `cashRadioButton` is checked and `toPanel2Button` is clicked then `toPanel3Button` is clicked.
        public void ShouldHaveProperVisibilityOfControlsCashToPanel3ButtonClick()
        {
            toPanel2Button.PerformClick();
            cashRadioButton.Checked = true;
            toPanel3Button.PerformClick();

            Assert.False(panel2.Visible);
            Assert.True(cashPanel3.Visible);
            Assert.True(cashToPanel4Button.Visible);
            Assert.True(cashBackToPanel2Button.Visible);
            Assert.True(cashTextBox.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel2`, `cardPanel3`, `cardToPanel4Button`, `cardBackToPanel2Button`, `cardNumberTextBox`, `expiryDateTextBox`, and `cvcTextBox` when `cardRadioButton` is checked and `toPanel2Button` is clicked then `toPanel3Button` is clicked.
        public void ShouldHaveProperVisibilityOfControlsCardToPanel3ButtonClick()
        {
            toPanel2Button.PerformClick();
            cardRadioButton.Checked = true;
            toPanel3Button.PerformClick();

            Assert.False(panel2.Visible);
            Assert.True(cardPanel3.Visible);
            Assert.True(cardToPanel4Button.Visible);
            Assert.True(cardBackToPanel2Button.Visible);
            Assert.True(cardNumberTextBox.Visible);
            Assert.True(expiryDateTextBox.Visible);
            Assert.True(cvcTextBox.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel2`, `panel4`, and `exitButton` when `toPanel2Button` is clicked then `toPanel3Button` is clicked then `cashRadioButton` is checked and `cashToPanel4Button` is clicked.
        public void ShouldHaveProperVisibilityOfControlsCardToPanel4ButtonClick()
        {
            toPanel2Button.PerformClick();
            cardRadioButton.Checked = true;
            toPanel3Button.PerformClick();
            cardToPanel4Button.PerformClick();

            Assert.False(panel2.Visible);
            Assert.False(cardPanel3.Visible);
            Assert.True(panel4.Visible);
            Assert.True(exitButton.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel2`, `panel4`, and `exitButton` when `toPanel2Button` is clicked then `toPanel3Button` is clicked then `cashRadioButton` is checked and `cashToPanel4Button` is clicked.
        public void ShouldHaveProperVisibilityOfControlsBackToPanel1ButtonClick()
        {
            toPanel2Button.PerformClick();
            backToPanel1Button.PerformClick();

            Assert.True(panel1.Visible);
            Assert.False(panel2.Visible);
            Assert.False(cashPanel3.Visible);
            Assert.False(cardPanel3.Visible);
            Assert.False(panel4.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel1`, `panel2`, `panel3`, and `panel4` when `toPanel2Button` is clicked then `toPanel3Button` is clicked then `cashRadioButton` is checked and `cashToPanel4Button` is clicked then `cashBackToPanel2Button` is clicked.
        public void ShouldHaveProperVisibilityOfControlsBackToPanel2ButtonClick()
        {
            toPanel2Button.PerformClick();
            cashRadioButton.Checked = true;
            toPanel3Button.PerformClick();
            cashBackToPanel2Button.PerformClick();

            Assert.False(panel1.Visible);
            Assert.True(panel2.Visible);
            Assert.False(cashPanel3.Visible);
            Assert.False(cardPanel3.Visible);
            Assert.False(panel4.Visible);
        }

        [Fact]
        // Description: Should have total "Total: $1.50" in `totalLabel` when `foodRadioButton` is checked, `itemListBox` is selected, and `quantityNumericUpDown` is set to `1`.
        public void ShouldCalculateTotalPriceForFood()
        {
            foodRadioButton.Checked = true;
            itemListBox.SelectedIndex = 0;
            quantityNumericUpDown.Value = 1;
            
            Assert.Equal("Total: $1.50", totalLabel.Text);
        }

        [Fact]
        // Description: Should have total "Total: $1.25" in `totalLabel` when `beverageRadioButton` is checked, `itemListBox` is selected, and `quantityNumericUpDown` is set to `1`.
        public void ShouldCalculateTotalPriceForBeverage()
        {
            beverageRadioButton.Checked = true;
            itemListBox.SelectedIndex = 0;
            quantityNumericUpDown.Value = 1;

            Assert.Equal("Total: $1.25", totalLabel.Text);
        }

        [Fact]
        // Description: Should have text "Insufficient funds!" in `errorLabel` when cash is not enough.
        public void ShouldShowErrorWhenInsufficientFunds()
        {
            foodRadioButton.Checked = true;
            itemListBox.SelectedIndex = 0;
            quantityNumericUpDown.Value = 1;
            toPanel2Button.PerformClick();
            cashRadioButton.Checked = true;
            toPanel3Button.PerformClick();
            cashTextBox.Text = "1.00";
            cashToPanel4Button.PerformClick();

            Assert.Equal("Insufficient funds!", errorLabel.Text);
        }
    }
}
