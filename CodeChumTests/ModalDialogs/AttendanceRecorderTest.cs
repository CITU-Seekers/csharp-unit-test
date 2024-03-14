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
        // Description: Should have all the controls for the main form `registrationButton`, `checkerButton`, `exitButton`, and `form.AttendanceCheckerForm`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(registrationButton);
            Assert.NotNull(checkerButton);
            Assert.NotNull(exitButton);
        }

        [Fact]
        // Description: Should have all the controls for the attendance checker form `idTextBox`, `checkButton`, and `cancelButton`.
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
        // Description: Should have all the controls for the employee checker form `idTextBox`, `nameTextBox`, `registerButton`, and `cancelButton`.
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
        // Description: Should open attendance checker form on `checkerButton` click.
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
        // Description: Should open employee registration form on `registrationButton` click.
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
        // Description: Should close the attendance checker form on `cancelButton` click.
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
        // Description: Should close the employee registration form on `cancelButton` click.
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
        // Description: Should register employee in the registration modal form on `registerButton` click.
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
        // Description: Should check attendance of registered employee in the attendance checker modal form on `checkButton` click.
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
        // Description: Should display correct message box when checking an employee who's record has already been recorded.
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
        // Description: Should display correct message box for not registered employees in the attendance checker modal form.
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
        // Description: Should do the whole process of registering and checking attendance correctly.
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
        // Description: Should close the main form on `exitButton` click.
        public void ShouldBeAbleToCloseFormOnExitButtonClick()
        {
            exitButton.PerformClick();

            Assert.False(form.Visible, "The main form should be closed on exit button click.");
        }
    }
}