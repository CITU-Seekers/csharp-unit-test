namespace CodeChum.Tests
{
    public class TaskTrackerWithStatusTest
    {
        TaskTrackerWithStatus? form;
        ListBox? ToDoList, InProgressList, FinishedList;
        TextBox? TaskName;
        Button? btnAdd, toProgress, backtoTODO, toFinished, backtoProgress;
        StatusStrip? ProgressStatusStrip;
        ToolStripProgressBar? ProgressBar;
        ToolStripStatusLabel? ProgressLabel;

        public TaskTrackerWithStatusTest()
        {
            form = new TaskTrackerWithStatus();
            form.Show();
            ToDoList = (ListBox)TestUtils.GetControlNamed(form, "ToDoList", true);
            InProgressList = (ListBox)TestUtils.GetControlNamed(form, "InProgressList", true);
            FinishedList = (ListBox)TestUtils.GetControlNamed(form, "FinishedList", true);
            TaskName = (TextBox)TestUtils.GetControlNamed(form, "TaskName", true);
            btnAdd = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
            ProgressStatusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "ProgressStatusStrip", true);
            toProgress = (Button)TestUtils.GetControlNamed(form, "toProgress", true);
            backtoTODO = (Button)TestUtils.GetControlNamed(form, "backtoTODO", true);
            toFinished = (Button)TestUtils.GetControlNamed(form, "toFinished", true);
            backtoProgress = (Button)TestUtils.GetControlNamed(form, "backtoProgress", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(ToDoList);
            Assert.NotNull(InProgressList);
            Assert.NotNull(FinishedList);
            Assert.NotNull(TaskName);
            Assert.NotNull(btnAdd);
            Assert.NotNull(ProgressStatusStrip);
        }

        [Fact]
        public void ShouldHaveStatusStripAndAllStatusStripItems()
        {
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            Assert.NotNull(ProgressBar);
            Assert.NotNull(ProgressLabel);
        }

        [Fact]
        public void ShouldAddTaskToToDoList()
        {
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            TaskName.Text = "Test Task";
            btnAdd.PerformClick();
            Assert.Equal("Test Task", ToDoList.Items[0]);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldMoveTaskToInProgressList()
        {
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            TaskName.Text = "Test Task";
            btnAdd.PerformClick();
            ToDoList.SelectedIndex = 0;
            Assert.Equal("Test Task", ToDoList.SelectedItem);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            toProgress.PerformClick();
            Assert.Equal("Test Task", InProgressList.Items[0]);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldMoveTaskBackToToDoList()
        {
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            TaskName.Text = "Test Task";
            btnAdd.PerformClick();
            ToDoList.SelectedIndex = 0;
            Assert.Equal("Test Task", ToDoList.SelectedItem);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            toProgress.PerformClick();
            Assert.Equal("Test Task", InProgressList.Items[0]);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            InProgressList.SelectedIndex = 0;
            backtoTODO.PerformClick();
            Assert.Equal("Test Task", ToDoList.Items[0]);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldMoveTaskToFinishedList()
        {
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            TaskName.Text = "Test Task";
            btnAdd.PerformClick();
            ToDoList.SelectedIndex = 0;
            Assert.Equal("Test Task", ToDoList.SelectedItem);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            toProgress.PerformClick();
            Assert.Equal("Test Task", InProgressList.Items[0]);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            InProgressList.SelectedIndex = 0;
            toFinished.PerformClick();
            Assert.Equal("Test Task", FinishedList.Items[0]);
            Assert.Equal("Progress: 1 / 1", ProgressLabel.Text);
            Assert.Equal(100, ProgressBar.Value);
        }

        [Fact]
        public void ShouldMoveTaskBackToInProgressList()
        {
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            TaskName.Text = "Test Task";
            btnAdd.PerformClick();
            ToDoList.SelectedIndex = 0;
            Assert.Equal("Test Task", ToDoList.SelectedItem);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            toProgress.PerformClick();
            Assert.Equal("Test Task", InProgressList.Items[0]);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            InProgressList.SelectedIndex = 0;
            toFinished.PerformClick();
            Assert.Equal("Test Task", FinishedList.Items[0]);
            Assert.Equal("Progress: 1 / 1", ProgressLabel.Text);
            Assert.Equal(100, ProgressBar.Value);

            FinishedList.SelectedIndex = 0;
            backtoProgress.PerformClick();
            Assert.Equal("Test Task", InProgressList.Items[0]);
            Assert.Equal("Progress: 0 / 1", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldAddMultipleTasksToToDoList()
        {
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            TaskName.Text = "Test Task 1";
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 2";
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 3";
            btnAdd.PerformClick();
            Assert.Equal("Test Task 1", ToDoList.Items[0]);
            Assert.Equal("Test Task 2", ToDoList.Items[1]);
            Assert.Equal("Test Task 3", ToDoList.Items[2]);
            Assert.Equal("Progress: 0 / 3", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldMoveMultipleTasksToInProgressList()
        {
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            TaskName.Text = "Test Task 1";
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 2";
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 3";
            btnAdd.PerformClick();
            Assert.Equal("Test Task 1", ToDoList.Items[0]);
            Assert.Equal("Test Task 2", ToDoList.Items[1]);
            Assert.Equal("Test Task 3", ToDoList.Items[2]);
            Assert.Equal("Progress: 0 / 3", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            ToDoList.SelectedIndex = 0;
            toProgress.PerformClick();
            Assert.Equal("Test Task 1", InProgressList.Items[0]);
            Assert.Equal("Progress: 0 / 3", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            ToDoList.SelectedIndex = 0;
            toProgress.PerformClick();
            Assert.Equal("Test Task 2", InProgressList.Items[1]);
            Assert.Equal("Progress: 0 / 3", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            ToDoList.SelectedIndex = 0;
            toProgress.PerformClick();
            Assert.Equal("Test Task 3", InProgressList.Items[2]);
            Assert.Equal("Progress: 0 / 3", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldMoveMultipleTasksToFinishedList()
        {
            ProgressLabel = ProgressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            ProgressBar = ProgressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            TaskName.Text = "Test Task 1";
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 2";
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 3";
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 4";
            btnAdd.PerformClick();
            Assert.Equal("Test Task 1", ToDoList.Items[0]);
            Assert.Equal("Test Task 2", ToDoList.Items[1]);
            Assert.Equal("Test Task 3", ToDoList.Items[2]);
            Assert.Equal("Progress: 0 / 4", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            ToDoList.SelectedIndex = 0;
            toProgress.PerformClick();
            Assert.Equal("Test Task 1", InProgressList.Items[0]);
            Assert.Equal("Progress: 0 / 4", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            ToDoList.SelectedIndex = 0;
            toProgress.PerformClick();
            Assert.Equal("Test Task 2", InProgressList.Items[1]);
            Assert.Equal("Progress: 0 / 4", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            ToDoList.SelectedIndex = 0;
            toProgress.PerformClick();
            Assert.Equal("Test Task 3", InProgressList.Items[2]);
            Assert.Equal("Progress: 0 / 4", ProgressLabel.Text);
            Assert.Equal(0, ProgressBar.Value);

            InProgressList.SelectedIndex = 0;
            toFinished.PerformClick();
            Assert.Equal("Test Task 1", FinishedList.Items[0]);
            Assert.Equal("Progress: 1 / 4", ProgressLabel.Text);
            Assert.Equal(25, ProgressBar.Value);

            InProgressList.SelectedIndex = 0;
            toFinished.PerformClick();
            Assert.Equal("Test Task 2", FinishedList.Items[1]);
            Assert.Equal("Progress: 2 / 4", ProgressLabel.Text);
            Assert.Equal(50, ProgressBar.Value);

        }
    }
}
