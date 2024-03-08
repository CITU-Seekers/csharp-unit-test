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
            ToDoList.Items.Add(TaskName.Text);
            TaskName.Text = "";
            SetProgress();
        }

        private void toProgress_Click(object sender, EventArgs e)
        {
            InProgressList.Items.Add(ToDoList.SelectedItem);
            ToDoList.Items.Remove(ToDoList.SelectedItem);
            SetProgress();
        }

        private void backtoTODO_Click(object sender, EventArgs e)
        {
            ToDoList.Items.Add(InProgressList.SelectedItem);
            InProgressList.Items.Remove(InProgressList.SelectedItem);
            SetProgress();
        }

        private void toFinished_Click(object sender, EventArgs e)
        {
            FinishedList.Items.Add(InProgressList.SelectedItem);
            InProgressList.Items.Remove(InProgressList.SelectedItem);
            SetProgress();
        }

        private void backtoProgress_Click(object sender, EventArgs e)
        {
            InProgressList.Items.Add(FinishedList.SelectedItem);
            FinishedList.Items.Remove(FinishedList.SelectedItem);
            SetProgress();
        }

        private void SetProgress()
        {
            int totalTasks = ToDoList.Items.Count + InProgressList.Items.Count + FinishedList.Items.Count;
            int finishedTasks = FinishedList.Items.Count;
            int progress = (int)Math.Round((double)finishedTasks / totalTasks * 100);
            ProgressBar.Value = progress;
            ProgressLabel.Text = $"Progress: {finishedTasks} / {totalTasks}";
        }
    }
}
