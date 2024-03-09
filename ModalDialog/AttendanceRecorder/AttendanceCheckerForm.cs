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
            int id = int.Parse(IdTextBox.Text);

            if (EmployeeList.checkEmployeeRegistration(id))
            {
                if (EmployeeList.isEmployeeAttendanceRecorded(id))
                    MessageBoxWrapper.Show("Employee attendance is already recorded.", "Notice");
                else
                {
                    EmployeeList.recordEmployeeAttendance(id);
                    MessageBoxWrapper.Show("Employee attendance is successfully recorded.", "Success");
                }
            }
            else
            {
                MessageBoxWrapper.Show("No employee with the id found.", "Invalid");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
