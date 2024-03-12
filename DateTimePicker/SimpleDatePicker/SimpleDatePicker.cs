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
    public partial class SimpleDatePicker : Form
    {
        public SimpleDatePicker()
        {
            InitializeComponent();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = exactDateTimePicker.Value;
            dateLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month) + " " +
                date.Day + ", " + date.Year;

        }
    }
}
