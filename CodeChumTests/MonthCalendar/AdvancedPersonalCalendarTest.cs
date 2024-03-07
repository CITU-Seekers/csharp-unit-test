namespace CodeChum.Tests
{
    public class AdvancedPersonalCalendarTest
    {
        AdvancedPersonalCalendar? form;
        MonthCalendar? calendar;
        TextBox? eventName;
        ComboBox? frequency;
        Button? add, delete;
        Label? lblEvent;

        public AdvancedPersonalCalendarTest()
        {
            form = new AdvancedPersonalCalendar();
            form.Visible = true;
            calendar = (MonthCalendar)TestUtils.GetControlNamed(form, "MonthCalendar", true);
            eventName = (TextBox)TestUtils.GetControlNamed(form, "EventName", true);
            frequency = (ComboBox)TestUtils.GetControlNamed(form, "cboFrequency", true);
            add = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
            delete = (Button)TestUtils.GetControlNamed(form, "btnDelete", true);
            lblEvent = (Label)TestUtils.GetControlNamed(form, "lblEvent", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(calendar);
            Assert.NotNull(eventName);
            Assert.NotNull(frequency);
            Assert.NotNull(add);
            Assert.NotNull(delete);
            Assert.NotNull(lblEvent);
        }

        [Fact]
        public void ShouldHaveInitialValues()
        {
            Assert.Equal(DateTime.Today, calendar!.SelectionStart);
            Assert.Equal("", eventName!.Text);
            Assert.Equal(0, frequency!.SelectedIndex);
            Assert.Equal("No Event", lblEvent!.Text);
        }

        [Fact]
        public void ShouldAddOneTimeEvent()
        {
            calendar!.SelectionStart = DateTime.Today;
            eventName!.Text = "Test Event";
            frequency!.SelectedIndex = 0;
            add!.PerformClick();
            Assert.Equal("Test Event", lblEvent!.Text);
        }

        [Fact]
        public void ShouldAddDailyEvents()
        {
            calendar!.SelectionStart = DateTime.Today;
            eventName!.Text = "Test Event";
            frequency!.SelectedIndex = 1;
            add!.PerformClick();
            Assert.Equal("Daily - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(1);
            Assert.Equal("Daily - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(2);
            Assert.Equal("Daily - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(3);
            Assert.Equal("Daily - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(4);
            Assert.Equal("Daily - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(5);
            Assert.Equal("Daily - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(6);
            Assert.Equal("Daily - Test Event", lblEvent!.Text);
        }

        [Fact]
        public void ShouldAddEveryWeekdayEvents()
        {
            calendar!.SelectionStart = DateTime.Today;
            eventName!.Text = "Test Event";
            frequency!.SelectedIndex = 2;
            add!.PerformClick();
            Assert.Equal("Every Weekdays - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(1);
            Assert.Equal("Every Weekdays - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(2);
            Assert.Equal("Every Weekdays - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(3);
            Assert.Equal("Every Weekdays - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(4);
            Assert.Equal("Every Weekdays - Test Event", lblEvent!.Text);
        }

        [Fact]
        public void ShouldAddEveryWeekendEvents()
        {
            DateTime weekendDate = new DateTime(2023, 12, 23);
            calendar!.SelectionStart = weekendDate;
            eventName!.Text = "Test Event";
            frequency!.SelectedIndex = 3; // Assuming index 3 corresponds to "Every Weekends"
            add!.PerformClick();
            Assert.Equal("Every Weekends - Test Event", lblEvent!.Text);

            // Move to the next day (which should still be a weekend)
            calendar!.SelectionStart = weekendDate.AddDays(1);
            Assert.Equal("Every Weekends - Test Event", lblEvent!.Text);
        }

        [Fact]
        public void ShouldAddWeeklyEvents()
        {
            calendar!.SelectionStart = DateTime.Today;
            eventName!.Text = "Test Event";
            frequency!.SelectedIndex = 4;
            add!.PerformClick();
            Assert.Equal("Every Week - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(7);
            Assert.Equal("Every Week - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(14);
            Assert.Equal("Every Week - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(21);
            Assert.Equal("Every Week - Test Event", lblEvent!.Text);
        }

        [Fact]
        public void ShouldAddMonthlyEvents()
        {
            calendar!.SelectionStart = DateTime.Today;
            eventName!.Text = "Test Event";
            frequency!.SelectedIndex = 5;
            add!.PerformClick();
            Assert.Equal("Every Month - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(14);
            Assert.Equal("Every Month - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(28);
            Assert.Equal("Every Month - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(42);
            Assert.Equal("Every Month - Test Event", lblEvent!.Text);
        }

        [Fact]
        public void ShouldAddYearlyEvents()
        {
            calendar!.SelectionStart = DateTime.Today;
            eventName!.Text = "Test Event";
            frequency!.SelectedIndex = 6;
            add!.PerformClick();
            Assert.Equal("Every Year - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(365);
            Assert.Equal("Every Year - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(730);
            Assert.Equal("Every Year - Test Event", lblEvent!.Text);
            calendar!.SelectionStart = DateTime.Today.AddDays(1095);
            Assert.Equal("Every Year - Test Event", lblEvent!.Text);
        }

        [Fact]
        public void ShouldDeleteEvent()
        {
            calendar!.SelectionStart = DateTime.Today;
            eventName!.Text = "Test Event";
            frequency!.SelectedIndex = 0;
            add!.PerformClick();
            Assert.Equal("Test Event", lblEvent!.Text);
            delete!.PerformClick();
        }
    }
}
