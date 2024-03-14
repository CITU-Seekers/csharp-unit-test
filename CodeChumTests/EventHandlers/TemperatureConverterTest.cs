namespace CodeChum.Tests
{
    public class TemperatureConverterTest
    {
        TemperatureConverter? form;
        TextBox? celsiusTextBox;
        Label? fahrenheitLabel;
        Button? convertButton;

        public TemperatureConverterTest()
        {
            form = new TemperatureConverter();
            form.Visible = true;
            celsiusTextBox = (TextBox)TestUtils.GetControlNamed(form, "celsiusTextBox", true);
            fahrenheitLabel = (Label)TestUtils.GetControlNamed(form, "fahrenheitLabel", true);
            convertButton = (Button)TestUtils.GetControlNamed(form, "convertButton", true);
        }

        [Fact]
        // Description: Should have all controls `celsiusTextBox`, `fahrenheitLabel`, and `convertButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(celsiusTextBox);
            Assert.NotNull(fahrenheitLabel);
            Assert.NotNull(convertButton);
        }

        [Fact]
        // Description: Should convert 0°C to 32°F when `celsiusTextBox` is set to "0" and `convertButton` is clicked.
        public void ShouldConvertCelsiusToFahrenheit()
        {
            celsiusTextBox.Text = "0";
            convertButton.PerformClick();
            Assert.Equal("32.00 °F", fahrenheitLabel.Text);
        }

        [Fact]
        // Description: Should convert -40°C to -40°F when `celsiusTextBox` is set to "-40" and `convertButton` is clicked.
        public void ShouldConvertNegativeCelsiusToFahrenheit()
        {
            celsiusTextBox.Text = "-40";
            convertButton.PerformClick();
            Assert.Equal("-40.00 °F", fahrenheitLabel.Text);
        }

        [Fact]
        // Description: Should convert 100.5°C to 212.90°F when `celsiusTextBox` is set to "100.5" and `convertButton` is clicked.
        public void ShouldConvertDecimalCelsiusToFahrenheit()
        {
            celsiusTextBox.Text = "100.5";
            convertButton.PerformClick();
            Assert.Equal("212.90 °F", fahrenheitLabel.Text);
        }

        [Fact]
        // Description: Should display error message "Invalid input. Please enter a valid temperature in Celsius." when `celsiusTextBox` is set to "abc" and `convertButton` is clicked.
        public void ShouldDisplayErrorMessageForInvalidInput()
        {
            celsiusTextBox.Text = "abc";
            convertButton.PerformClick();
            Assert.Equal("Invalid input. Please enter a valid temperature in Celsius.", fahrenheitLabel.Text);
        }
    }
}
