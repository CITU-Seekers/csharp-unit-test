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
    public partial class TaskTracker : Form
    {
        public TaskTracker()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            toDoListBox.Items.Add(taskNameTextBox.Text);
            taskNameTextBox.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            finishedListBox.Items.Add(toDoListBox.SelectedItem);
            toDoListBox.Items.Remove(toDoListBox.SelectedItem);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            toDoListBox.Items.Add(finishedListBox.SelectedItem);
            finishedListBox.Items.Remove(finishedListBox.SelectedItem);
        }
    }
}
