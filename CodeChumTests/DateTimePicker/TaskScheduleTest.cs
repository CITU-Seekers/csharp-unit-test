namespace CodeChum.Tests
{
    public class TaskScheduleTest
    {
        TaskSchedule? form;
        Button? btnAdd;
        TextBox? TaskName;
        DateTimePicker? DatePicker;
        Label? lblToDoList;

        public TaskScheduleTest()
        {
            form = new TaskSchedule();
            form.Show();
            btnAdd = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
            TaskName = (TextBox)TestUtils.GetControlNamed(form, "TaskName", true);
            DatePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "DatePicker", true);
            lblToDoList = (Label)TestUtils.GetControlNamed(form, "lblToDoList", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(btnAdd);
            Assert.NotNull(TaskName);
            Assert.NotNull(DatePicker);
            Assert.NotNull(lblToDoList);
        }

        [Fact]
        public void ShouldAddTask()
        {
            TaskName.Text = "Test Task";
            DatePicker.Value = new DateTime(2021, 1, 1);
            btnAdd.PerformClick();
            Assert.Contains("Friday, January 1, 2021", lblToDoList.Text);
        }

        [Fact]
        public void ShouldAddMultipleTasks()
        {
            TaskName.Text = "Test Task";
            DatePicker.Value = new DateTime(2021, 1, 1);
            btnAdd.PerformClick();
            TaskName.Text = "Test Task 2";
            DatePicker.Value = new DateTime(2021, 1, 2);
            btnAdd.PerformClick();
            Assert.Contains("Friday, January 1, 2021", lblToDoList.Text);
            Assert.Contains("Saturday, January 2, 2021", lblToDoList.Text);
        }
    }
}
