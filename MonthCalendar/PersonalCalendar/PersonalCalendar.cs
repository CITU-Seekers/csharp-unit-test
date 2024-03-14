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
    public partial class PersonalCalendar : Form
    {
        Events events;
        public PersonalCalendar()
        {
            InitializeComponent();
            events = new Events();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            if (eventNameTextBox.Text.Length != 0)
            {
                // Use the DateTime object directly
                DateTime date = personalMonthCalendar.SelectionRange.Start;

                string dateString = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month)
                    + " " + date.Day + ", " + date.Year;

                events.AddEvent(dateString, eventNameTextBox.Text);
                eventLabel.Text = events.RetrieveEvent(dateString);
            }
        }

        private void RetrieveEventButton_Click(object sender, EventArgs e)
        {
            DateTime date = personalMonthCalendar.SelectionRange.Start;
            string dateString = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month) + " " + date.Day + ", " + date.Year;

            eventLabel.Text = events.RetrieveEvent(dateString);
        }

    }
}
