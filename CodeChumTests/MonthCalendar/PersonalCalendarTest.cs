using System.Globalization;

namespace CodeChum.Tests
{
    public class PersonalCalendarTests
    {
        PersonalCalendar? form;
        Events events;
        MonthCalendar? MonthCalendar;
        Label? EventLabel;
        TextBox? EventNameTextBox;
        Button? AddEventButton, RetrieveEventButton;

        public PersonalCalendarTests()
        {
            form = new PersonalCalendar();
            form.Show();
            events = new Events();
            MonthCalendar = (MonthCalendar)TestUtils.GetControlNamed(form, "MonthCalendar", true);
            EventLabel = (Label)TestUtils.GetControlNamed(form, "EventLabel", true);
            EventNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "EventNameTextBox", true);
            AddEventButton = (Button)TestUtils.GetControlNamed(form, "AddEventButton", true);
            RetrieveEventButton = (Button)TestUtils.GetControlNamed(form, "RetrieveEventButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MonthCalendar);
            Assert.NotNull(EventLabel);
            Assert.NotNull(EventNameTextBox);
            Assert.NotNull(AddEventButton);
            Assert.NotNull(RetrieveEventButton);
        }

        [Fact]
        public void ShouldShowOnLabelWhenAddedAsHoliday()
        {

            EventNameTextBox.Text = "Christmas";
            DateTime christmas = new DateTime(2022, 12, 25);
            string dateString = DateTimeFormatInfo.CurrentInfo.GetMonthName(christmas.Month)
                   + " " + christmas.Day + ", " + christmas.Year;
            MonthCalendar.SetDate(christmas);
            events.AddEvent(dateString, EventNameTextBox.Text);

            AddEventButton.PerformClick();

            Assert.Equal(events.RetrieveEvent(dateString), EventLabel.Text);
        }

        [Fact]
        public void ShouldShowOnLabelWhenAdded()
        {
            string expected = "December 1, 2022";
            DateTime date = new DateTime(2022, 12, 1);
            MonthCalendar.SetDate(date);

            AddEventButton.PerformClick();
            RetrieveEventButton.PerformClick();

            Assert.Equal(events.RetrieveEvent(expected), EventLabel.Text);
        }
    }
}