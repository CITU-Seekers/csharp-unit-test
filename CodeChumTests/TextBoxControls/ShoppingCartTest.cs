namespace CodeChum.Tests
{
    public class ShoppingCartTest
    {
        ShoppingCart? form;
        Label? totalPriceLabel;
        Button? calculateButton;
        TextBox? itemTextBox;

        public ShoppingCartTest()
        {
            form = new ShoppingCart();
            form.Show();

            itemTextBox = (TextBox)TestUtils.GetControlNamed(form, "itemTextBox", true);
            totalPriceLabel = (Label)TestUtils.GetControlNamed(form, "totalPriceLabel", true);
            calculateButton = (Button)TestUtils.GetControlNamed(form, "calculateButton", true);
        }

        [Fact]
        // Description: Should have all the controls `itemTextBox`, `totalPrice`, and `calculateButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(itemTextBox);
            Assert.NotNull(totalPriceLabel);
            Assert.NotNull(calculateButton);
        }

        [Fact]
        // Description: Should calculate the total when the `calculateButton` is clicked.
        public void ShouldCalculateTotal()
        {
            itemTextBox.Text = "1, 2, 3";
            calculateButton.PerformClick();
            Assert.Equal("6", totalPriceLabel.Text);
        }

        [Fact]
        // Description: Should calculate the total with new lines in `itemTextBox` when the `calculateButton` is clicked.
        public void ShouldCalculateTotalWithNewLines()
        {
            itemTextBox.Text = "1\n2\n3";
            calculateButton.PerformClick();
            Assert.Equal("6", totalPriceLabel.Text);
        }

        [Fact]
        // Description: Should calculate the total with spaces in `itemTextBox` when the `calculateButton` is clicked.
        public void ShouldCalculateTotalWithSpaces()
        {
            itemTextBox.Text = "1 2 3";
            calculateButton.PerformClick();
            Assert.Equal("6", totalPriceLabel.Text);
        }

        [Fact]
        // Description: Should calculate the total with commas in `itemTextBox` when the `calculateButton` is clicked.
        public void ShouldCalculateTotalWithCommas()
        {
            itemTextBox.Text = "1,2,3";
            calculateButton.PerformClick();
            Assert.Equal("6", totalPriceLabel.Text);
        }

        [Fact]
        // Description: Should calculate the total with mixed delimiters in `itemTextBox` when the `calculateButton` is clicked.
        public void ShouldCalculateTotalWithMixedDelimiters()
        {
            itemTextBox.Text = "1, 2\n3 4";
            calculateButton.PerformClick();
            Assert.Equal("10", totalPriceLabel.Text);
        }
    }
}
