using System.Globalization;

namespace CodeChum.Tests
{
    public class PersonalCalendarTests
    {
        PersonalCalendar? form;
        Events events;
        MonthCalendar? personalMonthCalendar;
        Label? eventLabel;
        TextBox? eventNameTextBox;
        Button? addEventButton, retrieveEventButton;

        public PersonalCalendarTests()
        {
            form = new PersonalCalendar();
            form.Show();
            events = new Events();
            personalMonthCalendar = (MonthCalendar)TestUtils.GetControlNamed(form, "personalMonthCalendar", true);
            eventLabel = (Label)TestUtils.GetControlNamed(form, "eventLabel", true);
            eventNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "eventNameTextBox", true);
            addEventButton = (Button)TestUtils.GetControlNamed(form, "addEventButton", true);
            retrieveEventButton = (Button)TestUtils.GetControlNamed(form, "retrieveEventButton", true);
        }

        [Fact]
        // Description: Should have all the controls `personalMonthCalendar`, `eventLabel`, `eventNameTextBox`, `addEventButton`, and `retrieveEventButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(personalMonthCalendar);
            Assert.NotNull(eventLabel);
            Assert.NotNull(eventNameTextBox);
            Assert.NotNull(addEventButton);
            Assert.NotNull(retrieveEventButton);
        }

        [Fact]
        // Description: Should show newly added event in `eventLabel` on `addEventButton` click.
        public void ShouldShowOnLabelWhenAddedAsHoliday()
        {

            eventNameTextBox.Text = "Christmas";
            DateTime christmas = new DateTime(2022, 12, 25);
            string dateString = DateTimeFormatInfo.CurrentInfo.GetMonthName(christmas.Month)
                   + " " + christmas.Day + ", " + christmas.Year;
            personalMonthCalendar.SetDate(christmas);
            events.AddEvent(dateString, eventNameTextBox.Text);

            addEventButton.PerformClick();

            Assert.Equal(events.RetrieveEvent(dateString), eventLabel.Text);
        }

        [Fact]
        // Description: Should retrieve event saved in a date and show it in `eventLabel` on `retrieveEventButton` click.
        public void ShouldShowOnLabelWhenAdded()
        {
            string expected = "December 1, 2022";
            DateTime date = new DateTime(2022, 12, 1);
            personalMonthCalendar.SetDate(date);

            addEventButton.PerformClick();
            retrieveEventButton.PerformClick();

            Assert.Equal(events.RetrieveEvent(expected), eventLabel.Text);
        }
    }
}