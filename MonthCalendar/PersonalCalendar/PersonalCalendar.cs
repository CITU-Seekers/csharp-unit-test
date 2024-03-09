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
            if (EventNameTextBox.Text.Length != 0)
            {
                DateTime date = DateTime.ParseExact(MonthCalendar.SelectionRange.Start.ToShortDateString(), "dd/MM/yyyy", null);
             
                
                string dateString = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month) 
                    + " " + date.Day + ", " + date.Year;
                
                events.AddEvent(dateString, EventNameTextBox.Text);
                EventLabel.Text = events.RetrieveEvent(dateString);
            }
        }

        private void RetrieveEventButton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(MonthCalendar.SelectionRange.Start.ToShortDateString(), "dd/MM/yyyy", null);
            string dateString = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month)
                   + " " + date.Day + ", " + date.Year;

            EventLabel.Text = events.RetrieveEvent(dateString);
        }
    }
}
