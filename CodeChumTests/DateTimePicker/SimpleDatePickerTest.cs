using System.Globalization;

namespace CodeChum.Tests
{
    public class SimpleDatePickerTests
    {
        SimpleDatePicker? form;
        DateTimePicker? DateTimePicker;
        Label? DateLabel;

        public SimpleDatePickerTests()
        {
            form = new SimpleDatePicker();
            DateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "DateTimePicker", true);
            DateLabel = (Label)TestUtils.GetControlNamed(form, "DateLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(DateTimePicker);
            Assert.NotNull(DateLabel);
        }

        [Fact]
        public void ShouldChangeOnDateChange()
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string expected = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month) + " " +
                date.Day + ", " + date.Year;

            DateTimePicker.Value = date;

            Assert.Equal(expected, DateLabel.Text);
        }
    }
}