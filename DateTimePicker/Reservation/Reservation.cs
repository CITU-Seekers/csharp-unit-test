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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            // Get the date and time from the DateTimePicker
            DateTime date = DatePicker.Value;

            // Get the time from the ComboBox 
            string time = cboTime.SelectedItem.ToString();

            // Display the date and time in the label

            ReservationSummary.Text = "Your reservation for " + EventName.Text + "\nis on " + date.ToLongDateString() + "\nat " + time;
        }
    }
}
