using System.Globalization;

namespace CodeChum.Tests
{
    public class SimpleDatePickerTests
    {
        SimpleDatePicker? form;
        DateTimePicker? exactDateTimePicker;
        Label? dateLabel;

        public SimpleDatePickerTests()
        {
            form = new SimpleDatePicker();
            exactDateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "exactDateTimePicker", true);
            dateLabel = (Label)TestUtils.GetControlNamed(form, "dateLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(exactDateTimePicker);
            Assert.NotNull(dateLabel);
        }

        [Fact]
        public void ShouldChangeOnDateChange()
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string expected = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month) + " " +
                date.Day + ", " + date.Year;

            exactDateTimePicker.Value = date;

            Assert.Equal(expected, dateLabel.Text);
        }
    }
}