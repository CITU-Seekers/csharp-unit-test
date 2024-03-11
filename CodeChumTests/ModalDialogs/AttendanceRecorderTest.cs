namespace CodeChum.Tests
{
    public class AttendanceCheckerTests
    {
        AttendanceRecorder? form;
        AttendanceCheckerForm? checkerModal;
        EmployeeRegistrationForm? registrationModal;

        // AttendanceRecorded controls
        Button? RegistrationButton, CheckerButton, ExitButton;

        // AttendanceCheckerForm controls;
        TextBox? AttendanceCheckerFormIdTextBox;
        Button? CheckButton, AttendanceCheckerFormCancelButton;

        // EmployeeRegistrationForm controls;
        TextBox? EmployeeRegistrationFormIdTextBox, NameTextBox;
        Button? RegisterButton, EmployeeRegistrationFormCancelButton;

        public AttendanceCheckerTests()
        {
            form = new AttendanceRecorder();
            form.Show();
            RegistrationButton = (Button)TestUtils.GetControlNamed(form, "RegistrationButton", true);
            CheckerButton = (Button)TestUtils.GetControlNamed(form, "CheckerButton", true);
            ExitButton = (Button)TestUtils.GetControlNamed(form, "ExitButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            TestUtils.AssertNotNull(RegistrationButton, "No RegistrationButton found.");
            TestUtils.AssertNotNull(CheckerButton, "No CheckerButton found.");
            TestUtils.AssertNotNull(ExitButton, "No ExitButton found.");
        }

        [Fact]
        public void ShouldHaveAllControlsInAttendanceCheckerForm()
        {
            checkerModal = new AttendanceCheckerForm();
            checkerModal.Show();

            AttendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(checkerModal, "IdTextBox", true);
            CheckButton = (Button)TestUtils.GetControlNamed(checkerModal, "CheckButton", true);
            AttendanceCheckerFormCancelButton = (Button)TestUtils.GetControlNamed(checkerModal, "CancelButton", true);

            TestUtils.AssertNotNull(AttendanceCheckerFormIdTextBox, "No IdTextBox found in AttendanceCheckerForm.");
            TestUtils.AssertNotNull(CheckButton, "No CheckButton found in AttendanceCheckerForm.");
            TestUtils.AssertNotNull(AttendanceCheckerFormCancelButton, "No CancelButton found in AttendanceCheckerForm.");
        }

        [Fact]
        public void ShouldHaveAllControlsInEmployeeRegistrationForm()
        {
            registrationModal = new EmployeeRegistrationForm();
            registrationModal.Show();

            EmployeeRegistrationFormIdTextBox = (TextBox)TestUtils.GetControlNamed(registrationModal, "IdTextBox", true);
            NameTextBox = (TextBox)TestUtils.GetControlNamed(registrationModal, "NameTextBox", true);
            RegisterButton = (Button)TestUtils.GetControlNamed(registrationModal, "RegisterButton", true);
            EmployeeRegistrationFormCancelButton = (Button)TestUtils.GetControlNamed(registrationModal, "CancelButton", true);

            TestUtils.AssertNotNull(EmployeeRegistrationFormIdTextBox, "No IdTextBox found in EmployeeRegistrationForm.");
            TestUtils.AssertNotNull(NameTextBox, "No NameTextBox found in EmployeeRegistrationForm.");
            TestUtils.AssertNotNull(RegisterButton, "No RegisterButton found in EmployeeRegistrationForm.");
            TestUtils.AssertNotNull(EmployeeRegistrationFormCancelButton, "No CancelButton found in EmployeeRegistrationForm.");
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

            CheckerButton.PerformClick();

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

            RegistrationButton.PerformClick();

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
                AttendanceCheckerFormCancelButton = (Button)TestUtils.GetControlNamed(form.AttendanceCheckerForm, "CancelButton", true);

                AttendanceCheckerFormCancelButton.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));

                isModalShown = form.AttendanceCheckerForm.Visible;
            });

            CheckerButton.PerformClick();

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
                EmployeeRegistrationFormCancelButton = (Button)TestUtils.GetControlNamed(form.EmployeeRegistrationForm, "CancelButton", true);

                EmployeeRegistrationFormCancelButton.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));

                isModalShown = form.EmployeeRegistrationForm.Visible;
            });

            RegistrationButton.PerformClick();

            registerTask.Wait();

            Assert.False(isModalShown, "The form should be closed when Cancel button in the modal form is clicked.");
        }

        [Fact]
        public void ShouldBeAbleToRegisterInRegistrationModal()
        {
            registrationModal = new EmployeeRegistrationForm();
            registrationModal.Show();

            EmployeeRegistrationFormIdTextBox = (TextBox)TestUtils.GetControlNamed(registrationModal, "IdTextBox", true);
            NameTextBox = (TextBox)TestUtils.GetControlNamed(registrationModal, "NameTextBox", true);
            RegisterButton = (Button)TestUtils.GetControlNamed(registrationModal, "RegisterButton", true);

            EmployeeRegistrationFormIdTextBox.Text = "1";
            NameTextBox.Text = "John Doe";

            RegisterButton.PerformClick();

            Employee emp;
            Assert.True(EmployeeList.Employees.TryGetValue(1, out emp), "The employee `1 - John Doe` should have been saved to the list.");
        }

        [Fact]
        public void ShouldBeAbleToCheckRegisteredEmployeeInCheckerModal()
        {
            EmployeeList.Employees.Add(2, new Employee(2, "Jane Doe"));

            checkerModal = new AttendanceCheckerForm();
            checkerModal.Show();

            AttendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(checkerModal, "IdTextBox", true);
            CheckButton = (Button)TestUtils.GetControlNamed(checkerModal, "CheckButton", true);

            AttendanceCheckerFormIdTextBox.Text = "2";

            CheckButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should show");
            Assert.Equal("Success", MessageBoxWrapper.Title);
        }

        [Fact]
        public void ShouldBeAbleToDisplayCorrectMessageBoxForAlreadyRegisteredEmployees()
        {
            EmployeeList.Employees.Add(3, new Employee(3, "Jane Doe"));

            checkerModal = new AttendanceCheckerForm();
            checkerModal.Show();

            AttendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(checkerModal, "IdTextBox", true);
            CheckButton = (Button)TestUtils.GetControlNamed(checkerModal, "CheckButton", true);

            AttendanceCheckerFormIdTextBox.Text = "3";

            CheckButton.PerformClick();
            CheckButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should show");
            Assert.Equal("Notice", MessageBoxWrapper.Title);
        }

        [Fact]
        public void ShouldBeAbleToDisplayCorrectMessageBoxForInvalidEmployee()
        {
            checkerModal = new AttendanceCheckerForm();
            checkerModal.Show();

            AttendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(checkerModal, "IdTextBox", true);
            CheckButton = (Button)TestUtils.GetControlNamed(checkerModal, "CheckButton", true);

            AttendanceCheckerFormIdTextBox.Text = "4";

            CheckButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should show");
            Assert.Equal("Invalid", MessageBoxWrapper.Title);
        }

        [Fact]
        public void ShouldBeAbleToPerformRegisterAndAttendanceCorrectly()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                EmployeeRegistrationFormIdTextBox = (TextBox)TestUtils.GetControlNamed(form.EmployeeRegistrationForm, "IdTextBox", true);
                NameTextBox = (TextBox)TestUtils.GetControlNamed(form.EmployeeRegistrationForm, "NameTextBox", true);
                RegisterButton = (Button)TestUtils.GetControlNamed(form.EmployeeRegistrationForm, "RegisterButton", true);

                EmployeeRegistrationFormIdTextBox.Text = "6";
                NameTextBox.Text = "Cody";

                RegisterButton.PerformClick();

                await Task.Delay(TimeSpan.FromSeconds(3));
                form.EmployeeRegistrationForm.Close();
            });

            RegistrationButton.PerformClick();

            registerTask.Wait();

            var checkerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                AttendanceCheckerFormIdTextBox = (TextBox)TestUtils.GetControlNamed(form.AttendanceCheckerForm, "IdTextBox", true);
                CheckButton = (Button)TestUtils.GetControlNamed(form.AttendanceCheckerForm, "CheckButton", true);

                AttendanceCheckerFormIdTextBox.Text = "6";

                CheckButton.PerformClick();

                await Task.Delay(TimeSpan.FromSeconds(3));
                form.AttendanceCheckerForm.Close();
            });

            CheckerButton.PerformClick();

            checkerTask.Wait();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should show");
            Assert.Equal("Success", MessageBoxWrapper.Title);
        }

        [Fact]
        public void ShouldBeAbleToCloseFormOnExitButtonClick()
        {
            ExitButton.PerformClick();

            Assert.False(form.Visible, "The main form should be closed on exit button click.");
        }
    }
}