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
    public partial class TimeConverter : Form
    {
        public TimeConverter()
        {
            InitializeComponent();
        }
        private void SetTime()
        {
            int hour = (int) HourNumericControl.Value;
            string dayOrNight = hour < 12 ? "AM" : "PM";

            if (hour == 0)
            {
                hour = 12;
            }
            else if (hour > 12)
            {
                hour -= 12;
            }

            int minute = (int)MinuteNumericControl.Value;

            TwelveHourLabel.Text = hour + ":" + minute.ToString("00") + " " + dayOrNight;
        }
        private void HourNumericControl_ValueChanged(object sender, EventArgs e)
        {
            SetTime();
        }

        private void MinuteNumericControl_ValueChanged(object sender, EventArgs e)
        {
            SetTime();
        }
    }
}
