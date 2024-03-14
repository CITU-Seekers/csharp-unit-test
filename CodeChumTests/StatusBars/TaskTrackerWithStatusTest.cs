namespace CodeChum.Tests
{
    public class TaskTrackerWithStatusTest
    {
        TaskTrackerWithStatus? form;
        ListBox? toDoListBox, inProgressListBox, finishedListBox;
        TextBox? taskNameTextBox;
        Button? addButton, toDoToInProgressButton, inProgressToToDoButton, inProgressToFinishedButton, finishedToInProgressButton;
        StatusStrip? progressStatusStrip;
        ToolStripProgressBar? progressBar;
        ToolStripStatusLabel? progressLabel;

        public TaskTrackerWithStatusTest()
        {
            form = new TaskTrackerWithStatus();
            form.Show();
            toDoListBox = (ListBox)TestUtils.GetControlNamed(form, "toDoListBox", true);
            inProgressListBox = (ListBox)TestUtils.GetControlNamed(form, "inProgressListBox", true);
            finishedListBox = (ListBox)TestUtils.GetControlNamed(form, "finishedListBox", true);
            taskNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "taskNameTextBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            progressStatusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "progressStatusStrip", true);
            toDoToInProgressButton = (Button)TestUtils.GetControlNamed(form, "toDoToInProgressButton", true);
            inProgressToToDoButton = (Button)TestUtils.GetControlNamed(form, "inProgressToToDoButton", true);
            inProgressToFinishedButton = (Button)TestUtils.GetControlNamed(form, "inProgressToFinishedButton", true);
            finishedToInProgressButton = (Button)TestUtils.GetControlNamed(form, "finishedToInProgressButton", true);
        }

        [Fact]
        // Description: Should have all the controls `toDoListBox`, `inProgressListBox`, `finishedListBox`, `taskNameTextBox`, `addButton`, and `progressStatusStrip`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(toDoListBox);
            Assert.NotNull(inProgressListBox);
            Assert.NotNull(finishedListBox);
            Assert.NotNull(taskNameTextBox);
            Assert.NotNull(addButton);
            Assert.NotNull(progressStatusStrip);
        }

        [Fact]
        // Description: Should have all the controls `progressBar` and `progressLabel` in `progressStatusStrip`.
        public void ShouldHaveStatusStripAndAllStatusStripItems()
        {
            progressBar = progressStatusStrip.Items["progressBar"] as ToolStripProgressBar;
            progressLabel = progressStatusStrip.Items["progressLabel"] as ToolStripStatusLabel;
            Assert.NotNull(progressBar);
            Assert.NotNull(progressLabel);
        }

        [Fact]
        // Description: Should have "Test Task" in `toDoListBox` when "Test Task" is added to the `taskNameTextBox` with "Progress: 0 / 1" in `progressLabel` and 0 in `progressBar` when the `addButton` is clicked.
        public void ShouldAddTaskToToDoList()
        {
            progressLabel = progressStatusStrip.Items["progressLabel"] as ToolStripStatusLabel;
            progressBar = progressStatusStrip.Items["progressBar"] as ToolStripProgressBar;

            taskNameTextBox.Text = "Test Task";
            addButton.PerformClick();
            Assert.Equal("Test Task", toDoListBox.Items[0]);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);
        }

        [Fact]
        // Description: Should move "Test Task" from `toDoListBox` to `inProgressListBox` when "Test Task" is selected in `toDoListBox` and the `toDoToInProgressButton` is clicked.
        public void ShouldMoveTaskToInProgressList()
        {
            progressLabel = progressStatusStrip.Items["progressLabel"] as ToolStripStatusLabel;
            progressBar = progressStatusStrip.Items["progressBar"] as ToolStripProgressBar;

            taskNameTextBox.Text = "Test Task";
            addButton.PerformClick();
            toDoListBox.SelectedIndex = 0;
            Assert.Equal("Test Task", toDoListBox.SelectedItem);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task", inProgressListBox.Items[0]);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);
        }

        [Fact]
        // Description: Should move "Test Task" from `inProgressListBox` to `toDoListBox` when "Test Task" is selected in `inProgressListBox` and the `inProgressToToDoButton` is clicked.
        public void ShouldMoveTaskBackToToDoList()
        {
            progressLabel = progressStatusStrip.Items["ProgressLabel"] as ToolStripStatusLabel;
            progressBar = progressStatusStrip.Items["ProgressBar"] as ToolStripProgressBar;

            taskNameTextBox.Text = "Test Task";
            addButton.PerformClick();
            toDoListBox.SelectedIndex = 0;
            Assert.Equal("Test Task", toDoListBox.SelectedItem);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task", inProgressListBox.Items[0]);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            inProgressListBox.SelectedIndex = 0;
            inProgressToToDoButton.PerformClick();
            Assert.Equal("Test Task", toDoListBox.Items[0]);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);
        }

        [Fact]
        // Description: Should move "Test Task" from `inProgressListBox` to `finishedListBox` when "Test Task" is selected in `inProgressListBox` and the `inProgressToFinishedButton` is clicked.
        public void ShouldMoveTaskToFinishedList()
        {
            progressLabel = progressStatusStrip.Items["progressLabel"] as ToolStripStatusLabel;
            progressBar = progressStatusStrip.Items["progressBar"] as ToolStripProgressBar;

            taskNameTextBox.Text = "Test Task";
            addButton.PerformClick();
            toDoListBox.SelectedIndex = 0;
            Assert.Equal("Test Task", toDoListBox.SelectedItem);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task", inProgressListBox.Items[0]);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            inProgressListBox.SelectedIndex = 0;
            inProgressToFinishedButton.PerformClick();
            Assert.Equal("Test Task", finishedListBox.Items[0]);
            Assert.Equal("Progress: 1 / 1", progressLabel.Text);
            Assert.Equal(100, progressBar.Value);
        }

        [Fact]
        // Description: Should move "Test Task" from `finishedListBox` to `inProgressListBox` when "Test Task" is selected in `finishedListBox` and the `finishedToInProgressButton` is clicked.
        public void ShouldMoveTaskBackToInProgressList()
        {
            progressLabel = progressStatusStrip.Items["progressLabel"] as ToolStripStatusLabel;
            progressBar = progressStatusStrip.Items["progressBar"] as ToolStripProgressBar;

            taskNameTextBox.Text = "Test Task";
            addButton.PerformClick();
            toDoListBox.SelectedIndex = 0;
            Assert.Equal("Test Task", toDoListBox.SelectedItem);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task", inProgressListBox.Items[0]);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            inProgressListBox.SelectedIndex = 0;
            inProgressToFinishedButton.PerformClick();
            Assert.Equal("Test Task", finishedListBox.Items[0]);
            Assert.Equal("Progress: 1 / 1", progressLabel.Text);
            Assert.Equal(100, progressBar.Value);

            finishedListBox.SelectedIndex = 0;
            finishedToInProgressButton.PerformClick();
            Assert.Equal("Test Task", inProgressListBox.Items[0]);
            Assert.Equal("Progress: 0 / 1", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);
        }

        [Fact]
        // Description: Should have "Test Task 1", "Test Task 2", and "Test Task 3" in `toDoListBox` when "Test Task 1", "Test Task 2", and "Test Task 3" are added to the `taskNameTextBox` with "Progress: 0 / 3" in `progressLabel` and 0 in `progressBar` when the `addButton` is clicked.
        public void ShouldAddMultipleTasksToToDoList()
        {
            progressLabel = progressStatusStrip.Items["progressLabel"] as ToolStripStatusLabel;
            progressBar = progressStatusStrip.Items["progressBar"] as ToolStripProgressBar;

            taskNameTextBox.Text = "Test Task 1";
            addButton.PerformClick();
            taskNameTextBox.Text = "Test Task 2";
            addButton.PerformClick();
            taskNameTextBox.Text = "Test Task 3";
            addButton.PerformClick();
            Assert.Equal("Test Task 1", toDoListBox.Items[0]);
            Assert.Equal("Test Task 2", toDoListBox.Items[1]);
            Assert.Equal("Test Task 3", toDoListBox.Items[2]);
            Assert.Equal("Progress: 0 / 3", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);
        }

        [Fact]
        // Description: Should move "Test Task 1", "Test Task 2", and "Test Task 3" from `toDoListBox` to `inProgressListBox` when "Test Task 1", "Test Task 2", and "Test Task 3" are selected in `toDoListBox` and the `toDoToInProgressButton` is clicked.
        public void ShouldMoveMultipleTasksToInProgressList()
        {
            progressLabel = progressStatusStrip.Items["progressLabel"] as ToolStripStatusLabel;
            progressBar = progressStatusStrip.Items["progressBar"] as ToolStripProgressBar;

            taskNameTextBox.Text = "Test Task 1";
            addButton.PerformClick();
            taskNameTextBox.Text = "Test Task 2";
            addButton.PerformClick();
            taskNameTextBox.Text = "Test Task 3";
            addButton.PerformClick();
            Assert.Equal("Test Task 1", toDoListBox.Items[0]);
            Assert.Equal("Test Task 2", toDoListBox.Items[1]);
            Assert.Equal("Test Task 3", toDoListBox.Items[2]);
            Assert.Equal("Progress: 0 / 3", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoListBox.SelectedIndex = 0;
            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task 1", inProgressListBox.Items[0]);
            Assert.Equal("Progress: 0 / 3", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoListBox.SelectedIndex = 0;
            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task 2", inProgressListBox.Items[1]);
            Assert.Equal("Progress: 0 / 3", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoListBox.SelectedIndex = 0;
            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task 3", inProgressListBox.Items[2]);
            Assert.Equal("Progress: 0 / 3", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);
        }

        [Fact]
        // Description: Should move "Test Task 1", "Test Task 2", "Test Task 3", and "Test Task 4" from `toDoListBox` to `finishedListBox` when "Test Task 1", "Test Task 2", "Test Task 3", and "Test Task 4" are selected in `toDoListBox` and the `toDoToInProgressButton` is clicked then `inProgressToFinishedButton` is clicked.
        public void ShouldMoveMultipleTasksToFinishedList()
        {
            progressLabel = progressStatusStrip.Items["progressLabel"] as ToolStripStatusLabel;
            progressBar = progressStatusStrip.Items["progressBar"] as ToolStripProgressBar;

            taskNameTextBox.Text = "Test Task 1";
            addButton.PerformClick();
            taskNameTextBox.Text = "Test Task 2";
            addButton.PerformClick();
            taskNameTextBox.Text = "Test Task 3";
            addButton.PerformClick();
            taskNameTextBox.Text = "Test Task 4";
            addButton.PerformClick();
            Assert.Equal("Test Task 1", toDoListBox.Items[0]);
            Assert.Equal("Test Task 2", toDoListBox.Items[1]);
            Assert.Equal("Test Task 3", toDoListBox.Items[2]);
            Assert.Equal("Progress: 0 / 4", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoListBox.SelectedIndex = 0;
            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task 1", inProgressListBox.Items[0]);
            Assert.Equal("Progress: 0 / 4", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoListBox.SelectedIndex = 0;
            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task 2", inProgressListBox.Items[1]);
            Assert.Equal("Progress: 0 / 4", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            toDoListBox.SelectedIndex = 0;
            toDoToInProgressButton.PerformClick();
            Assert.Equal("Test Task 3", inProgressListBox.Items[2]);
            Assert.Equal("Progress: 0 / 4", progressLabel.Text);
            Assert.Equal(0, progressBar.Value);

            inProgressListBox.SelectedIndex = 0;
            inProgressToFinishedButton.PerformClick();
            Assert.Equal("Test Task 1", finishedListBox.Items[0]);
            Assert.Equal("Progress: 1 / 4", progressLabel.Text);
            Assert.Equal(25, progressBar.Value);

            inProgressListBox.SelectedIndex = 0;
            inProgressToFinishedButton.PerformClick();
            Assert.Equal("Test Task 2", finishedListBox.Items[1]);
            Assert.Equal("Progress: 2 / 4", progressLabel.Text);
            Assert.Equal(50, progressBar.Value);

        }
    }
}
