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
    public partial class TaskTrackerWithStatus : Form
    {
        public TaskTrackerWithStatus()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            toDoListBox.Items.Add(taskNameTextBox.Text);
            taskNameTextBox.Text = "";
            SetProgress();
        }

        private void toProgress_Click(object sender, EventArgs e)
        {
            inProgressListBox.Items.Add(toDoListBox.SelectedItem);
            toDoListBox.Items.Remove(toDoListBox.SelectedItem);
            SetProgress();
        }

        private void backtoTODO_Click(object sender, EventArgs e)
        {
            toDoListBox.Items.Add(inProgressListBox.SelectedItem);
            inProgressListBox.Items.Remove(inProgressListBox.SelectedItem);
            SetProgress();
        }

        private void toFinished_Click(object sender, EventArgs e)
        {
            finishedListBox.Items.Add(inProgressListBox.SelectedItem);
            inProgressListBox.Items.Remove(inProgressListBox.SelectedItem);
            SetProgress();
        }

        private void backtoProgress_Click(object sender, EventArgs e)
        {
            inProgressListBox.Items.Add(finishedListBox.SelectedItem);
            finishedListBox.Items.Remove(finishedListBox.SelectedItem);
            SetProgress();
        }

        private void SetProgress()
        {
            int totalTasks = toDoListBox.Items.Count + inProgressListBox.Items.Count + finishedListBox.Items.Count;
            int finishedTasks = finishedListBox.Items.Count;
            int progress = (int)Math.Round((double)finishedTasks / totalTasks * 100);
            progressBar.Value = progress;
            progressLabel.Text = $"Progress: {finishedTasks} / {totalTasks}";
        }
    }
}
