namespace CodeChum.Tests
{
    public class StudentInfoTest
    {
        StudentInfo? form;
        ListView? StudentDB;
        TextBox? StudentID;
        TextBox? StudentName;
        DateTimePicker? BirthDatePicker;
        ComboBox? cboCourse;
        ComboBox? cboYear;
        Button? btnAdd;
        Button? btnRemove;

        public StudentInfoTest()
        {
            form = new StudentInfo();
            form.Show();
            StudentDB = (ListView)TestUtils.GetControlNamed(form, "StudentDB", true);
            StudentID = (TextBox)TestUtils.GetControlNamed(form, "StudentID", true);
            StudentName = (TextBox)TestUtils.GetControlNamed(form, "StudentName", true);
            BirthDatePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "BirthDatePicker", true);
            cboCourse = (ComboBox)TestUtils.GetControlNamed(form, "cboCourse", true);
            cboYear = (ComboBox)TestUtils.GetControlNamed(form, "cboYear", true);
            btnAdd = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
            btnRemove = (Button)TestUtils.GetControlNamed(form, "btnRemove", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(StudentDB);
            Assert.NotNull(StudentID);
            Assert.NotNull(StudentName);
            Assert.NotNull(BirthDatePicker);
            Assert.NotNull(cboCourse);
            Assert.NotNull(cboYear);
            Assert.NotNull(btnAdd);
            Assert.NotNull(btnRemove);
        }

        [Fact]
        public void ShouldAddStudent()
        {
            StudentID.Text = "123456";
            StudentName.Text = "John Doe";
            BirthDatePicker.Value = new DateTime(2000, 1, 1);
            cboCourse.SelectedIndex = 0;
            cboYear.SelectedIndex = 0;
            btnAdd.PerformClick();

            Assert.Equal(1, StudentDB.Items.Count);
            Assert.Equal("123456", StudentDB.Items[0].SubItems[0].Text);
            Assert.Equal("John Doe", StudentDB.Items[0].SubItems[1].Text);
            Assert.Equal("01/01/2000", StudentDB.Items[0].SubItems[2].Text);
            Assert.Equal("BSCS - 1st Year", StudentDB.Items[0].SubItems[3].Text);
        }

        [Fact]
        public void ShouldRemoveStudent()
        {
            StudentID.Text = "123456";
            StudentName.Text = "John Doe";
            BirthDatePicker.Value = new DateTime(2000, 1, 1);
            cboCourse.SelectedIndex = 0;
            cboYear.SelectedIndex = 0;
            btnAdd.PerformClick();

            StudentID.Text = "654321";
            StudentName.Text = "Jane Doe";
            BirthDatePicker.Value = new DateTime(2000, 1, 1);
            cboCourse.SelectedIndex = 0;
            cboYear.SelectedIndex = 0;
            btnAdd.PerformClick();

            StudentDB.Items[0].Selected = true;
            btnRemove.PerformClick();

            Assert.Equal(1, StudentDB.Items.Count);
            Assert.Equal("654321", StudentDB.Items[0].SubItems[0].Text);
            Assert.Equal("Jane Doe", StudentDB.Items[0].SubItems[1].Text);
            Assert.Equal("01/01/2000", StudentDB.Items[0].SubItems[2].Text);
            Assert.Equal("BSCS - 1st Year", StudentDB.Items[0].SubItems[3].Text);
        }
    }
}
