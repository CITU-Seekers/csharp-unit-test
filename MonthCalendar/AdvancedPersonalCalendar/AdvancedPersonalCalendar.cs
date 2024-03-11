using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class AdvancedPersonalCalendar : Form
    {
        private Dictionary<DateTime, string> recurringEvents = new Dictionary<DateTime, string>();
        public AdvancedPersonalCalendar()
        {
            InitializeComponent();
            cboFrequency.SelectedIndex = 0;

            lblEvent.Text = "No Event";

            // Attach the event handler for the Add button
            btnAdd.Click += btnAdd_Click;
            MonthCalendar.DateSelected += MonthCalendar_DateSelected;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the selected date from the MonthCalendar control
            DateTime selectedDate = MonthCalendar.SelectionStart;

            // Get the event name from the TextBox
            string eventName = EventName.Text;

            // Get the selected recurrence frequency index
            int selectedIndex = cboFrequency.SelectedIndex;

            // Add events based on the selected recurrence frequency
            switch (selectedIndex)
            {
                case 0: // "None"
                        // Add a one-time event
                    AddEvent(selectedDate, eventName);
                    break;

                case 1: // "Daily"
                        // Add events for the next 7 days
                    for (int i = 0; i < 7; i++)
                    {
                        AddEvent(selectedDate.AddDays(i), eventName);
                    }
                    break;

                case 2: // "Every Weekdays"
                        // Add events for every weekday in the next 7 days
                    for (int i = 0; i < 7; i++)
                    {
                        DateTime currentDate = selectedDate.AddDays(i);
                        if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                        {
                            AddEvent(currentDate, eventName);
                        }
                    }
                    break;

                case 3: // "Every Weekends"
                        // Add events for every weekend day in the next 7 days
                    for (int i = 0; i < 7; i++)
                    {
                        DateTime currentDate = selectedDate.AddDays(i);
                        if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            AddEvent(currentDate, eventName);
                        }
                    }
                    break;

                case 4: // "Weekly"
                        // Add events for the next 4 weeks
                    for (int i = 0; i < 4; i++)
                    {
                        AddEvent(selectedDate.AddDays(i * 7), eventName);
                    }
                    break;
                case 5: // Monthly
                    // Add events for the next 4 weeks
                    for (int i = 0; i < 4; i++)
                    {
                        AddEvent(selectedDate.AddDays(i * 14), eventName);
                    }
                    break;

                case 6: // "Yearly"
                        // Add events for the next 12 months
                    for (int i = 0; i < 12; i++)
                    {
                        AddEvent(selectedDate.AddMonths(i), eventName);
                    }
                    break;

                default:
                    break;
            }

            // Visual feedback: Highlight the dates on the calendar
            UpdateCalendarHighlights();

            // How to get the selected recurrence frequency text
            
            if(cboFrequency.SelectedItem == "None")
            {
                lblEvent.Text = eventName;
            }
            else
            {
                lblEvent.Text = cboFrequency.SelectedItem.ToString() + " - " + eventName;
            }
            
            
        }

        private void AddEvent(DateTime date, string eventName)
        {
            // Add the event to the dictionary
            recurringEvents[date] = eventName;

            // Visual feedback: Highlight the dates on the calendar
            UpdateCalendarHighlights();
        }

        private void UpdateCalendarHighlights()
        {
            // Clear previous highlights
            MonthCalendar.RemoveAllBoldedDates();

            // Highlight dates with scheduled events
            foreach (var date in recurringEvents.Keys)
            {
                MonthCalendar.AddBoldedDate(date);
            }

            // Update the display
            MonthCalendar.UpdateBoldedDates();
        }

        //When the user clicks on a date, display the event name in the TextBox
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            EventName.Text = "";
            // Get the selected date
            DateTime selectedDate = MonthCalendar.SelectionStart;

            // Check if the date has an event
            if (recurringEvents.ContainsKey(selectedDate))
            {
                // Display the event name
                lblEvent.Text = recurringEvents[selectedDate];
            }
            else
            {
                // Clear the event name
                lblEvent.Text = "No Event";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete the event from the selected date
            DateTime selectedDate = MonthCalendar.SelectionStart;
            if (recurringEvents.ContainsKey(selectedDate))
            {
                recurringEvents.Remove(selectedDate);
            }

            UpdateCalendarHighlights();
        }
    }
}
