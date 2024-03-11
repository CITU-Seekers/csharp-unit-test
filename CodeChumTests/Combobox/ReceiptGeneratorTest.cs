namespace CodeChum.Tests
{
    public class ReceiptGeneratorTests
    {
        ReceiptGenerator? form;
        CheckBox? ShoesCheckBox, PantsCheckBox, ShirtCheckBox;
        ComboBox? PaymentMethodComboBox;
        RadioButton? DefaultRadioButton, SpecialRadioButton;
        Button? GenerateButton;
        Label? ReceiptLabel;
        double shoesPrice = 200, pantsPrice = 150, shirtPrice = 120;

        public ReceiptGeneratorTests()
        {
            form = new ReceiptGenerator();
            form.Show();
            ShoesCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "ShoesCheckBox", true);
            PantsCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "PantsCheckBox", true);
            ShirtCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "ShirtCheckBox", true);
            PaymentMethodComboBox = (ComboBox)TestUtils.GetControlNamed(form, "PaymentMethodComboBox", true);
            DefaultRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "DefaultRadioButton", true);
            SpecialRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "SpecialRadioButton", true);
            GenerateButton = (Button)TestUtils.GetControlNamed(form, "GenerateButton", true);
            ReceiptLabel = (Label)TestUtils.GetControlNamed(form, "ReceiptLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(ShoesCheckBox);
            Assert.NotNull(PantsCheckBox);
            Assert.NotNull(ShirtCheckBox);
            Assert.NotNull(PaymentMethodComboBox);
            Assert.NotNull(DefaultRadioButton);
            Assert.NotNull(SpecialRadioButton);
            Assert.NotNull(GenerateButton);
            Assert.NotNull(ReceiptLabel);
        }

        [Fact]
        public void ShouldHaveAllInstructedPaymentMethods()
        {
            Assert.True(PaymentMethodComboBox.Items.Contains("Cash"));
            Assert.True(PaymentMethodComboBox.Items.Contains("Credit Card"));
            Assert.True(PaymentMethodComboBox.Items.Contains("Debit Card"));
        }

        [Fact]
        public void ShouldHaveCorrectTotalAndItemsWithNoDiscount()
        {
            ShirtCheckBox.Checked = true;
            PantsCheckBox.Checked = true;
            ShoesCheckBox.Checked = true;
            PaymentMethodComboBox.SelectedIndex = PaymentMethodComboBox.Items.IndexOf("Cash");
            double total = shirtPrice + pantsPrice + shoesPrice;
            string receiptText = "Welcome to Cody Store!\n" +
                "Items: " + "Shoes, Pants, Shirt" + "\n" +
                "Payment Method: " + "Cash" + "\n" +
                "Total Cost: Php " + total.ToString("F");

            GenerateButton.PerformClick();

            Assert.Equal(receiptText, ReceiptLabel.Text);
        }

        [Fact]
        public void ShouldHaveCorrectTotalAndItemsWithDefaultDiscount()
        {
            ShoesCheckBox.Checked = true;
            DefaultRadioButton.Checked = true;
            PaymentMethodComboBox.SelectedIndex = PaymentMethodComboBox.Items.IndexOf("Debit Card");
            double total = shoesPrice;
            string receiptText = "Welcome to Cody Store!\n" +
                "Items: " + "Shoes" + "\n" +
                "Payment Method: " + "Debit Card" + "\n" +
                "Total Cost: Php " + total.ToString("F");

            GenerateButton.PerformClick();

            Assert.Equal(receiptText, ReceiptLabel.Text);
        }

        [Fact]
        public void ShouldHaveCorrectTotalAndItemsWithSpecialDiscount()
        {
            ShirtCheckBox.Checked = true;
            SpecialRadioButton.Checked = true;
            PaymentMethodComboBox.SelectedIndex = PaymentMethodComboBox.Items.IndexOf("Credit Card");
            double total = shirtPrice * 0.85;
            string receiptText = "Welcome to Cody Store!\n" +
                "Items: " + "Shirt" + "\n" +
                "Payment Method: " + "Credit Card" + "\n" +
                "Total Cost: Php " + total.ToString("F");

            GenerateButton.PerformClick();

            Assert.Equal(receiptText, ReceiptLabel.Text);
        }
    }
}