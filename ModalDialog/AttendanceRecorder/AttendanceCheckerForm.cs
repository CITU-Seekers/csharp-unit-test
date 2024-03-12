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
    public partial class AttendanceCheckerForm : Form
    {
        public AttendanceCheckerForm()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            
            bool parsable = int.TryParse(idTextBox.Text, out int id);

            if (!parsable)
            {
                MessageBox.Show("Invalid id.", "Invalid");
                return;
            }
            if (EmployeeList.checkEmployeeRegistration(id))
            {
                if (EmployeeList.isEmployeeAttendanceRecorded(id))
                    MessageBox.Show("Employee attendance is already recorded.", "Notice");
                else
                {
                    EmployeeList.recordEmployeeAttendance(id);
                    MessageBox.Show("Employee attendance is successfully recorded.", "Success");
                }
            }
            else
            {
                MessageBox.Show("No employee with the id found.", "Invalid");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
