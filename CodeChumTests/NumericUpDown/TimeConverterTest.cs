namespace CodeChum.Tests
{
    public class TimeConverterTests
    {
        TimeConverter? form;
        NumericUpDown? hourNumericUpDown, minuteNumericUpDown;
        Label? twelveHourLabel;

        public TimeConverterTests()
        {
            form = new TimeConverter();
            hourNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "hourNumericUpDown", true);
            minuteNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "minuteNumericUpDown", true);
            twelveHourLabel = (Label)TestUtils.GetControlNamed(form, "twelveHourLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(hourNumericUpDown);
            Assert.NotNull(minuteNumericUpDown);
            Assert.NotNull(twelveHourLabel);
        }

        [Fact]
        public void ShouldHaveCorrectMaxMinValuesForHourNumericControl()
        {
            int hourMax = 23;
            int hourMin = 0;

            Assert.Equal(hourNumericUpDown.Maximum, hourMax);
            Assert.Equal(hourNumericUpDown.Minimum, hourMin);
        }

        [Fact]
        public void ShouldHaveCorrectMaxMinValuesForMinuteNumericControl()
        {
            int minuteMax = 59;
            int minuteMin = 0;

            Assert.Equal(minuteNumericUpDown.Maximum, minuteMax);
            Assert.Equal(minuteNumericUpDown.Minimum, minuteMin);
        }

        [Fact]
        public void ShouldChangeTimeCorrectlyForAnteMeridiem()
        {
            int hour = 6;
            int minute = 50;
            string time = "6:50 AM";

            hourNumericUpDown.Value = hour;
            minuteNumericUpDown.Value = minute;

            Assert.Equal(time, twelveHourLabel.Text);
        }

        [Fact]
        public void ShouldChangeTimeCorrectlyForPostMeridiem()
        {
            int hour = 15;
            int minute = 5;
            string time = "3:05 PM";

            hourNumericUpDown.Value = hour;
            minuteNumericUpDown.Value = minute;

            Assert.Equal(time, twelveHourLabel.Text);
        }
    }
}