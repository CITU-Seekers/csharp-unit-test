namespace CodeChum.Tests
{
    public class StudentInfoTest
    {
        StudentInfo? form;
        ListView? studentListView;
        TextBox? studentIDTextBox;
        TextBox? studentNameTextBox;
        DateTimePicker? birthDayDateTimePicker;
        ComboBox? courseComboBox;
        ComboBox? yearComboBox;
        Button? addButton;
        Button? removeButton;

        public StudentInfoTest()
        {
            form = new StudentInfo();
            form.Show();
            studentListView = (ListView)TestUtils.GetControlNamed(form, "studentListView", true);
            studentIDTextBox = (TextBox)TestUtils.GetControlNamed(form, "studentIDTextBox", true);
            studentNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "studentNameTextBox", true);
            birthDayDateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "birthDayDateTimePicker", true);
            courseComboBox = (ComboBox)TestUtils.GetControlNamed(form, "courseComboBox", true);
            yearComboBox = (ComboBox)TestUtils.GetControlNamed(form, "yearComboBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            removeButton = (Button)TestUtils.GetControlNamed(form, "removeButton", true);
        }

        [Fact]
        // Description: Should have all controls `studentListView`, `studentIDTextBox`, `studentNameTextBox`, `birthDayDateTimePicker`, `courseComboBox`, `yearComboBox`, `addButton`, and `removeButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(studentListView);
            Assert.NotNull(studentIDTextBox);
            Assert.NotNull(studentNameTextBox);
            Assert.NotNull(birthDayDateTimePicker);
            Assert.NotNull(courseComboBox);
            Assert.NotNull(yearComboBox);
            Assert.NotNull(addButton);
            Assert.NotNull(removeButton);
        }

        [Fact]
        // Description: Should have all years "1st Year", "2nd Year", "3rd Year", and "4th Year" in `yearComboBox`.
        public void ShouldHaveAllYears()
        {
            var yearComboBoxItems = yearComboBox.Items.Cast<string>().ToList();

            Assert.Equal(4, yearComboBox.Items.Count);
            Assert.Contains("1st Year", yearComboBoxItems);
            Assert.Contains("2nd Year", yearComboBoxItems);
            Assert.Contains("3rd Year", yearComboBoxItems);
            Assert.Contains("4th Year", yearComboBoxItems);
        }

        [Fact]
        // Description: Should have all courses "BSCS", "BSBA", "BSIT", "BMMA", "BSCE", "BSME", "BSTM", and "BSHRM" in `courseComboBox`.
        public void ShouldHaveAllCourses()
        {
            var courseComboBoxItems = courseComboBox.Items.Cast<string>().ToList();

            Assert.Equal(8, courseComboBox.Items.Count);
            Assert.Contains("BSCS", courseComboBoxItems);
            Assert.Contains("BSBA", courseComboBoxItems);
            Assert.Contains("BSIT", courseComboBoxItems);
            Assert.Contains("BMMA", courseComboBoxItems);
            Assert.Contains("BSCE", courseComboBoxItems);
            Assert.Contains("BSME", courseComboBoxItems);
            Assert.Contains("BSTM", courseComboBoxItems);
            Assert.Contains("BSHRM", courseComboBoxItems);
        }

        [Fact]
        // Description: Should add a student with the ID "123456", name "John Doe", birthday "1/1/2000", course "BSCS", and year "1st Year" to `studentListView` when `addButton` is clicked.
        public void ShouldAddStudent()
        {
            studentIDTextBox.Text = "123456";
            studentNameTextBox.Text = "John Doe";
            birthDayDateTimePicker.Value = new DateTime(2000, 1, 1);
            courseComboBox.SelectedIndex = 0;
            yearComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            Assert.Equal(1, studentListView.Items.Count);
            Assert.Equal("123456", studentListView.Items[0].SubItems[0].Text);
            Assert.Equal("John Doe", studentListView.Items[0].SubItems[1].Text);
            Assert.Equal("1/1/2000", studentListView.Items[0].SubItems[2].Text);
            Assert.Equal("BSCS - 1st Year", studentListView.Items[0].SubItems[3].Text);
        }

        [Fact]
        // Description: Should remove a student from `studentListView` when `removeButton` is clicked.
        public void ShouldRemoveStudent()
        {
            studentIDTextBox.Text = "123456";
            studentNameTextBox.Text = "John Doe";
            birthDayDateTimePicker.Value = new DateTime(2000, 1, 1);
            courseComboBox.SelectedIndex = 0;
            yearComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            studentIDTextBox.Text = "654321";
            studentNameTextBox.Text = "Jane Doe";
            birthDayDateTimePicker.Value = new DateTime(2000, 1, 1);
            courseComboBox.SelectedIndex = 0;
            yearComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            studentListView.Items[0].Selected = true;
            removeButton.PerformClick();

            Assert.Equal(1, studentListView.Items.Count);
            Assert.Equal("654321", studentListView.Items[0].SubItems[0].Text);
            Assert.Equal("Jane Doe", studentListView.Items[0].SubItems[1].Text);
            Assert.Equal("1/1/2000", studentListView.Items[0].SubItems[2].Text);
            Assert.Equal("BSCS - 1st Year", studentListView.Items[0].SubItems[3].Text);
        }
    }
}
