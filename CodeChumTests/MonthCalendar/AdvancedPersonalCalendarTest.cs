namespace CodeChum.Tests
{
    public class AdvancedPersonalCalendarTest
    {
        AdvancedPersonalCalendar? form;
        MonthCalendar? monthCalendar;
        TextBox? eventNameTextBox;
        ComboBox? frequencyComboBox;
        Button? addButton, deleteButton;
        Label? eventLabel;

        public AdvancedPersonalCalendarTest()
        {
            form = new AdvancedPersonalCalendar();
            form.Visible = true;
            monthCalendar = (MonthCalendar)TestUtils.GetControlNamed(form, "monthCalendar", true);
            eventNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "eventNameTextBox", true);
            frequencyComboBox = (ComboBox)TestUtils.GetControlNamed(form, "frequencyComboBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            deleteButton = (Button)TestUtils.GetControlNamed(form, "deleteButton", true);
            eventLabel = (Label)TestUtils.GetControlNamed(form, "eventLabel", true);
        }

        [Fact]
        // Description: Should have all the controls `monthCalendar`, `eventNameTextBox`, `frequencyComboBox`, `addButton`, `deleteButton`, and `eventLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(monthCalendar);
            Assert.NotNull(eventNameTextBox);
            Assert.NotNull(frequencyComboBox);
            Assert.NotNull(addButton);
            Assert.NotNull(deleteButton);
            Assert.NotNull(eventLabel);
        }

        [Fact]
        // Description: Should have values "None", "Daily", "Every Weekdays", "Every Weekends", "Every Week", "Every Month", and "Every Year" in `frequencyComboBox`.
        public void ShouldHaveFrequencyComboBoxValues()
        {
            Assert.Equal("None", frequencyComboBox!.Items[0]);
            Assert.Equal("Daily", frequencyComboBox!.Items[1]);
            Assert.Equal("Every Weekdays", frequencyComboBox!.Items[2]);
            Assert.Equal("Every Weekends", frequencyComboBox!.Items[3]);
            Assert.Equal("Every Week", frequencyComboBox!.Items[4]);
            Assert.Equal("Every Month", frequencyComboBox!.Items[5]);
            Assert.Equal("Every Year", frequencyComboBox!.Items[6]);
        }

        [Fact]
        // Description: Should have initial values for `monthCalendar`, `eventNameTextBox`, `frequencyComboBox`, and `eventLabel`.
        public void ShouldHaveInitialValues()
        {
            Assert.Equal(DateTime.Today, monthCalendar!.SelectionStart);
            Assert.Equal("", eventNameTextBox!.Text);
            Assert.Equal(0, frequencyComboBox!.SelectedIndex);
            Assert.Equal("No Event", eventLabel!.Text);
        }

        [Fact]
        // Description: Should add one-time event "Test Event" in `eventLabel` when the `addButton` is clicked.
        public void ShouldAddOneTimeEvent()
        {
            monthCalendar!.SelectionStart = DateTime.Today;
            eventNameTextBox!.Text = "Test Event";
            frequencyComboBox!.SelectedIndex = 0;
            addButton!.PerformClick();
            Assert.Equal("Test Event", eventLabel!.Text);
        }

        [Fact]
        // Description: Should add daily event "Test Event" in `eventLabel` when the `addButton` is clicked.
        public void ShouldAddDailyEvents()
        {
            monthCalendar!.SelectionStart = DateTime.Today;
            eventNameTextBox!.Text = "Test Event";
            frequencyComboBox!.SelectedIndex = 1;
            addButton!.PerformClick();
            Assert.Equal("Daily - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(1);
            Assert.Equal("Daily - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(2);
            Assert.Equal("Daily - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(3);
            Assert.Equal("Daily - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(4);
            Assert.Equal("Daily - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(5);
            Assert.Equal("Daily - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(6);
            Assert.Equal("Daily - Test Event", eventLabel!.Text);
        }

        [Fact]
        // Description: Should add every weekday event "Test Event" in `eventLabel` when the `addButton` is clicked.
        public void ShouldAddEveryWeekdayEvents()
        {
            monthCalendar!.SelectionStart = DateTime.Today;
            eventNameTextBox!.Text = "Test Event";
            frequencyComboBox!.SelectedIndex = 2;
            addButton!.PerformClick();
            Assert.Equal("Every Weekdays - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(1);
            Assert.Equal("Every Weekdays - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(2);
            Assert.Equal("Every Weekdays - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(3);
            Assert.Equal("Every Weekdays - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(4);
            Assert.Equal("Every Weekdays - Test Event", eventLabel!.Text);
        }

        [Fact]
        // Description: Should add every weekend event "Test Event" in `eventLabel` when the `addButton` is clicked.
        public void ShouldAddEveryWeekendEvents()
        {
            DateTime weekendDate = new DateTime(2023, 12, 23);
            monthCalendar!.SelectionStart = weekendDate;
            eventNameTextBox!.Text = "Test Event";
            frequencyComboBox!.SelectedIndex = 3; // Assuming index 3 corresponds to "Every Weekends"
            addButton!.PerformClick();
            Assert.Equal("Every Weekends - Test Event", eventLabel!.Text);

            // Move to the next day (which should still be a weekend)
            monthCalendar!.SelectionStart = weekendDate.AddDays(1);
            Assert.Equal("Every Weekends - Test Event", eventLabel!.Text);
        }

        [Fact]
        // Description: Should add weekly event "Test Event" in `eventLabel` when the `addButton` is clicked.
        public void ShouldAddWeeklyEvents()
        {
            monthCalendar!.SelectionStart = DateTime.Today;
            eventNameTextBox!.Text = "Test Event";
            frequencyComboBox!.SelectedIndex = 4;
            addButton!.PerformClick();
            Assert.Equal("Every Week - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(7);
            Assert.Equal("Every Week - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(14);
            Assert.Equal("Every Week - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(21);
            Assert.Equal("Every Week - Test Event", eventLabel!.Text);
        }

        [Fact]
        // Description: Should add monthly event "Test Event" in `eventLabel` when the `addButton` is clicked.
        public void ShouldAddMonthlyEvents()
        {
            monthCalendar!.SelectionStart = DateTime.Today;
            eventNameTextBox!.Text = "Test Event";
            frequencyComboBox!.SelectedIndex = 5;
            addButton!.PerformClick();
            Assert.Equal("Every Month - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(14);
            Assert.Equal("Every Month - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(28);
            Assert.Equal("Every Month - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(42);
            Assert.Equal("Every Month - Test Event", eventLabel!.Text);
        }

        [Fact]
        // Description: Should add yearly event "Test Event" in `eventLabel` when the `addButton` is clicked.
        public void ShouldAddYearlyEvents()
        {
            monthCalendar!.SelectionStart = DateTime.Today;
            eventNameTextBox!.Text = "Test Event";
            frequencyComboBox!.SelectedIndex = 6;
            addButton!.PerformClick();
            Assert.Equal("Every Year - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(365);
            Assert.Equal("Every Year - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(730);
            Assert.Equal("Every Year - Test Event", eventLabel!.Text);
            monthCalendar!.SelectionStart = DateTime.Today.AddDays(1095);
            Assert.Equal("Every Year - Test Event", eventLabel!.Text);
        }

        [Fact]
        // Description: Should delete event "Test Event" in `eventLabel` when the `deleteButton` is clicked.
        public void ShouldDeleteEvent()
        {
            monthCalendar!.SelectionStart = DateTime.Today;
            eventNameTextBox!.Text = "Test Event";
            frequencyComboBox!.SelectedIndex = 0;
            addButton!.PerformClick();
            Assert.Equal("Test Event", eventLabel!.Text);
            deleteButton!.PerformClick();
        }
    }
}
