using Timer = System.Windows.Forms.Timer;

namespace CodeChum.Tests
{
    public class EventCountdownTest
    {
        EventCountdown? form;
        MonthCalendar? monthCalendar;
        TextBox? eventNameTextBox;
        Button? addButton;
        Label? countdownLabel;

        public EventCountdownTest()
        {
            form = new EventCountdown();
            form.Show();
            monthCalendar = (MonthCalendar)TestUtils.GetControlNamed(form, "monthCalendar", true);
            eventNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "eventNameTextBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            countdownLabel = (Label)TestUtils.GetControlNamed(form, "countdownLabel", true);
        }

        public void wait(int milliseconds)
        {
            var timer = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer.Interval = milliseconds;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += (s, e) =>
            {
                timer.Enabled = false;
                timer.Stop();
            };

            while (timer.Enabled)
            {
                Application.DoEvents();
            }
        }

        [Fact]
        // Description: Should have all the controls `monthCalendar`, `eventNameTextBox`, `addButton`, and `countdownLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(monthCalendar);
            Assert.NotNull(eventNameTextBox);
            Assert.NotNull(addButton);
            Assert.NotNull(countdownLabel);
        }

        [Fact]
        // Description: Should display message "Countdown to: \nNew Year's Day: 1 days" in `countdownLabel` when the `addButton` is clicked.
        public void ShouldAddEvent()
        {
            var date = new DateTime(2021, 1, 1);
            var name = "New Year's Day";
            eventNameTextBox.Text = name;
            monthCalendar.SelectionStart = date;
            addButton.PerformClick();
            wait(5000);

            //Change the selected date to 2020-12-31
            monthCalendar.SelectionStart = new DateTime(2020, 12, 31);
            wait(5000);

            Assert.Equal("Countdown to: \nNew Year's Day: 1 days\r\n", countdownLabel.Text);
        }

        [Fact]
        // Description: Should display message "Countdown to: \nNew Year's Day: 1 days\r\nCompany Party: 2 days" in `countdownLabel` when the `addButton` is clicked twice.
        public void ShouldAddMultipleEvents()
        {
            var date = new DateTime(2021, 1, 1);
            var name = "New Year's Day";
            eventNameTextBox.Text = name;
            monthCalendar.SelectionStart = date;
            addButton.PerformClick();
            wait(5000);


            //Add another event
            date = new DateTime(2021, 1, 2);
            name = "Company Party";
            eventNameTextBox.Text = name;
            monthCalendar.SelectionStart = date;
            addButton.PerformClick();
            wait(5000);

            //Change the selected date to 2020-12-31
            monthCalendar.SelectionStart = new DateTime(2020, 12, 31);
            wait(5000);

            Assert.Equal("Countdown to: \nNew Year's Day: 1 days\r\nCompany Party: 2 days\r\n", countdownLabel.Text);
        }
    }
}
