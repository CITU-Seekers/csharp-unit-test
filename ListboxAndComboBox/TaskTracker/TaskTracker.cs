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
            ToDoList.Items.Add(TaskName.Text);
            TaskName.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            FinishedList.Items.Add(ToDoList.SelectedItem);
            ToDoList.Items.Remove(ToDoList.SelectedItem);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            ToDoList.Items.Add(FinishedList.SelectedItem);
            FinishedList.Items.Remove(FinishedList.SelectedItem);
        }
    }
}
