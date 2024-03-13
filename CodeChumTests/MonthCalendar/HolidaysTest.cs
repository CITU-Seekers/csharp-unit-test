namespace CodeChum.Tests
{
    public class HolidaysTests
    {
        Holidays? form;
        MonthCalendar? holidaysMonthCalendar;
        Button? displayHolidaysButton;
        Label? holidaysLabel;

        public HolidaysTests()
        {
            form = new Holidays();
            form.Show();
            holidaysMonthCalendar = (MonthCalendar)TestUtils.GetControlNamed(form, "holidaysMonthCalendar", true);
            displayHolidaysButton = (Button)TestUtils.GetControlNamed(form, "displayHolidaysButton", true);
            holidaysLabel = (Label)TestUtils.GetControlNamed(form, "holidaysLabel", true);
        }

        [Fact]
        // Description: Should have all the controls `holidaysMonthCalendar`, `displayHolidaysButton`, and `holidaysLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(holidaysMonthCalendar);
            Assert.NotNull(displayHolidaysButton);
            Assert.NotNull(holidaysLabel);
        }

        [Fact]
        // Description: Should have all holidays in the `holidaysMonthCalendar` indicated as bold.
        public void ShouldHaveAllHolidaysIndicatedBold()
        {
            DateTime christmas = new DateTime(2022, 12, 25);
            DateTime rizal = new DateTime(2022, 12, 30);
            DateTime newYear = new DateTime(2023, 1, 1);
            DateTime lunarNewYear = new DateTime(2023, 1, 22);

            DateTime[] holidays = new DateTime[] { christmas, rizal, newYear, lunarNewYear };

            Assert.True(Enumerable.SequenceEqual(holidays, holidaysMonthCalendar.BoldedDates));
        }

        [Fact]
        // Description: Should show holidays for the month of December in `holidaysLabel` on `displayHolidaysButton` click.
        public void ShouldShowHolidaysOnDecember()
        {
            holidaysMonthCalendar.SelectionStart = DateTime.ParseExact("01/12/2022", "dd/MM/yyyy", null);
            string textToCompare = "December 25, 2022 - Christmas\nDecember 30, 2022 - Rizal Day";

            displayHolidaysButton.Select();
            displayHolidaysButton.PerformClick();

            Assert.Equal(textToCompare, holidaysLabel.Text);
        }

        [Fact]
        // Description: Should show holidays for the month of January in `holidaysLabel` on `displayHolidaysButton` click.
        public void ShouldShowHolidaysOnJanuary()
        {
            holidaysMonthCalendar.SelectionStart = DateTime.ParseExact("30/01/2023", "dd/MM/yyyy", null);
            string textToCompare = "January 1, 2023 - New Year's Day\nJanuary 22, 2023 - Lunar New Year";

            displayHolidaysButton.Select();
            displayHolidaysButton.PerformClick();

            Assert.Equal(textToCompare, holidaysLabel.Text);
        }
    }
}