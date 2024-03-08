namespace CodeChum.Tests
{
    public class TaskTrackerTest
    {
        TaskTracker? form;
        ListBox? ToDoList;
        ListBox? FinishedList;
        TextBox? TaskName;
        Button? btnAdd;
        Button? btnDone;
        Button? btnRevert;

        public TaskTrackerTest()
        {
            form = new TaskTracker();
            form.Show();
            ToDoList = (ListBox)TestUtils.GetControlNamed(form, "ToDoList", true);
            FinishedList = (ListBox)TestUtils.GetControlNamed(form, "FinishedList", true);
            TaskName = (TextBox)TestUtils.GetControlNamed(form, "TaskName", true);
            btnAdd = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
            btnDone = (Button)TestUtils.GetControlNamed(form, "btnDone", true);
            btnRevert = (Button)TestUtils.GetControlNamed(form, "btnRevert", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(ToDoList);
            Assert.NotNull(FinishedList);
            Assert.NotNull(TaskName);
            Assert.NotNull(btnAdd);
            Assert.NotNull(btnDone);
            Assert.NotNull(btnRevert);
        }

        [Fact]
        public void ShouldAddTask()
        {
            TaskName.Text = "Test Task";
            btnAdd.PerformClick();
            Assert.Equal("Test Task", ToDoList.Items[0]);
        }

        [Fact]
        public void ShouldMoveTaskToFinished()
        {
            TaskName.Text = "Test Task";
            btnAdd.PerformClick();
            ToDoList.SelectedIndex = 0;
            btnDone.PerformClick();
            Assert.Equal("Test Task", FinishedList.Items[0]);
        }

        [Fact]
        public void ShouldMoveTaskBackToToDo()
        {
            TaskName.Text = "Test Task";
            btnAdd.PerformClick();
            ToDoList.SelectedIndex = 0;
            btnDone.PerformClick();
            FinishedList.SelectedIndex = 0;
            btnRevert.PerformClick();
            Assert.Equal("Test Task", ToDoList.Items[0]);
        }

        [Fact]
        public void ShouldAddMultipleTasks()
        {
            TaskName.Text = "Test Task 1";
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 2";
            btnAdd.PerformClick();
            Assert.Equal("Test Task 1", ToDoList.Items[0]);
            Assert.Equal("Test Task 2", ToDoList.Items[1]);
        }       

    }
}
