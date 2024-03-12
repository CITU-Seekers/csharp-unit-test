namespace CodeChum.Tests
{
    public class AttendanceCheckerTests
    {
        AttendanceRecorder? form;
        AttendanceCheckerForm? checkerModal;
        EmployeeRegistrationForm? registrationModal;

        // AttendanceRecorded controls
        Button? registrationButton, checkerButton, exitButton;

        // AttendanceCheckerForm controls;
        TextBox? attendanceCheckerFormIdTextBox;
        Button? checkButton, attendanceCheckerFormCancelButton;

        // EmployeeRegistrationForm controls;
        TextBox? employeeRegistrationFormIdTextBox, nameTextBox;
        Button? registerButton, employeeRegistrationFormCancelButton;

        public AttendanceCheckerTests()
        {
            form = new AttendanceRecorder();
            form.Show();
            registrationButton = (Button)TestUtils.GetControlNamed(form, "registrationButton", true);
            checkerButton = (Button)TestUtils.GetControlNamed(form, "checkerButton", true);
            exitButton = (Button)TestUtils.GetControlNamed(form, "exitButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(registrationButton);
            Assert.NotNull(checkerButton);
            Assert.NotNull(exitButton);
        }

        [Fact]
        public void ShouldHaveAllControlsInAttendanceCheckerForm()
        {
            checkerModal = new AttendanceCheckerForm();
            checkerModal.Show();

            attendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(checkerModal, "idTextBox", true);
            checkButton = (Button)TestUtils.GetControlNamed(checkerModal, "checkButton", true);
            attendanceCheckerFormCancelButton = (Button)TestUtils.GetControlNamed(checkerModal, "cancelButton", true);

            Assert.NotNull(attendanceCheckerFormIdTextBox);
            Assert.NotNull(checkButton);
            Assert.NotNull(attendanceCheckerFormCancelButton);
        }

        [Fact]
        public void ShouldHaveAllControlsInEmployeeRegistrationForm()
        {
            registrationModal = new EmployeeRegistrationForm();
            registrationModal.Show();

            employeeRegistrationFormIdTextBox = (TextBox)TestUtils.GetControlNamed(registrationModal, "idTextBox", true);
            nameTextBox = (TextBox)TestUtils.GetControlNamed(registrationModal, "nameTextBox", true);
            registerButton = (Button)TestUtils.GetControlNamed(registrationModal, "registerButton", true);
            employeeRegistrationFormCancelButton = (Button)TestUtils.GetControlNamed(registrationModal, "cancelButton", true);

            Assert.NotNull(employeeRegistrationFormIdTextBox);
            Assert.NotNull(nameTextBox);
            Assert.NotNull(registerButton);
            Assert.NotNull(employeeRegistrationFormCancelButton);
        }

        [Fact]
        public void ShouldBeAbleToOpenAttendanceCheckerForm()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.AttendanceCheckerForm.Visible;
                form.AttendanceCheckerForm.Close();
            });

            checkerButton.PerformClick();

            registerTask.Wait();

            Assert.True(isModalShown, "The form should be visible when checker button in the main form is clicked.");
        }

        [Fact]
        public void ShouldBeAbleToOpenEmployeeRegistrationForm()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.EmployeeRegistrationForm.Visible;
                form.EmployeeRegistrationForm.Close();
            });

            registrationButton.PerformClick();

            registerTask.Wait();

            Assert.True(isModalShown, "The form should be visible when registration button in the main form is clicked.");
        }

        [Fact]
        public void ShouldBeAbleToCloseAttendanceCheckerForm()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                attendanceCheckerFormCancelButton = (Button)TestUtils.GetControlNamed(form.AttendanceCheckerForm, "cancelButton", true);

                attendanceCheckerFormCancelButton.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));

                isModalShown = form.AttendanceCheckerForm.Visible;
            });

            checkerButton.PerformClick();

            registerTask.Wait();

            Assert.False(isModalShown, "The form should be closed when Cancel button in the modal form is clicked.");
        }

        [Fact]
        public void ShouldBeAbleToCloseEmployeeRegistrationForm()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                employeeRegistrationFormCancelButton = (Button)TestUtils.GetControlNamed(form.EmployeeRegistrationForm, "cancelButton", true);

                employeeRegistrationFormCancelButton.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));

                isModalShown = form.EmployeeRegistrationForm.Visible;
            });

            registrationButton.PerformClick();

            registerTask.Wait();

            Assert.False(isModalShown, "The form should be closed when Cancel button in the modal form is clicked.");
        }

        [Fact]
        public void ShouldBeAbleToRegisterInRegistrationModal()
        {
            registrationModal = new EmployeeRegistrationForm();
            registrationModal.Show();

            employeeRegistrationFormIdTextBox = (TextBox)TestUtils.GetControlNamed(registrationModal, "idTextBox", true);
            nameTextBox = (TextBox)TestUtils.GetControlNamed(registrationModal, "nameTextBox", true);
            registerButton = (Button)TestUtils.GetControlNamed(registrationModal, "registerButton", true);

            employeeRegistrationFormIdTextBox.Text = "1";
            nameTextBox.Text = "John Doe";

            registerButton.PerformClick();

            Employee emp;
            Assert.True(EmployeeList.Employees.TryGetValue(1, out emp), "The employee `1 - John Doe` should have been saved to the list.");
        }

        [Fact]
        public void ShouldBeAbleToCheckRegisteredEmployeeInCheckerModal()
        {
            EmployeeList.Employees.Add(2, new Employee(2, "Jane Doe"));

            checkerModal = new AttendanceCheckerForm();
            checkerModal.Show();

            attendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(checkerModal, "idTextBox", true);
            checkButton = (Button)TestUtils.GetControlNamed(checkerModal, "checkButton", true);

            attendanceCheckerFormIdTextBox.Text = "2";

            checkButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should show");
            Assert.Equal("Success", MessageBoxWrapper.Title);
        }

        [Fact]
        public void ShouldBeAbleToDisplayCorrectMessageBoxForAlreadyRegisteredEmployees()
        {
            EmployeeList.Employees.Add(3, new Employee(3, "Jane Doe"));

            checkerModal = new AttendanceCheckerForm();
            checkerModal.Show();

            attendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(checkerModal, "idTextBox", true);
            checkButton = (Button)TestUtils.GetControlNamed(checkerModal, "checkButton", true);

            attendanceCheckerFormIdTextBox.Text = "3";

            checkButton.PerformClick();
            checkButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should show");
            Assert.Equal("Notice", MessageBoxWrapper.Title);
        }

        [Fact]
        public void ShouldBeAbleToDisplayCorrectMessageBoxForInvalidEmployee()
        {
            checkerModal = new AttendanceCheckerForm();
            checkerModal.Show();

            attendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(checkerModal, "idTextBox", true);
            checkButton = (Button)TestUtils.GetControlNamed(checkerModal, "checkButton", true);

            attendanceCheckerFormIdTextBox.Text = "4";

            checkButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should show");
            Assert.Equal("Invalid", MessageBoxWrapper.Title);
        }

        [Fact]
        public void ShouldBeAbleToPerformRegisterAndAttendanceCorrectly()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                employeeRegistrationFormIdTextBox = (TextBox)TestUtils.GetControlNamed(form.EmployeeRegistrationForm, "idTextBox", true);
                nameTextBox = (TextBox)TestUtils.GetControlNamed(form.EmployeeRegistrationForm, "nameTextBox", true);
                registerButton = (Button)TestUtils.GetControlNamed(form.EmployeeRegistrationForm, "registerButton", true);

                employeeRegistrationFormIdTextBox.Text = "6";
                nameTextBox.Text = "Cody";

                registerButton.PerformClick();

                await Task.Delay(TimeSpan.FromSeconds(3));
                form.EmployeeRegistrationForm.Close();
            });

            registrationButton.PerformClick();

            registerTask.Wait();

            var checkerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                attendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(form.AttendanceCheckerForm, "idTextBox", true);
                checkButton = (Button)TestUtils.GetControlNamed(form.AttendanceCheckerForm, "checkButton", true);

                attendanceCheckerFormIdTextBox.Text = "6";

                checkButton.PerformClick();

                await Task.Delay(TimeSpan.FromSeconds(3));
                form.AttendanceCheckerForm.Close();
            });

            checkerButton.PerformClick();

            checkerTask.Wait();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should show");
            Assert.Equal("Success", MessageBoxWrapper.Title);
        }

        [Fact]
        public void ShouldBeAbleToCloseFormOnExitButtonClick()
        {
            exitButton.PerformClick();

            Assert.False(form.Visible, "The main form should be closed on exit button click.");
        }
    }
}