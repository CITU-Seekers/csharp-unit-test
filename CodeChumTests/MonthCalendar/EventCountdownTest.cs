using Timer = System.Windows.Forms.Timer;

namespace CodeChum.Tests
{
    public class EventCountdownTest
    {
        EventCountdown? form;
        MonthCalendar? monthCalendar;
        TextBox? eventName;
        Button? addButton;
        Label? countdownLabel;

        public EventCountdownTest()
        {
            form = new EventCountdown();
            form.Show();
            monthCalendar = (MonthCalendar)TestUtils.GetControlNamed(form, "MonthCalendar", true);
            eventName = (TextBox)TestUtils.GetControlNamed(form, "EventName", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
            countdownLabel = (Label)TestUtils.GetControlNamed(form, "lblCountdown", true);
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
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(monthCalendar);
            Assert.NotNull(eventName);
            Assert.NotNull(addButton);
            Assert.NotNull(countdownLabel);
        }

        [Fact]
        public void ShouldAddEvent()
        {
            var date = new DateTime(2021, 1, 1);
            var name = "New Year's Day";
            eventName.Text = name;
            monthCalendar.SelectionStart = date;
            addButton.PerformClick();
            wait(5000);

            //Change the selected date to 2020-12-31
            monthCalendar.SelectionStart = new DateTime(2020, 12, 31);
            wait(5000);

            Assert.Equal("Countdown to: \nNew Year's Day: 1 days\r\n", countdownLabel.Text);
        }

        [Fact]
        public void ShouldAddMultipleEvents()
        {
            var date = new DateTime(2021, 1, 1);
            var name = "New Year's Day";
            eventName.Text = name;
            monthCalendar.SelectionStart = date;
            addButton.PerformClick();
            wait(5000);


            //Add another event
            date = new DateTime(2021, 1, 2);
            name = "Company Party";
            eventName.Text = name;
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
