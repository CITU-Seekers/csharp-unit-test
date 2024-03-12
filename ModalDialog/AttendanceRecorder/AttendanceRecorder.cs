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
    public partial class AttendanceRecorder : Form
    {
        public AttendanceCheckerForm AttendanceCheckerForm { get; set; }
        public EmployeeRegistrationForm EmployeeRegistrationForm { get; set; }
        public AttendanceRecorder()
        {
            InitializeComponent();
            AttendanceCheckerForm= new AttendanceCheckerForm();
            EmployeeRegistrationForm= new EmployeeRegistrationForm();
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Equals("registrationButton"))
                this.EmployeeRegistrationForm.ShowDialog();
            else if (button.Name.Equals("checkerButton"))
                this.AttendanceCheckerForm.ShowDialog();
            else
                this.Close();
        }
    }
}
