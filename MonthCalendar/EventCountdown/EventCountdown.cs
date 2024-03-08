using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class EventCountdown : Form
    {
        private DateTime selectedEventDate;
        private string selectedEventName;
        private Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

        public EventCountdown()
        {
            InitializeComponent();
            // Attach event handlers
            btnAdd.Click += btnAdd_Click;
            MonthCalendar.DateSelected += MonthCalendar_DateSelected;

            CountdownTimer.Interval = 1000; // Update every 1 second
            CountdownTimer.Tick += CountdownTimer_Tick;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the selected date from the MonthCalendar control
            DateTime selectedDate = MonthCalendar.SelectionStart;

            // Get the event name from the TextBox
            string eventName = EventName.Text;

            AddEvent(selectedDate, eventName);

            // Update countdown for the selected date
            UpdateCountdownForSelectedDate();

            // Start or restart the countdown timer
            CountdownTimer.Start();
        }

        private void AddEvent(DateTime date, string eventName)
        {
            // Add the event to the dictionary
            events[date] = eventName;

            // Visual feedback: Highlight the dates on the calendar
            UpdateCalendarHighlights();
        }

        private void UpdateCalendarHighlights()
        {
            // Clear previous highlights
            MonthCalendar.RemoveAllBoldedDates();

            // Highlight dates with scheduled events
            foreach (var date in events.Keys)
            {
                MonthCalendar.AddBoldedDate(date);
            }

            // Update the display
            MonthCalendar.UpdateBoldedDates();
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Get the selected date
            DateTime selectedDate = MonthCalendar.SelectionStart;

            // Find the nearest upcoming event date before the selected date
            var nearestEventDate = GetNearestEventDate(selectedDate);

            // Check if the date has an event
            if (nearestEventDate.HasValue)
            {
                // Retrieve the event name and date
                selectedEventName = events[nearestEventDate.Value];
                selectedEventDate = nearestEventDate.Value;

                // Display the event name in the TextBox
                EventName.Text = selectedEventName;

                // Update countdown for the selected date
                UpdateCountdownForSelectedDate();
            }
            else
            {
                // Clear the event name and countdown
                EventName.Clear();
                lblCountdown.Text = "No Event";
            }
        }

        private DateTime? GetNearestEventDate(DateTime selectedDate)
        {
            // Find the nearest upcoming event date before the selected date
            var upcomingEventDates = events.Keys
                .Where(date => date > selectedDate)
                .OrderBy(date => date)
                .ToList();

            if (upcomingEventDates.Any())
            {
                return upcomingEventDates.First();
            }

            return null;
        }

        private void UpdateCountdownForSelectedDate()
        {
            // Find all upcoming events after the selected date
            var upcomingEventDates = events.Keys
                .Where(date => date > MonthCalendar.SelectionStart)
                .OrderBy(date => date)
                .ToList();

            // Display the countdown for each upcoming event
            if (upcomingEventDates.Any())
            {
                StringBuilder countdownText = new StringBuilder();
                foreach (var eventDate in upcomingEventDates)
                {
                    var countdown = eventDate - MonthCalendar.SelectionStart;
                    countdownText.AppendLine($"{events[eventDate]}: {countdown.Days} days");
                }

                lblCountdown.Text = "Countdown to: \n" + countdownText.ToString();
            }
            else
            {
                lblCountdown.Text = "No upcoming events";
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Update countdown in real-time
            UpdateCountdownForSelectedDate();
        }
    }
}
