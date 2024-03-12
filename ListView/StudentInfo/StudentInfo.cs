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
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = studentIDTextBox.Text;
            string name = studentNameTextBox.Text;
            string dob = birthDayDateTimePicker.Value.ToShortDateString();
            string courseYear = courseComboBox.SelectedItem.ToString() + " - " + yearComboBox.SelectedItem.ToString();

            string[] row = { id, name, dob, courseYear };
            studentListView.Items.Add(new ListViewItem(row));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in studentListView.SelectedItems)
            {
                studentListView.Items.Remove(item);
            }
        }
    }
}
