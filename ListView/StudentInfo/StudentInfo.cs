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
            string id = StudentID.Text;
            string name = StudentName.Text;
            string dob = BirthDatePicker.Value.ToShortDateString();
            string courseYear = cboCourse.SelectedItem.ToString() + " - " + cboYear.SelectedItem.ToString();

            string[] row = { id, name, dob, courseYear };
            StudentDB.Items.Add(new ListViewItem(row));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in StudentDB.SelectedItems)
            {
                StudentDB.Items.Remove(item);
            }
        }
    }
}
