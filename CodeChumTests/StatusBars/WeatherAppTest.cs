namespace CodeChum.Tests
{
    public class WeatherAppTest
    {
        WeatherApp? form;
        Button? generateButton;
        StatusStrip? statusStrip;
        ToolStripStatusLabel? weatherStatusLabel;

        public WeatherAppTest()
        {
            form = new WeatherApp();
            form.Show();
            generateButton = (Button)TestUtils.GetControlNamed(form, "generateButton", true);
            statusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "statusStrip", true);
        }

        [Fact]
        // Description: Should have all the controls `generateButton` and `statusStrip`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(generateButton);
            Assert.NotNull(statusStrip);
        }

        [Fact]
        // Description: Should display text that contains "Temperature: " and "°F, Condition: " in `weatherStatusLabel` when the `generateButton` is clicked.
        public void ShouldDisplayWeatherStatus()
        {
            weatherStatusLabel = statusStrip.Items["weatherStatusLabel"] as ToolStripStatusLabel;

            generateButton.PerformClick();

            Assert.Contains("Temperature: ", weatherStatusLabel.Text);
            Assert.Contains("°F, Condition: ", weatherStatusLabel.Text);
        }
    }
}
