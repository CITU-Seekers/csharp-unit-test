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
    public partial class TaskSchedule : Form
    {
        public TaskSchedule()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskDescription = $"{TaskName.Text} - {DatePicker.Value.ToLongDateString()}";
            lblToDoList.Text += "\n" + taskDescription;
        }
    }
}
