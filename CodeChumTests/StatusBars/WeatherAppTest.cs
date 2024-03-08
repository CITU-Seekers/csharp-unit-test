namespace CodeChum.Tests
{
    public class WeatherAppTest
    {
        WeatherApp? form;
        Button? btnGenerate;
        StatusStrip? StatusStrip;
        ToolStripStatusLabel? WeatherStatus;

        public WeatherAppTest()
        {
            form = new WeatherApp();
            form.Show();
            btnGenerate = (Button)TestUtils.GetControlNamed(form, "btnGenerate", true);
            StatusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "StatusStrip", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(btnGenerate);
            Assert.NotNull(StatusStrip);
        }

        [Fact]
        public void ShouldDisplayWeatherStatus()
        {
            WeatherStatus = StatusStrip.Items["WeatherStatus"] as ToolStripStatusLabel;

            btnGenerate.PerformClick();

            Assert.Contains("Temperature: ", WeatherStatus.Text);
            Assert.Contains("°F, Condition: ", WeatherStatus.Text);
        }
    }
}
