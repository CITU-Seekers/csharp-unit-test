namespace CodeChum.Tests
{
    public class ShoppingCartTest
    {
        ShoppingCart? form;
        Label? totalPrice;
        Button? calculateButton;
        TextBox? textBox1;

        public ShoppingCartTest()
        {
            form = new ShoppingCart();
            form.Visible = true;
            textBox1 = (TextBox)TestUtils.GetControlNamed(form, "textBox1", true);
            totalPrice = (Label)TestUtils.GetControlNamed(form, "TotalPrice", true);
            calculateButton = (Button)TestUtils.GetControlNamed(form, "btnCalculate", true);
        }

        [Fact]
        public void ShouldCalculateTotal()
        {
            textBox1.Text = "1, 2, 3";
            calculateButton.PerformClick();
            Assert.Equal("6", totalPrice.Text);
        }

        [Fact]
        public void ShouldCalculateTotalWithNewLines()
        {
            textBox1.Text = "1\n2\n3";
            calculateButton.PerformClick();
            Assert.Equal("6", totalPrice.Text);
        }

        [Fact]
        public void ShouldCalculateTotalWithSpaces()
        {
            textBox1.Text = "1 2 3";
            calculateButton.PerformClick();
            Assert.Equal("6", totalPrice.Text);
        }

        [Fact]
        public void ShouldCalculateTotalWithCommas()
        {
            textBox1.Text = "1,2,3";
            calculateButton.PerformClick();
            Assert.Equal("6", totalPrice.Text);
        }

        [Fact]
        public void ShouldCalculateTotalWithMixedDelimiters()
        {
            textBox1.Text = "1, 2\n3 4";
            calculateButton.PerformClick();
            Assert.Equal("10", totalPrice.Text);
        }

        [Fact]
        public void HasCalculateButton()
        {
            Assert.NotNull(calculateButton);
        }

        [Fact]
        public void HasTextBox()
        {
            Assert.NotNull(textBox1);
        }

        [Fact]
        public void HasTotalPrice()
        {
            Assert.NotNull(totalPrice);
        }
    }
}
