namespace CodeChum.Tests
{
    public class HolidaysTests
    {
        Holidays? form;
        MonthCalendar? MonthCalendar;
        Button? DisplayHolidaysButton;
        Label? HolidaysLabel;

        public HolidaysTests()
        {
            form = new Holidays();
            form.Show();
            MonthCalendar = (MonthCalendar)TestUtils.GetControlNamed(form, "MonthCalendar", true);
            DisplayHolidaysButton = (Button)TestUtils.GetControlNamed(form, "DisplayHolidaysButton", true);
            HolidaysLabel = (Label)TestUtils.GetControlNamed(form, "HolidaysLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MonthCalendar);
            Assert.NotNull(DisplayHolidaysButton);
            Assert.NotNull(HolidaysLabel);
        }

        [Fact]
        public void ShouldHaveAllHolidaysIndicatedBold()
        {
            DateTime christmas = new DateTime(2022, 12, 25);
            DateTime rizal = new DateTime(2022, 12, 30);
            DateTime newYear = new DateTime(2023, 1, 1);
            DateTime lunarNewYear = new DateTime(2023, 1, 22);

            DateTime[] holidays = new DateTime[] { christmas, rizal, newYear, lunarNewYear };

            Assert.True(Enumerable.SequenceEqual(holidays, MonthCalendar.BoldedDates));
        }

        [Fact]
        public void ShouldShowHolidaysOnDecember()
        {
            MonthCalendar.SelectionStart = DateTime.ParseExact("01/12/2022", "dd/MM/yyyy", null);
            string textToCompare = "December 25, 2022 - Christmas\nDecember 30, 2022 - Rizal Day";

            DisplayHolidaysButton.Select();
            DisplayHolidaysButton.PerformClick();

            Assert.Equal(textToCompare, HolidaysLabel.Text);
        }

        [Fact]
        public void ShouldShowHolidaysOnJanuary()
        {
            MonthCalendar.SelectionStart = DateTime.ParseExact("30/01/2023", "dd/MM/yyyy", null);
            string textToCompare = "January 1, 2023 - New Year's Day\nJanuary 22, 2023 - Lunar New Year";

            DisplayHolidaysButton.Select();
            DisplayHolidaysButton.PerformClick();

            Assert.Equal(textToCompare, HolidaysLabel.Text);
        }
    }
}