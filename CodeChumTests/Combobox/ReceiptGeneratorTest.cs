namespace CodeChum.Tests
{
    public class ReceiptGeneratorTests
    {
        ReceiptGenerator? form;
        CheckBox? shoesCheckBox, pantsCheckBox, shirtCheckBox;
        ComboBox? paymentMethodComboBox;
        RadioButton? defaultRadioButton, specialRadioButton;
        Button? generateButton;
        Label? receiptLabel;
        double shoesPrice = 200, pantsPrice = 150, shirtPrice = 120;

        public ReceiptGeneratorTests()
        {
            form = new ReceiptGenerator();
            form.Show();
            shoesCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "shoesCheckBox", true);
            pantsCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "pantsCheckBox", true);
            shirtCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "shirtCheckBox", true);
            paymentMethodComboBox = (ComboBox)TestUtils.GetControlNamed(form, "paymentMethodComboBox", true);
            defaultRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "defaultRadioButton", true);
            specialRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "specialRadioButton", true);
            generateButton = (Button)TestUtils.GetControlNamed(form, "generateButton", true);
            receiptLabel = (Label)TestUtils.GetControlNamed(form, "receiptLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(shoesCheckBox);
            Assert.NotNull(pantsCheckBox);
            Assert.NotNull(shirtCheckBox);
            Assert.NotNull(paymentMethodComboBox);
            Assert.NotNull(defaultRadioButton);
            Assert.NotNull(specialRadioButton);
            Assert.NotNull(generateButton);
            Assert.NotNull(receiptLabel);
        }

        [Fact]
        public void ShouldHaveAllInstructedPaymentMethods()
        {
            Assert.True(paymentMethodComboBox.Items.Contains("Cash"));
            Assert.True(paymentMethodComboBox.Items.Contains("Credit Card"));
            Assert.True(paymentMethodComboBox.Items.Contains("Debit Card"));
        }

        [Fact]
        public void ShouldHaveCorrectTotalAndItemsWithNoDiscount()
        {
            shirtCheckBox.Checked = true;
            pantsCheckBox.Checked = true;
            shoesCheckBox.Checked = true;
            paymentMethodComboBox.SelectedIndex = paymentMethodComboBox.Items.IndexOf("Cash");
            double total = shirtPrice + pantsPrice + shoesPrice;
            string receiptText = "Welcome to Cody Store!\n" +
                "Items: " + "Shoes, Pants, Shirt" + "\n" +
                "Payment Method: " + "Cash" + "\n" +
                "Total Cost: Php " + total.ToString("F");

            generateButton.PerformClick();

            Assert.Equal(receiptText, receiptLabel.Text);
        }

        [Fact]
        public void ShouldHaveCorrectTotalAndItemsWithDefaultDiscount()
        {
            shoesCheckBox.Checked = true;
            defaultRadioButton.Checked = true;
            paymentMethodComboBox.SelectedIndex = paymentMethodComboBox.Items.IndexOf("Debit Card");
            double total = shoesPrice;
            string receiptText = "Welcome to Cody Store!\n" +
                "Items: " + "Shoes" + "\n" +
                "Payment Method: " + "Debit Card" + "\n" +
                "Total Cost: Php " + total.ToString("F");

            generateButton.PerformClick();

            Assert.Equal(receiptText, receiptLabel.Text);
        }

        [Fact]
        public void ShouldHaveCorrectTotalAndItemsWithSpecialDiscount()
        {
            shirtCheckBox.Checked = true;
            specialRadioButton.Checked = true;
            paymentMethodComboBox.SelectedIndex = paymentMethodComboBox.Items.IndexOf("Credit Card");
            double total = shirtPrice * 0.85;
            string receiptText = "Welcome to Cody Store!\n" +
                "Items: " + "Shirt" + "\n" +
                "Payment Method: " + "Credit Card" + "\n" +
                "Total Cost: Php " + total.ToString("F");

            generateButton.PerformClick();

            Assert.Equal(receiptText, receiptLabel.Text);
        }
    }
}