namespace CodeChum.Tests
{
    public class TemperatureConverterTest
    {
        TemperatureConverter? form;
        TextBox? textBox1;
        Label? lblFahrenheit;
        Button? btnConvert;

        public TemperatureConverterTest()
        {
            form = new TemperatureConverter();
            form.Visible = true;
            textBox1 = (TextBox)TestUtils.GetControlNamed(form, "textBox1", true);
            lblFahrenheit = (Label)TestUtils.GetControlNamed(form, "lblFahrenheit", true);
            btnConvert = (Button)TestUtils.GetControlNamed(form, "btnConvert", true);
        }

        [Fact]
        public void ShouldConvertCelsiusToFahrenheit()
        {
            textBox1.Text = "0";
            btnConvert.PerformClick();
            Assert.Equal("32.00 °F", lblFahrenheit.Text);
        }

        [Fact]
        public void ShouldConvertNegativeCelsiusToFahrenheit()
        {
            textBox1.Text = "-40";
            btnConvert.PerformClick();
            Assert.Equal("-40.00 °F", lblFahrenheit.Text);
        }

        [Fact]
        public void ShouldConvertDecimalCelsiusToFahrenheit()
        {
            textBox1.Text = "100.5";
            btnConvert.PerformClick();
            Assert.Equal("212.90 °F", lblFahrenheit.Text);
        }

        [Fact]
        public void ShouldDisplayErrorMessageForInvalidInput()
        {
            textBox1.Text = "abc";
            btnConvert.PerformClick();
            Assert.Equal("Invalid input. Please enter a valid temperature in Celsius.", lblFahrenheit.Text);
        }

        [Fact]
        public void HasLabelFahrenheit()
        {
            Assert.NotNull(lblFahrenheit);
        }

        [Fact]
        public void HasTextBox1()
        {
            Assert.NotNull(textBox1);
        }

        [Fact]
        public void HasConvertButton()
        {
            Assert.NotNull(btnConvert);
        }

    }
}
