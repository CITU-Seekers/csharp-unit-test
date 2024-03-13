namespace CodeChum.Tests
{
    public class TaskScheduleTest
    {
        TaskSchedule? form;
        Button? addButton;
        TextBox? taskTextBox;
        DateTimePicker? dateTimePicker;
        Label? toDoListLabel;

        public TaskScheduleTest()
        {
            form = new TaskSchedule();
            form.Show();
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            taskTextBox = (TextBox)TestUtils.GetControlNamed(form, "taskTextBox", true);
            dateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "dateTimePicker", true);
            toDoListLabel = (Label)TestUtils.GetControlNamed(form, "toDoListLabel", true);
        }

        [Fact]
        // Description: Should have all controls `addButton`, `taskTextBox`, `dateTimePicker`, and `toDoListLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(addButton);
            Assert.NotNull(taskTextBox);
            Assert.NotNull(dateTimePicker);
            Assert.NotNull(toDoListLabel);
        }

        [Fact]
        // Description: Should add task "Test Task" with date "Friday, January 1, 2021" when `taskTextBox` is set to "Test Task" and `dateTimePicker` is set to "1/1/2021" and `addButton` is clicked.
        public void ShouldAddTask()
        {
            taskTextBox.Text = "Test Task";
            dateTimePicker.Value = new DateTime(2021, 1, 1);
            addButton.PerformClick();
            Assert.Contains("Friday, January 1, 2021", toDoListLabel.Text);
        }

        [Fact]
        // Description: Should add tasks "Test Task" with date "Friday, January 1, 2021" and "Test Task 2" with date "Saturday, January 2, 2021" when `taskTextBox` is set to "Test Task" and `dateTimePicker` is set to "1/1/2021" and `addButton` is clicked and `taskTextBox` is set to "Test Task 2" and `dateTimePicker` is set to "1/2/2021" and `addButton` is clicked.
        public void ShouldAddMultipleTasks()
        {
            taskTextBox.Text = "Test Task";
            dateTimePicker.Value = new DateTime(2021, 1, 1);
            addButton.PerformClick();
            taskTextBox.Text = "Test Task 2";
            dateTimePicker.Value = new DateTime(2021, 1, 2);
            addButton.PerformClick();
            Assert.Contains("Friday, January 1, 2021", toDoListLabel.Text);
            Assert.Contains("Saturday, January 2, 2021", toDoListLabel.Text);
        }
    }
}
