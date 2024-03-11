namespace CodeChum.Tests
{
    public class TimeConverterTests
    {
        TimeConverter? form;
        NumericUpDown? HourNumericControl, MinuteNumericControl;
        Label? TwelveHourLabel;

        public TimeConverterTests()
        {
            form = new TimeConverter();
            HourNumericControl = (NumericUpDown)TestUtils.GetControlNamed(form, "HourNumericControl", true);
            MinuteNumericControl = (NumericUpDown)TestUtils.GetControlNamed(form, "MinuteNumericControl", true);
            TwelveHourLabel = (Label)TestUtils.GetControlNamed(form, "TwelveHourLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(HourNumericControl);
            Assert.NotNull(MinuteNumericControl);
            Assert.NotNull(TwelveHourLabel);
        }

        [Fact]
        public void ShouldHaveCorrectMaxMinValuesForHourNumericControl()
        {
            int hourMax = 23;
            int hourMin = 0;

            Assert.Equal(HourNumericControl.Maximum, hourMax);
            Assert.Equal(HourNumericControl.Minimum, hourMin);
        }

        [Fact]
        public void ShouldHaveCorrectMaxMinValuesForMinuteNumericControl()
        {
            int minuteMax = 59;
            int minuteMin = 0;

            Assert.Equal(MinuteNumericControl.Maximum, minuteMax);
            Assert.Equal(MinuteNumericControl.Minimum, minuteMin);
        }

        [Fact]
        public void ShouldChangeTimeCorrectlyForAnteMeridiem()
        {
            int hour = 6;
            int minute = 50;
            string time = "6:50 AM";

            HourNumericControl.Value = hour;
            MinuteNumericControl.Value = minute;

            Assert.Equal(time, TwelveHourLabel.Text);
        }

        [Fact]
        public void ShouldChangeTimeCorrectlyForPostMeridiem()
        {
            int hour = 15;
            int minute = 5;
            string time = "3:05 PM";

            HourNumericControl.Value = hour;
            MinuteNumericControl.Value = minute;

            Assert.Equal(time, TwelveHourLabel.Text);
        }
    }
}