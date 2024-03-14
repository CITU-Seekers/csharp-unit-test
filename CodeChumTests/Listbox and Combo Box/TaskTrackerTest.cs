namespace CodeChum.Tests
{
    public class TaskTrackerTest
    {
        TaskTracker? form;
        ListBox? toDoListBox;
        ListBox? finishedListBox;
        TextBox? taskNameTextBox;
        Button? addButton;
        Button? doneButton;
        Button? revertButton;

        public TaskTrackerTest()
        {
            form = new TaskTracker();
            form.Show();
            toDoListBox = (ListBox)TestUtils.GetControlNamed(form, "toDoListBox", true);
            finishedListBox = (ListBox)TestUtils.GetControlNamed(form, "finishedListBox", true);
            taskNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "taskNameTextBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            doneButton = (Button)TestUtils.GetControlNamed(form, "doneButton", true);
            revertButton = (Button)TestUtils.GetControlNamed(form, "revertButton", true);
        }

        [Fact]
        // Description: Should have all controls `toDoListBox`, `finishedListBox`, `taskNameTextBox`, `addButton`, `doneButton`, and `revertButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(toDoListBox);
            Assert.NotNull(finishedListBox);
            Assert.NotNull(taskNameTextBox);
            Assert.NotNull(addButton);
            Assert.NotNull(doneButton);
            Assert.NotNull(revertButton);
        }

        [Fact]
        // Description: Should add a task with the name "Test Task" in `taskNameTextBox` to `toDoListBox` when `addButton` is clicked.
        public void ShouldAddTask()
        {
            taskNameTextBox.Text = "Test Task";
            addButton.PerformClick();
            Assert.Equal("Test Task", toDoListBox.Items[0]);
        }

        [Fact]
        // Description: Should move task "Test Task" from `toDoListBox` to `finishedListBox` when `doneButton` is clicked.
        public void ShouldMoveTaskToFinished()
        {
            taskNameTextBox.Text = "Test Task";
            addButton.PerformClick();
            toDoListBox.SelectedIndex = 0;
            doneButton.PerformClick();
            Assert.Equal("Test Task", finishedListBox.Items[0]);
        }

        [Fact]
        // Description: Should move task "Test Task" from `finishedListBox` to `toDoListBox` when `revertButton` is clicked.
        public void ShouldMoveTaskBackToToDo()
        {
            taskNameTextBox.Text = "Test Task";
            addButton.PerformClick();
            toDoListBox.SelectedIndex = 0;
            doneButton.PerformClick();
            finishedListBox.SelectedIndex = 0;
            revertButton.PerformClick();
            Assert.Equal("Test Task", toDoListBox.Items[0]);
        }

        [Fact]
        // Description: Should add multiple tasks to `toDoListBox`.
        public void ShouldAddMultipleTasks()
        {
            taskNameTextBox.Text = "Test Task 1";
            addButton.PerformClick();
            taskNameTextBox.Text = "Test Task 2";
            addButton.PerformClick();
            Assert.Equal("Test Task 1", toDoListBox.Items[0]);
            Assert.Equal("Test Task 2", toDoListBox.Items[1]);
        }       

    }
}
